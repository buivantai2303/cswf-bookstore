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
                Class_Book book = new Class_Book(TB_Books_ID.Text, TB_Books_Name.Text, TB_Books_Remaining.Text, TB_Books_Type.Text, CBB_Books_PublisherID.Text, CBB_Books_AuthorID.Text, TB_Books_Price.Text);
                if (Database_Book.InsertData(book) == true)
                {
                    MessageBox.Show("Add Successfuly");
                    refresh();
                    GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
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
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            Database_Book = new Database_Book(ServerName, DatabaseName);
            dt = Database_Book.getCustomTable("SELECT BookID, BookName, Remaining, BookType, b.PublisherID, b.AuthorID, Price FROM Books b \r\nINNER JOIN Publishers p ON b.PublisherID=p.PublisherID\r\nINNER JOIN Authors a ON a.AuthorID=b.AuthorID");
            DataTable dtAuthor = Database_Book.getCustomTable("SELECT AuthorID FROM Authors");
            DataTable dtPublisher = Database_Book.getCustomTable("SELECT PublisherID FROM Publishers");


            CBB_Books_AuthorID.DisplayMember = "AuthorID";
            CBB_Books_PublisherID.DisplayMember = "PublisherID";
            CBB_Books_AuthorID.DataSource = dtAuthor;
            CBB_Books_PublisherID.DataSource = dtPublisher;

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

        public void refresh()
        {
            TB_Books_ID.Text = "";
            TB_Books_Name.Text = "";
            TB_Books_Price.Text = "";
            TB_Books_Remaining.Text = "";
            CBB_Books_AuthorID.Text = "";
            CBB_Books_PublisherID.Text = "";
            TB_Books_Type.Text = "";
        }

        public void CheckNull()
        {
            if (TB_Books_Remaining.Text == "" || TB_Books_ID.Text == "" || TB_Books_Name.Text == "" || TB_Books_Type.Text == "" || TB_Books_Price.Text == "")
            {
                BTN_Books_Add.Enabled = false;
            } else
            {
                BTN_Books_Add.Enabled = true;
            }
        }

        private void BTN_Books_Refresh_Click(object sender, EventArgs e)
        {
            TB_Books_ID.Enabled = true;
            refresh();
        }

        private void DGV_Books_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Books_ID.Enabled = false;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV_Books.Rows[index];

            TB_Books_ID.Text = selectedRow.Cells[1].Value.ToString();
            TB_Books_Name.Text = selectedRow.Cells[2].Value.ToString();
            TB_Books_Remaining.Text = selectedRow.Cells[3].Value.ToString();
            TB_Books_Type.Text = selectedRow.Cells[4].Value.ToString();
            CBB_Books_PublisherID.Text = selectedRow.Cells[5].Value.ToString();
            CBB_Books_AuthorID.Text = selectedRow.Cells[6].Value.ToString();
            TB_Books_Price.Text = selectedRow.Cells[7].Value.ToString();
            BTN_Books_Add.Enabled = false;
        }

        private void DGV_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Class_Book book = new Class_Book(TB_Books_ID.Text);
            if (e.RowIndex >= 0 && DGV_Books.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_Books.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Class_Author at = new Class_Author(DGV_Books.Rows[e.RowIndex].Cells[1].Value.ToString());
                    if (Database_Book.DeleteData(book) == true)
                    {
                        int rowIndex = DGV_Books.CurrentCell.RowIndex;
                        DGV_Books.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BTN_Books_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Book book = new Class_Book(TB_Books_ID.Text, TB_Books_Name.Text, TB_Books_Remaining.Text, TB_Books_Type.Text, CBB_Books_PublisherID.Text, CBB_Books_AuthorID.Text, TB_Books_Price.Text);
                if (Database_Book.UpdateData(book) == true)
                {
                    MessageBox.Show("Add Successfuly");
                    TB_Books_ID.Enabled = true;
                    refresh();
                    GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
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

        private void CBB_Books_PublisherName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtPublisher = Database_Book.getCustomTable("SELECT PublisherID, PublisherName FROM Publishers");

            foreach (DataRow dr in dtPublisher.Rows)
            {
                if (CBB_Books_PublisherID.Text == dr[0].ToString())
                {
                    TB_Books_PublisherName.Text = dr[1].ToString();
                }
            }
        }

        private void CBB_Books_AuthorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtAuthor = Database_Book.getCustomTable("SELECT AuthorID, AuthorName FROM Authors");

            foreach (DataRow dr in dtAuthor.Rows)
            {
                if (CBB_Books_AuthorID.Text == dr[0].ToString())
                {
                    TB_Books_AuthorName.Text = dr[1].ToString();
                }
            }
        }

        private void TB_Books_Search_TextChanged(object sender, EventArgs e)
        {
            dt = Database_Book.searchData(TB_Books_Search.Text);
            DGV_Books.DataSource = dt;
        }

        private void TB_Books_ID_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Books_Name_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Books_Remaining_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Books_Type_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Books_Price_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }
    }
}
