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
    public partial class Tab_SearchBooks : UserControl
    {
        Database_Book database_Book;
        DataTable dt;
        public Tab_SearchBooks()
        {
            InitializeComponent();
        }

        private void Tab_SearchBooks_Load(object sender, EventArgs e)
        {
            GridViewFormLoadLeft(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void GridViewFormLoadLeft(string SererName, string DatabaseName)
        {
            database_Book = new Database_Book(SererName, DatabaseName);
            dt = database_Book.getCustomTable("SELECT BookID, BookName, BookType, Remaining, Price FROM Books");

            if (dt != null)
            {
                DGV_SearchBook_Left.DataSource = dt;
                DGV_SearchBook_Left.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_SearchBook_Left_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = DGV_SearchBook_Left.Columns[e.ColumnIndex].Name;
            int amount = 0;
            /*            if (col == "ActionColumn")
                        {*/
            foreach (DataGridViewRow dgr in DGV_SearchBook_Right.Rows)
            {
                if (DGV_SearchBook_Left.Rows[e.RowIndex].Cells[1].Value.ToString() == dgr.Cells[1].Value.ToString())
                {
                    amount++;
                    dgr.Cells[5].Value = amount;
                    return;
                }
            }
            DGV_SearchBook_Right.Rows.Add(DGV_SearchBook_Left.Rows[e.RowIndex].Cells[1].Value.ToString(), DGV_SearchBook_Left.Rows[e.RowIndex].Cells[2].Value.ToString(), DGV_SearchBook_Left.Rows[e.RowIndex].Cells[3].Value.ToString(), DGV_SearchBook_Left.Rows[e.RowIndex].Cells[5].Value.ToString(), amount);
/*            }*/
        }
    }
}
