using System;
using System.Windows.Forms;
using StudentFilesLibrary; // using dll
using System.IO;

namespace WriteStudentScores
{
    public partial class WriteStudentScoresForm : BaseStudentFilesForm // derived from dll
    {
        // declarations
        StudentFile fileBuffer;
        StreamWriter fileWriter;

        // constructor
        public WriteStudentScoresForm()
        {
            InitializeComponent();
            fileBuffer = new StudentFile();
        }

        // enter button click event handler, creates record in "file buffer"
        private void enterButton_Click(object sender, EventArgs e)
        {
            // create record in buffer
            fileBuffer.studentRecords.Add(new StudentFile.StudentRecord(
                base.Controls[12].Text,
                base.Controls[10].Text,
                base.Controls[8].Text,
                base.Controls[6].Text,
                base.Controls[4].Text));

            // indicate success
            outputLabel.Text = "Record entered successfully!";

            // clear inputs
            for (int i = 4; i <= 12; i += 2)
                base.Controls[i].Text = string.Empty;

            // enable file save
            if (!saveAsButton.Enabled)
                saveAsButton.Enabled = true;
        }

        // save as button click event handler, writes records from file buffer to file
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                try
                {
                    // create output stream
                    FileStream output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    fileWriter = new StreamWriter(output);

                    // write file buffer to file
                    foreach (StudentFile.StudentRecord record in fileBuffer.studentRecords)
                        fileWriter.WriteLine(record);

                    // close output stream
                    fileWriter.Close();

                    // clear inputs
                    for (int i = 4; i <= 12; i += 2)
                        base.Controls[i].Text = string.Empty;

                    // indicate success
                    outputLabel.Text = "File created, new file started.";

                    // clear buffer
                    fileBuffer.studentRecords.Clear();

                    // disable save
                    saveAsButton.Enabled = false;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // exit button event handler, closes application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
