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



        // Load GridView from database =======================================================================================
        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            DB_ImportReceipt = new Database_ImportReceipt(ServerName, DatabaseName);
            dataTable_ImportReceipt = DB_ImportReceipt.getTable();

            // Add PublisherName fill to CBB_PubName:
            CBB_PubName.DisplayMember = ClassDefineName.table_Publishers_PublisherName;
            DataTable publisherNames = DB_ImportReceipt.GetPublisherNames();

            // Add PublisherName fill to CBB_PubName:
            CBB_StaffID.DisplayMember = ClassDefineName.table_Staffs_StaffName;
            DataTable staffName = DB_ImportReceipt.GetStaffName();

            if (publisherNames != null && staffName != null)
            {
                CBB_PubName.DataSource = publisherNames;
                CBB_StaffID.DataSource = staffName;
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



        // Delete data by click in the items =================================================================================
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



        // Fill data from SQL to Grid ========================================================================================
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
                    MessageBox.Show("Error parsing import date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CBB_PubName.Text = selectedRow.Cells[3].Value.ToString();
                CBB_StaffID.Text = selectedRow.Cells[4].Value.ToString();
            }
        }



        // Search fuction ====================================================================================================
        private void PerformSearch()
        {
            string formattedDate = Date_ImportReceipt_TimeSearch.Value.ToString("yyyy-MM-dd");
            dataTable_ImportReceipt = DB_ImportReceipt.SearchData(TB_ImportReceipt_Search.Text, formattedDate);
            DGV_ImportReceipt.DataSource = dataTable_ImportReceipt;
        }

        private void TB_ImportReceipt_Search_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void Date_ImportReceipt_TimeSearch_ValueChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }



        // Refresh fucntion ==================================================================================================
        private void BTN_ImportReceipt_Refresh_Click(object sender, EventArgs e)
        {
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            TB_ImportReceipt_ImportID.Text = null;
            Date_ImportDate.Text = DateTime.Now.ToString();
            CBB_PubName.Text = null;
            CBB_StaffID.Text = null;
        }



        // Add button fuction ================================================================================================
        private void BTN_ImportReceipt_Add_Click(object sender, EventArgs e)
        {
            if (DataConditional())
            {

            }
        }



        // Data condition checking:
        private const int MinImportIdLength = 3;
        private const int MaxImportIdLength = 10;

        private bool DataConditional()
        {
            if (!IsValidImportIdLength())
                return false;

            if (!IsValidSelectedItem(CBB_PubName, "existing supplier"))
                return false;

            if (!IsValidSelectedItem(CBB_StaffID, "existing staff name"))
                return false;

            if (!IsValidDate(Date_ImportDate.Text))
                return false;

            return true;
        }

        private bool IsValidImportIdLength()
        {
            string importId = TB_ImportReceipt_ImportID.Text;
            if (string.IsNullOrEmpty(importId) || importId.Length < MinImportIdLength || importId.Length > MaxImportIdLength)
            {
                MessageBox.Show($"The 'Import ID' must be between {MinImportIdLength} and {MaxImportIdLength} characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidSelectedItem(ComboBox comboBox, string itemName)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"Please select the correct name of the existing {itemName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private bool IsValidDate(string dateString)
        {
            DateTime date;
            return DateTime.TryParse(dateString, out date);
        }

    }
}
