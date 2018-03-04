using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayQueryResult
{
    public partial class TitleQueries : Form
    {
        public TitleQueries()
        {
            InitializeComponent();
        }

        private BooksDataContext database = new BooksDataContext();

        private void TitleQueries_Load(object sender, EventArgs e)
        {
            database.Log = Console.Out;

            queriesComboBox.SelectedIndex = 0;
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            titleBindingSource.EndEdit();
            database.SubmitChanges();

            queriesComboBox.SelectedIndex = 0;
        }

        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (queriesComboBox.SelectedIndex)
            {
                case 0:
                    titleBindingSource.DataSource =
                        from book in database.Titles
                        orderby book.Title1
                        select book;
                    break;
                case 1:
                    titleBindingSource.DataSource =
                        from book in database.Titles
                        where book.Copyright == "2008"
                        orderby book.Title1
                        select book;
                    break;
                case 2:
                    titleBindingSource.DataSource =
                        from book in database.Titles
                        where book.Title1.EndsWith("How to Program")
                        orderby book.Title1
                        select book;
                    break;
            }

            titleBindingSource.MoveFirst();
        }

        
    }
}
