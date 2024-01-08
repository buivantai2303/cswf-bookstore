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
    public partial class Tab_SalesReceipt : UserControl
    {

        Database_SaleReceipts DB_SaleReceipt = null;
        System.Data.DataTable dataTable_SaleReceipt = null;

        Database_SaleReceiptDetail DB_SaletReceiptDetails = null;
        System.Data.DataTable dataTable_SaleReceiptDetails = null;


        public Tab_SalesReceipt()
        {
            InitializeComponent();
        }


        private void Tab_SalesReceipt_Load(object sender, EventArgs e)
        {
            GridViewFormLoad_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void GridViewFormLoad_ImportReceipt(string ServerName, string DatabaseName)
        {
            DB_SaleReceipt = new Database_SaleReceipts(ServerName, DatabaseName);
            dataTable_SaleReceipt = DB_SaleReceipt.getTable();

            if (dataTable_SaleReceipt != null)
            {
                DGV_SaleReceipt_ImportReceipt.DataSource = dataTable_SaleReceipt;
                DGV_SaleReceipt_ImportReceipt.RowHeadersVisible = false;
                DGV_SaleReceipt_ImportReceipt.RowHeadersVisible = false;

                // Set the DateTimePicker format to "yyyy-MM-dd"
                /*                Date_ImportDate.Format = DateTimePickerFormat.Custom;
                                Date_ImportDate.CustomFormat = "yyyy-MM-dd";*/
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DGV_SaleReceipt_ImportReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DGV_SaleReceipt_ImportReceipt.Rows[index];
                GridViewFormLoad_SaleReceiptDetails(ClassDefineName.servername, ClassDefineName.database_name, selectedRow.Cells[1].Value.ToString());

                // Calculate total when any cell is clicked (remove the Price condition)
                CalculateTotalPrice();
            }
        }


        private void CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in DGV_SaleReceipt_ReciptDetails.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    decimal price = decimal.Parse(row.Cells[3].Value.ToString());
                    decimal amount = decimal.Parse(row.Cells[1].Value.ToString());
                    totalPrice += price*amount;
                }
            }

            LB_SaleReceipt_Total.Text = $"Total: {totalPrice} ";
        }


        public void GridViewFormLoad_SaleReceiptDetails(string ServerName, string DatabaseName, string SelectedID)
        {
            DB_SaletReceiptDetails = new Database_SaleReceiptDetail(ServerName, DatabaseName);
            dataTable_SaleReceiptDetails = DB_SaletReceiptDetails.getTable(SelectedID);

            if (dataTable_SaleReceiptDetails != null)
            {
                DGV_SaleReceipt_ReciptDetails.DataSource = dataTable_SaleReceiptDetails;
                DGV_SaleReceipt_ReciptDetails.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DGV_SaleReceipt_ImportReceipt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DGV_SaleReceipt_ImportReceipt.Rows[index];
                Class_SaleReceipt saleReceipt = new Class_SaleReceipt(selectedRow.Cells[1].Value.ToString());

                if (e.RowIndex >= 0 && DGV_SaleReceipt_ImportReceipt.Columns[e.ColumnIndex].Name == "ActionColumn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (DB_SaleReceipt.DeleteSaleByID(saleReceipt))
                        {
                            int rowIndex = DGV_SaleReceipt_ImportReceipt.CurrentCell.RowIndex;
                            DGV_SaleReceipt_ImportReceipt.Rows.RemoveAt(rowIndex);

                            MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DGV_SaleReceipt_ImportReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            GridViewFormLoad_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);
        }
    }
}
