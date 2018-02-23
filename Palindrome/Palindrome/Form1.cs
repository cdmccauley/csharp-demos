using System;
using System.Text;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class PalindromeForm : Form
    {
        // constructor
        public PalindromeForm()
        {
            InitializeComponent();
        }

        // test button click event handler
        private void testButton_Click(object sender, EventArgs e)
        {
            StringBuilder cleanString = new StringBuilder();
            StringBuilder reverseString = new StringBuilder();

            outputLabel.Text = "";
            foreach (char character in inputTextBox.Text)
                if (Char.IsLetter(character))
                    cleanString.Append(character);
            for (int i = cleanString.Length - 1; i >= 0; --i)
                reverseString.Append(cleanString[i]);
            if (cleanString.ToString().ToLower().Equals(reverseString.ToString().ToLower()))
                outputLabel.Text = "This is a palindrome!";
            else
                outputLabel.Text = "This is not a palindrome.";
        }
    }
}
