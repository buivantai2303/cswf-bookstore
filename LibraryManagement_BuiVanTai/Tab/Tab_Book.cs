using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Tab
{
    public partial class Tab_Book : UserControl
    {
        Database_Book Database_Book;
        DataTable dt;
        public Tab_Book()
        {
            InitializeComponent();
        }

        private void BTN_Books_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Book book = new Class_Book(TB_Books_ID.Text, TB_Books_Name.Text, TB_Books_Remaining.Text, TB_Books_Type.Text, CBB_Books_PublisherName.Text, CBB_Books_AuthorName.Text, TB_Books_Price.Text);
                if (Database_Book.InsertData(book) == true)
                {
                    MessageBox.Show("Add Successfuly");
                }
                else
                {
                    MessageBox.Show("There is something wrong!! Please Contact IT support");
                }
            }
            catch
            {
                MessageBox.Show("There is something wrong!! Please Contact IT support");
            }
        }

        private void Tab_Book_Load(object sender, EventArgs e)
        {

        }

        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            Database_Book = new Database_Book(ServerName, DatabaseName);
            dt = Database_Book.getTable();


            if (dt != null)
            {
                DGV_Books.DataSource = dt;
                DGV_Books.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
