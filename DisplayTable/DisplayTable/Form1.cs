using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private BooksDataContext database = new BooksDataContext();

        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            authorBindingSource.DataSource =
                from author in database.Authors
                orderby author.AuthorID
                select author;
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();
            database.SubmitChanges();
        }
    }
}
