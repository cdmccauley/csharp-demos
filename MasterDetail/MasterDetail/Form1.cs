using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDetail
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private BooksDataContext database = new BooksDataContext();

        private class AuthorBinding
        {
            public Author Author { get; set; }
            public string Name { get; set; }
        }

        private void Details_Load(object sender, EventArgs e)
        {
            authorComboBox.DisplayMember = "Name";

            authorComboBox.DataSource =
                from author in database.Authors
                orderby author.LastName, author.FirstName
                select new AuthorBinding { Author = author, Name = author.FirstName + " " + author.LastName };

            titleComboBox.DisplayMember = "Title1";

            titleComboBox.DataSource =
                from title in database.Titles
                orderby title.Title1
                select title;

            booksDataGridView.DataSource = null;
        }

        private void authorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author currentAuthor = ((AuthorBinding)authorComboBox.SelectedItem).Author;

            titleBindingSource.DataSource =
                from book in currentAuthor.AuthorISBNs
                select book.Title;

            booksDataGridView.DataSource = titleBindingSource;
        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Title currentTitle = (Title)titleComboBox.SelectedItem;

            authorBindingSource.DataSource =
                from book in currentTitle.AuthorISBNs
                select book.Author;

            booksDataGridView.DataSource = authorBindingSource;
        }
    }
}
