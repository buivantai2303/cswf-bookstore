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
    public partial class Tab_Staffs : UserControl
    {
        Database_Staff database_Staff;
        DataTable dt;
        public Tab_Staffs()
        {
            InitializeComponent();
        }

        private void BTN_Staff_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Staff sta = new Class_Staff(TB_Staff_ID.Text, TB_Staff_Name.Text, Date_Staffs.Text, TB_Staff_Address.Text, TB_Staff_Tel.Text);
                if (database_Staff.InsertData(sta) == true)
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
            BTN_Staff_Save.Enabled = false;
            TB_Staff_ID.Enabled = true;
            TB_Staff_ID.Text = null;
            TB_Staff_Name.Text = null;
            Date_Staffs.Text = DateTime.Now.ToString();
            TB_Staff_Address.Text = null;
            TB_Staff_Tel.Text = null;
        }

        private void Tab_Staffs_Load(object sender, EventArgs e)
        {
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            BTN_Staff_Add.Enabled = false;
        }
        public void GridViewFormLoad(string SererName, string DatabaseName)
        {
            database_Staff = new Database_Staff(SererName, DatabaseName);
            dt = database_Staff.getTable();

            if (dt != null)
            {
                DGV_Staff.DataSource = dt;
                DGV_Staff.RowHeadersVisible = false;

                Date_Staffs.Format = DateTimePickerFormat.Custom;
                Date_Staffs.CustomFormat = "yyyy-MM-dd";
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Staff_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Staff sta = new Class_Staff(TB_Staff_ID.Text, TB_Staff_Name.Text, Date_Staffs.Text, TB_Staff_Address.Text, TB_Staff_Tel.Text);
                if (database_Staff.UpdateData(sta) == true)
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
            BTN_Staff_Save.Enabled = false;
        }

        public void CheckNull()
        {
            if (TB_Staff_ID.Text == "" || TB_Staff_Name.Text == "" || TB_Staff_Address.Text == "" || TB_Staff_Tel.Text == "")
            {
                BTN_Staff_Add.Enabled = false;
            }
            else
            {
                BTN_Staff_Add.Enabled = true;
            }
        }

        private void TB_Staff_ID_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Staff_Name_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Staff_Tel_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB_Staff_Address_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        private void TB__Staff_Search_TextChanged(object sender, EventArgs e)
        {
            dt = database_Staff.searchData(TB__Staff_Search.Text);
            DGV_Staff.DataSource = dt;
        }

        private void BTN_Staff_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void DGV_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Staff_Save.Enabled = true;
            if (e.RowIndex >= 0 && DGV_Staff.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_Staff.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Class_Staff sta = new Class_Staff(DGV_Staff.Rows[e.RowIndex].Cells[1].Value.ToString());
                    if (database_Staff.DeleteData(sta) == true)
                    {
                        int rowIndex = DGV_Staff.CurrentCell.RowIndex;
                        DGV_Staff.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void DGV_Staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Staff_ID.Enabled = false;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV_Staff.Rows[index];

            TB_Staff_ID.Text = selectedRow.Cells[1].Value.ToString();
            TB_Staff_Name.Text = selectedRow.Cells[2].Value.ToString();
            if (DateTime.TryParse(selectedRow.Cells[3].Value.ToString(), out DateTime importDate))
            {
                Date_Staffs.Value = importDate;
            }
            else
            {
                MessageBox.Show("Error parsing import date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TB_Staff_Address.Text = selectedRow.Cells[4].Value.ToString();
            TB_Staff_Tel.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void DGV_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   
}
