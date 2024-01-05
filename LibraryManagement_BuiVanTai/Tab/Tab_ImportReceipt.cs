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


        // Load GridView from database
        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            DB_ImportReceipt = new Database_ImportReceipt(ServerName, DatabaseName);
            dataTable_ImportReceipt = DB_ImportReceipt.getTable();


            CBB_PubName.DisplayMember = ClassDefineName.table_Publishers_PublisherName; // Set the display member

            DataTable publisherNames = DB_ImportReceipt.GetPublisherNames();

            if (publisherNames != null)
            {
                CBB_PubName.DataSource = publisherNames; // Set the data source
            }
            else
            {
                MessageBox.Show("Failed to retrieve publisher names from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (dataTable_ImportReceipt != null)
            {
                DGV_ImportReceipt.DataSource = dataTable_ImportReceipt;
                DGV_ImportReceipt.RowHeadersVisible = false;
                DGV_ImportReceipt_ReceiptDetails.RowHeadersVisible = false;

                // Set the DateTimePicker format to "yyyy-MM-dd"
                Date_ImportDate.Format = DateTimePickerFormat.Custom;
                Date_ImportDate.CustomFormat = "yyyy-MM-dd";
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DGView_ImportReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Class_Suppliers suppliers = new Class_Suppliers(TB_ImportReceipt_ImportID.Text);

            // Select only delete icon and question to delete access
            if (e.RowIndex >= 0 && DGV_ImportReceipt.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_ImportReceipt.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DB_ImportReceipt.DeletDataByID(columnIDValue);

                    int rowIndex = DGV_ImportReceipt.CurrentCell.RowIndex;
                    DGV_ImportReceipt.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                return;
            }
        }


        private void DGView_ImportReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not in the header
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DGV_ImportReceipt.Rows[index];

                // Retrieve values from DataGridView
                TB_ImportReceipt_ImportID.Text = selectedRow.Cells[1].Value.ToString();

                // Convert the string representation of the date to a DateTime object
                if (DateTime.TryParse(selectedRow.Cells[2].Value.ToString(), out DateTime importDate))
                {
                    Date_ImportDate.Value = importDate;
                }
                else
                {
                    // Handle parsing error if necessary
                    // MessageBox.Show("Error parsing import date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CBB_PubName.Text = selectedRow.Cells[3].Value.ToString();
                CBB_StaffID.Text = selectedRow.Cells[4].Value.ToString();
            }
        }





    }
}
