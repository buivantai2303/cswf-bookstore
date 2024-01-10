using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using LibraryManagement_BuiVanTai.ImportReceiptDetails;
using LibraryManagement_BuiVanTai.Form_NewImportReceipt;

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

        Database_ImportReceiptDetails DB_ImportReceiptDetails = null;
        System.Data.DataTable dataTable_ImportReceiptDetails = null;


        public Tab_ImportReceipt()
        {
            InitializeComponent();
        }

        private void Tab_ImportReceipt_Load(object sender, EventArgs e)
        {
            // Load data to GridView.
            GridViewFormLoad_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);
            DB_ImportReceipt = new Database_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);
        }



        // Load GridView from database =======================================================================================
        public void GridViewFormLoad_ImportReceipt(string ServerName, string DatabaseName)
        {
            DB_ImportReceipt = new Database_ImportReceipt(ServerName, DatabaseName);
            dataTable_ImportReceipt = DB_ImportReceipt.getTable();

            // Add PublisherName fill to CBB_PubName:
            CBB_PubID.DisplayMember = ClassDefineName.table_Publishers_PublisherID;
            DataTable DT_publisherID = DB_ImportReceipt.GetPublisherID();

            // Add PublisherName fill to CBB_PubName:
            CBB_StaffID.DisplayMember = ClassDefineName.table_Staffs_StaffID;
            DataTable DT_staffID = DB_ImportReceipt.GetStaffID();


            if (DT_publisherID != null && DT_staffID != null)
            {
                CBB_PubID.DataSource = DT_publisherID;
                CBB_StaffID.DataSource = DT_staffID;
            }
            else
            {
                MessageBox.Show("Failed to retrieve publisher names from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Assuming that GetStaffName and GetPublisherName return DataTables with a column named "StaffName" and "PublisherName" respectively.

            DataTable staffNameTable = DB_ImportReceipt.GetStaffName(CBB_StaffID.Text);
            DataTable pubNameTable = DB_ImportReceipt.GetPublisherName(CBB_PubID.Text);

            foreach (DataRow row in staffNameTable.Rows)
            {
                // Assuming "StaffName" is the column name in the DataTable
                TB_StaffName.Text = row["StaffName"].ToString();
            }

            foreach (DataRow row in pubNameTable.Rows)
            {
                // Assuming "PublisherName" is the column name in the DataTable
                TB_PubName.Text = row["PublisherName"].ToString();
            }


            // 
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



        public void GridViewFormLoad_ImportReceiptDetails(string ServerName, string DatabaseName, string SelectedID)
        {
            DB_ImportReceiptDetails = new Database_ImportReceiptDetails(ServerName, DatabaseName);
            dataTable_ImportReceiptDetails = DB_ImportReceiptDetails.getTable(SelectedID);

            if (dataTable_ImportReceiptDetails != null)
            {
                DGV_ImportReceipt_ReceiptDetails.DataSource = dataTable_ImportReceiptDetails;
                DGV_ImportReceipt_ReceiptDetails.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        // Select and Delete data by click in the items =================================================================================
        private void DGView_ImportReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_ImportReceipt_Add.Enabled = false;
            TB_ImportReceipt_ImportID.Enabled = false;
            
            // Export data to ComboBox & TextBox
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DGV_ImportReceipt.Rows[index];

                // Retrieve values from DataGridView
                TB_ImportReceipt_ImportID.Text = selectedRow.Cells[1].Value.ToString();
                TB_ImportReceipt_ImportID.Enabled = false;

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

                // Retrieve PublisherID based on PublisherName
                string selectedPublisherName = selectedRow.Cells[3].Value.ToString();
                DataTable publisherIDTable = DB_ImportReceipt.GetPublisherID(selectedPublisherName);

                foreach (DataRow DR in publisherIDTable.Rows)
                {
                    CBB_PubID.Text = DR["PublisherID"].ToString();
                }


                string selectedStaffName = selectedRow.Cells[4].Value.ToString();
                DataTable sstaffIDTable = DB_ImportReceipt.GetStaffID(selectedStaffName);

                foreach (DataRow DR in sstaffIDTable.Rows)
                {
                    CBB_StaffID.Text = DR["StaffID"].ToString();
                }


                GridViewFormLoad_ImportReceiptDetails(ClassDefineName.servername, ClassDefineName.database_name, selectedRow.Cells[1].Value.ToString());
                return;
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
            GridViewFormLoad_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);
            getEmptyTextBox();
            TB_ImportReceipt_ImportID.Enabled = Enabled;
            Date_ImportDate.Enabled = Enabled;
        }



        // Add button fuction ================================================================================================
        private void BTN_ImportReceipt_Add_Click(object sender, EventArgs e)
        {

            string receiptID = "IMPRT" + getID();
            Class_ImportReceipt importReceipt = new Class_ImportReceipt(TB_ImportReceipt_ImportID.Text, Date_ImportDate.Value);
            if (DataConditional())
            {
                DialogResult result = MessageBox.Show("Do you want to add new Import Receipt?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DB_ImportReceipt.InsertData(importReceipt, TB_PubName.Text, TB_StaffName.Text))
                    {
                        // Add new data to dataGridSuppliers
                        DataRow dataGridImport = dataTable_ImportReceipt.NewRow();
                        dataGridImport[0] = TB_ImportReceipt_ImportID.Text;
                        dataGridImport[1] = Date_ImportDate.Text;
                        dataGridImport[2] = CBB_PubID.Text;
                        dataGridImport[3] = CBB_StaffID.Text;
                        dataTable_ImportReceipt.Rows.Add(dataGridImport);


                        GridViewFormLoad_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_name);


                        NewImportReceipt form_NewImportReceipt = new NewImportReceipt(receiptID, Date_ImportDate.Text, CBB_PubID.Text, TB_PubName.Text, CBB_StaffID.Text, TB_StaffName.Text);
                        form_NewImportReceipt.ShowDialog();

                        getEmptyTextBox();

                    }
                }
            }
        }

        private void TB_ImportReceipt_ImportID_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        private void Date_ImportDate_ValueChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        private void CBB_PubName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();
            DataTable pubNameTable = DB_ImportReceipt.GetPublisherName(CBB_PubID.Text);

            foreach (DataRow row in pubNameTable.Rows)
            {
                TB_PubName.Text = row["PublisherName"].ToString();
            }
        }

        private void CBB_StaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();
            DataTable staffNameTable = DB_ImportReceipt.GetStaffName(CBB_StaffID.Text);

            foreach (DataRow row in staffNameTable.Rows)
            {
                TB_StaffName.Text = row["StaffName"].ToString();
            }
        }

        private void AddButtonState()
        {
            if (TB_ImportReceipt_ImportID.Text == "" || CBB_PubID.Text == "" || CBB_StaffID.Text == "" || !IsValidDate(Date_ImportDate.Text))
            {
                BTN_ImportReceipt_Add.Enabled = true;
            }
            else
            {
                BTN_ImportReceipt_Add.Enabled = true;
            }
        }


        //
        private void getEmptyTextBox()
        {
            TB_ImportReceipt_ImportID.Text = null;
            Date_ImportDate.Text = DateTime.Now.ToString();
            CBB_PubID.Text = null;
            CBB_StaffID.Text = null;
        }

        // Data condition checking:
        private const int MinImportIdLength = 3;
        private const int MaxImportIdLength = 10;

        private bool DataConditional()
        {
            if (!IsValidImportIdLength())
                return false;

            if (!IsValidSelectedItem(CBB_PubID, "existing supplier"))
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

        private void DGV_ImportReceipt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Class_ImportReceipt importReceipt = new Class_ImportReceipt(TB_ImportReceipt_ImportID.Text);
            if (e.RowIndex >= 0 && DGV_ImportReceipt.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DB_ImportReceipt.DeletDataByID(importReceipt) == true)
                    {
                        int rowIndex = DGV_ImportReceipt.CurrentCell.RowIndex;
                        DGV_ImportReceipt.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            BTN_ImportReceipt_Add.Enabled = false;
        }

        public string getID()
        {
            int rid;
            dataTable_ImportReceipt = DB_ImportReceipt.getCustomTable("SELECT ImportID FROM ImportReceipt");
            if (dataTable_ImportReceipt.Rows.Count == 0)
            {
                rid = 1;
                return rid.ToString();
            }
            string id = dataTable_ImportReceipt.Rows[dataTable_ImportReceipt.Rows.Count - 1][0].ToString();
            rid = Int32.Parse(id.Substring(5)) + 1;

            return rid.ToString();
        }
    }
}
