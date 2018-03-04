using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinQueries
{
    public partial class JoiningTableData : Form
    {
        public JoiningTableData()
        {
            InitializeComponent();
        }

        private void JoiningTableData_Load(object sender, EventArgs e)
        {
            BooksDataContext database = new BooksDataContext();

            var authorsAndISBNs =
                from author in database.Authors
                from book in author.AuthorISBNs
                orderby author.LastName, author.FirstName
                select new { author.FirstName, author.LastName, book.ISBN };

            outputTextBox.AppendText("Authors and ISBNs:");

            foreach (var element in authorsAndISBNs)
            {
                outputTextBox.AppendText(String.Format("\r\n\t{0,-10} {1,-10} {2,-10}", 
                    element.FirstName, element.LastName, element.ISBN));
            }

            var authorsAndTitles =
                from title in database.Titles
                from book in title.AuthorISBNs
                let author = book.Author
                orderby author.LastName, author.FirstName, title.Title1
                select new { author.FirstName, author.LastName, title.Title1 };

            outputTextBox.AppendText("\r\n\r\nAuthors and titles:");

            foreach (var element in authorsAndTitles)
            {
                outputTextBox.AppendText(String.Format("\r\n\t{0,-10} {1,-10} {2}", 
                    element.FirstName, element.LastName, element.Title1));
            }

            var titlesByAuthor =
                from author in database.Authors
                orderby author.LastName, author.FirstName
                select new { Name = author.FirstName + " " + author.LastName,
                    Titles = 
                    from book in author.AuthorISBNs
                    orderby book.Title.Title1
                    select book.Title.Title1 };

            outputTextBox.AppendText("\r\n\r\nTitles grouped by author:");

            foreach ( var author in titlesByAuthor)
            {
                outputTextBox.AppendText("\r\n\t" + author.Name + ":");

                foreach (var title in author.Titles)
                {
                    outputTextBox.AppendText("\r\n\t\t" + title);
                }
            }
        }
    }
}
