using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Tab
{
    public partial class Tab_Customers : UserControl
    {
        Database_Customer Database_Customer;
        DataTable dt;
        public Tab_Customers()
        {
            InitializeComponent();
        }

        private void Tab_Customers_Load(object sender, EventArgs e)
        {
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
/*            splitContainer1.IsSplitterFixed = true;
*/        }

        public void GridViewFormLoad(string SererName, string DatabaseName)
        {
            Database_Customer = new Database_Customer(SererName, DatabaseName);
            dt = Database_Customer.getTable();

            if (dt != null)
            {
                DGV_Publisger.DataSource = dt;
                DGV_Publisger.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Customer_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Customer cus = new Class_Customer(TB_Customer_ID.Text, TB_Customer_Firstname.Text, TB_Customer_LastName.Text, TB_Customer_Tel.Text, TB_Customer_Address.Text);
                if (Database_Customer.InsertData(cus) == true)
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

        private void BTN_Customer_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Customer cus = new Class_Customer(TB_Customer_ID.Text, TB_Customer_Firstname.Text, TB_Customer_LastName.Text, TB_Customer_Tel.Text, TB_Customer_Address.Text);
                if (Database_Customer.UpdateData(cus) == true)
                {
                    MessageBox.Show("Save Successfuly");
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
            TB_Customer_ID.Enabled = true;
            TB_Customer_ID.Text = "";
            TB_Customer_Firstname.Text = "";
            TB_Customer_LastName.Text = "";
            TB_Customer_Address.Text = "";
            TB_Customer_Tel.Text = "";
        }

        public void CheckNull()
        {
            if (TB_Customer_ID.Text == "" || TB_Customer_Firstname.Text == "" || TB_Customer_LastName.Text == "" || TB_Customer_Address.Text == "" || TB_Customer_Tel.Text == "")
            {
                BTN_Customer_Add.Enabled = false;
            }
            else
            {
                BTN_Customer_Add.Enabled = true;
            }
        }

        private void BTN_Customer_Refresh_Click(object sender, EventArgs e)
        {
            BTN_Customer_Add.Enabled = true;
            refresh();
        }

        private void DGV_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Class_Customer cus = new Class_Customer(TB_Customer_ID.Text);
            if (e.RowIndex >= 0 && DGV_Publisger.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_Publisger.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Class_Author at = new Class_Author(DGV_Publisger.Rows[e.RowIndex].Cells[1].Value.ToString());
                    if (Database_Customer.DeleteData(cus) == true)
                    {
                        int rowIndex = DGV_Publisger.CurrentCell.RowIndex;
                        DGV_Publisger.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void DGV_Customer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Customer_ID.Enabled = false;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV_Publisger.Rows[index];

            TB_Customer_ID.Text = selectedRow.Cells[1].Value.ToString();
            TB_Customer_Firstname.Text = selectedRow.Cells[2].Value.ToString();
            TB_Customer_LastName.Text = selectedRow.Cells[3].Value.ToString();
            TB_Customer_Tel.Text = selectedRow.Cells[4].Value.ToString();
            TB_Customer_Address.Text = selectedRow.Cells[5].Value.ToString();
            BTN_Customer_Add.Enabled = false;
        }

        private void TB_Customer_Search_TextChanged(object sender, EventArgs e)
        {
            dt = Database_Customer.searchData(TB_Customer_Search.Text);
            DGV_Publisger.DataSource = dt;
        }
    }
}
