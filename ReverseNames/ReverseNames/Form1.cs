using System;
using System.Text;
using System.Windows.Forms;

namespace ReverseNames
{
    public partial class ReverseNamesForm : Form
    {
        // constructor
        public ReverseNamesForm()
        {
            InitializeComponent();
        }

        // reverse button click event handler
        private void reverseButton_Click(object sender, EventArgs e)
        {
            // declarations
            string[] nameComponents = inputTextBox.Text.Split();
            StringBuilder reverseName = new StringBuilder();

            foreach (string nameComponent in nameComponents)
            {
                for (int i = nameComponent.Length - 1; i >= 0; --i)
                {
                    if (i == nameComponent.Length - 1)
                        reverseName.Append(nameComponent.ToUpper()[i]);
                    else if (i == 0)
                        reverseName.Append(nameComponent.ToLower()[i]);
                    else
                        reverseName.Append(nameComponent[i]);
                }
                reverseName.Append(" ");
            }
            outputLabel.Text = reverseName.ToString().Trim();
        }
    }
}
