using System;
using System.Windows.Forms;

namespace SortingStrings
{
    public partial class SortingStrings : Form
    {
        public SortingStrings()
        {
            InitializeComponent();
            AcceptButton = addButton; // enter key triggers addButton
        }

        // handles addButton click
        private void addButton_Click(object sender, EventArgs e)
        {
            userListListBox.Items.Add(userInputTextBox.Text);
            userListListBox.Sorted = true;
            userInputTextBox.Focus();
            userInputTextBox.SelectAll();
        }
    }
}
