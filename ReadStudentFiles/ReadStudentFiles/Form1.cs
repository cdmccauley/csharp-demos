using System;
using System.Windows.Forms;
using System.IO;

namespace ReadStudentFiles
{
    public partial class ReadStudentFilesForm : Form
    {
        // declarations
        StudentFile fileBuffer;

        // constructor
        public ReadStudentFilesForm()
        {
            InitializeComponent();
        }

        // open button click event handler, open file and load representation to "buffer"
        private void openButton_Click(object sender, EventArgs e)
        {
            // declarations
            StreamReader fileReader;
            DialogResult result;
            string fileName, studentRecord;

            // clear rtb
            outputRichTextBox.Clear();

            // open file
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.Filter = "Text files (*.txt)|*.txt";
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                try
                {
                    // delcarations
                    fileBuffer = new StudentFile();
                    // open stream
                    FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    fileReader = new StreamReader(input);

                    // create records in "buffer"
                    studentRecord = fileReader.ReadLine();
                    while (studentRecord != null)
                    {
                        string[] recordFields = studentRecord.Split(',');
                        foreach (string field in recordFields)
                            field.Trim();
                        fileBuffer.studentRecords.Add(
                            new StudentFile.StudentRecord(
                                recordFields[0],
                                recordFields[1],
                                recordFields[2],
                                recordFields[3],
                                recordFields[4]));
                        studentRecord = fileReader.ReadLine();
                    }

                    // close stream
                    fileReader.Close();
                    input.Close();

                    // enable buttons
                    if (!studentButton.Enabled)
                        studentButton.Enabled = true;
                    if (!classButton.Enabled)
                        classButton.Enabled = true;
                    if (!gradeButton.Enabled)
                        gradeButton.Enabled = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // student button click event handler, display all records in "buffer"
        private void studentButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Clear();
            foreach (StudentFile.StudentRecord record in fileBuffer.studentRecords)
                outputRichTextBox.AppendText(record.ToString() + "\n");
        }

        // class button click event handler, display names and class names from all records in "buffer"
        private void classButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Clear();
            foreach (StudentFile.StudentRecord record in fileBuffer.studentRecords)
                outputRichTextBox.AppendText(string.Format("{0}, {1}, {2}\n", record.FirstName, record.LastName, record.ClassName));
        }

        // grade button click event handler, display names and grades from all records in "buffer"
        private void gradeButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Clear();
            foreach (StudentFile.StudentRecord record in fileBuffer.studentRecords)
                outputRichTextBox.AppendText(string.Format("{0}, {1}, {2}\n", record.FirstName, record.LastName, record.ClassGrade));
        }

        // exit button click event handler, exit application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
