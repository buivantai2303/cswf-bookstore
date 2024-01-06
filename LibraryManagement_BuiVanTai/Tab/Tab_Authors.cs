using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using LibraryManagement_BuiVanTai.Database;
using LibraryManagement_BuiVanTai.Class;

namespace LibraryManagement_BuiVanTai.Tab
{
    public partial class Tab_Authors : UserControl
    {
        Database_Author Database_Author;
        DataTable dt = null;
        public Tab_Authors()
        {
            InitializeComponent();
        }

        private void BTN_Authors_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Author at = new Class_Author(TB_Authors_ID.Text, TB_Authors_Name.Text, Date_Authors_AuthorID.Text, TB_Authors_Address.Text, TB_Authors_Email.Text);
                if (Database_Author.InsertData(at) == true)
                {
                    MessageBox.Show("Add Successfuly");
                    refresh();
                    GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                } else
                {
                    MessageBox.Show("There is something wrong!! Please Contact IT support");
                }
            } catch
            {
                MessageBox.Show("There is something wrong!! Please Contact IT support");
            }
        }

        private void DGV_Authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*            TB_Authors_ID.Enabled = false;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV_Authors.Rows[index];

            TB_Authors_ID.Text = selectedRow.Cells[1].Value.ToString();
            TB_Authors_Name.Text = selectedRow.Cells[2].Value.ToString();
            if (DateTime.TryParse(selectedRow.Cells[3].Value.ToString(), out DateTime importDate))
            {
                Date_Authors_AuthorID.Value = importDate;
            }
            else
            {
                MessageBox.Show("Error parsing import date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TB_Authors_Address.Text = selectedRow.Cells[4].Value.ToString();
            TB_Authors_Email.Text = selectedRow.Cells[5].Value.ToString();*/
        }

        private void Tab_Authors_Load(object sender, EventArgs e)
        {
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            BTN_Authors_Add.Enabled = false;
        }

        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            Database_Author = new Database_Author(ServerName, DatabaseName);
            dt = Database_Author.getTable();


            if (dt != null)
            {
                DGV_Authors.DataSource = dt;
                DGV_Authors.RowHeadersVisible = false;

                // Set the DateTimePicker format to "yyyy-MM-dd"
                Date_Authors_AuthorID.Format = DateTimePickerFormat.Custom;
                Date_Authors_AuthorID.CustomFormat = "yyyy-MM-dd";
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Authors_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Author at = new Class_Author(TB_Authors_ID.Text, TB_Authors_Name.Text, Date_Authors_AuthorID.Text, TB_Authors_Address.Text, TB_Authors_Email.Text);
                if (Database_Author.UpdateData(at) == true)
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

        public void refresh()
        {
            TB_Authors_ID.Enabled = true;
            TB_Authors_ID.Text = null;
            TB_Authors_Name.Text = null;
            Date_Authors_AuthorID.Text = DateTime.Now.ToString();
            TB_Authors_Email.Text = null;
            TB_Authors_Address.Text = null;
        }


        private void BTN_Authors_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void TB_Authors_ID_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Authors_Name_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Authors_Email_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Authors_Address_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        public void CheckNull()
        {
            if (TB_Authors_Address.Text == "" || TB_Authors_ID.Text == "" || TB_Authors_Email.Text == "" || TB_Authors_Name.Text == "")
            {
                BTN_Authors_Add.Enabled = false;
            }
            else
            {
                BTN_Authors_Add.Enabled = true;
            }
        }
        private void DGV_Authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGV_Authors.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_Authors.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Class_Author at = new Class_Author(DGV_Authors.Rows[e.RowIndex].Cells[1].Value.ToString());
                    if (Database_Author.DeleteData(at) == true)
                    {
                    int rowIndex = DGV_Authors.CurrentCell.RowIndex;
                    DGV_Authors.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void DGV_Authors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Authors_ID.Enabled = false;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV_Authors.Rows[index];

            TB_Authors_ID.Text = selectedRow.Cells[1].Value.ToString();
            TB_Authors_Name.Text = selectedRow.Cells[2].Value.ToString();
            if (DateTime.TryParse(selectedRow.Cells[3].Value.ToString(), out DateTime importDate))
            {
                Date_Authors_AuthorID.Value = importDate;
            }
            else
            {
                MessageBox.Show("Error parsing import date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TB_Authors_Address.Text = selectedRow.Cells[4].Value.ToString();
            TB_Authors_Email.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void TB_Authors_Search_TextChanged(object sender, EventArgs e)
        {
/*            dt = Database_Author.searchData(TB_Authors_Search.Text);
            DGV_Authors.DataSource = dt;*/
        }
    }
}
