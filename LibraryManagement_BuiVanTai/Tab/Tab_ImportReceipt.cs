using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Tab
{
    public partial class Tab_ImportReceipt : UserControl
    {

        Database_ImportReceipt DB_ImportReceipt = null;
        System.Data.DataTable dataTable_ImportReceipt = null;


        public Tab_ImportReceipt()
        {
            InitializeComponent();
        }

        private void Tab_ImportReceipt_Load(object sender, EventArgs e)
        {

            // Load data to GridView.
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            DB_ImportReceipt = new Database_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            DB_ImportReceipt = new Database_ImportReceipt(ServerName, DatabaseName);
            dataTable_ImportReceipt = DB_ImportReceipt.getTable();
            DGV_ImportReceipt.DataSource = dataTable_ImportReceipt;
            DGV_ImportReceipt.RowHeadersVisible = false;
            DGView_ImportReceipt_ReceiptDetails.RowHeadersVisible = false;

        }

        private void DGView_ImportReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Class_ImportReceipt importReceipt = new Class_ImportReceipt();*/

            // Select only delete icon and question to delete access
            if (e.RowIndex >= 0 && DGV_ImportReceipt.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_ImportReceipt.Rows[e.RowIndex].Cells[1].Value.ToString();
/*                    DB_Suppliers.DeletDataByID(columnIDValue);*/

                    int rowIndex = DGV_ImportReceipt.CurrentCell.RowIndex;
/*                    DGView_Suppliers.Rows.RemoveAt(rowIndex);*/

                    MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            else if (e.RowIndex >= 0 && DGV_ImportReceipt.Columns[e.ColumnIndex].Name == "Information")
            {

            }
        }

        private void DGView_ImportReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
