using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai
{
    public partial class Tab_Suppliers : UserControl
    {

        Database_Suppliers DB_Suppliers = null;
        System.Data.DataTable dataTable_Suppliers = null;

        public Tab_Suppliers()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Label_TimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Dynamic change server and database =============================================================
        private int oTotal = 0;
        private Timer timer;


        // Tab loading ====================================================================================
        private void Tab_Suppliers_Load(object sender, EventArgs e) {

            // Load data to GridView.
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            BTN_Suppliers_Add.Enabled = false;

            // Get total suppliers and active suppliets.
            DB_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_name);
            Label_Suppliers_TotalNumbers.Text = DGV_Suppliers.Rows.Count.ToString();
            Label_Suppliers_WorkingNumber.Text = DB_Suppliers.getActiveRowCount().ToString();
            DGV_Suppliers.RowHeadersVisible = false;

            // Set comboBox default is "all'
            ComboBox_Suppliers_Status.Text = ClassDefineName.table_Suppliers_SupplierState_AllState;

            // Get update time.
            LabelDateNow.Text = DateTime.Now.ToShortDateString();
            timer.Start();
            Label_TimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        // Combo Box statement select =====================================================================
        private void ComboBox_Library_Status_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboBox_Suppliers_Status.Text == "Active")
            {
                TB_Suppliers_Search.Clear();
                DB_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_name);
                dataTable_Suppliers = DB_Suppliers.getActiveTable();
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;

            } 
            else if (ComboBox_Suppliers_Status.Text == "Inactive") 
            {
                TB_Suppliers_Search.Clear();
                DB_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_name);
                dataTable_Suppliers = DB_Suppliers.getInActiveTable();
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            } 
            else
            {
                GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                return;
            }
        }


        // Combo Box statement select =====================================================================
        private void Btn_Suppliers_Refresh_Click(object sender, EventArgs e) {
            TB_Suppliers_Search.Clear();
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            getEmptyTextBox();
            TB_Suppliers_ID.Enabled = false;
            return;
        }


        // Load database to dataGridView_Suppliers function ===============================================
        public void GridViewFormLoad(string ServerName, string DatabaseName) {
            DB_Suppliers = new Database_Suppliers(ServerName, DatabaseName);
            dataTable_Suppliers = DB_Suppliers.getTable();

            if (dataTable_Suppliers != null)
            {
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                Label_Suppliers_TotalNumbers.Text = DGV_Suppliers.Rows.Count.ToString();
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                DGV_Suppliers.RowHeadersVisible = false;
                DGV_Suppliers.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }


        // Use delete buton to dataGridView_Suppliers function ============================================
        private void dataGridView_Suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            TB_Suppliers_ID.Enabled = true;
            DataGridViewRow SelectedRow = DGV_Suppliers.Rows[index];
            TB_Suppliers_ID.Text = SelectedRow.Cells[1].Value.ToString();
            TB_Suppliers_Name.Text = SelectedRow.Cells[2].Value.ToString();
            TB_Suppliers_Address.Text = SelectedRow.Cells[3].Value.ToString();
            TB_Suppliers_Telephone.Text = SelectedRow.Cells[4].Value.ToString();
            CBB_Suppliers_Suppliers_StatusFix.Text = SelectedRow.Cells[5].Value.ToString();

            if (e.RowIndex >= 0 && DGV_Suppliers.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_Suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DB_Suppliers.DeletDataByID(columnIDValue);

                    int rowIndex = DGV_Suppliers.CurrentCell.RowIndex;
                    DGV_Suppliers.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                return;
            }
        }


        // Searching data (update) ========================================================================
        private void TextBox_Suppliers_Search_TextChanged(object sender, EventArgs e)
        {

            if (ComboBox_Suppliers_Status.Text != ClassDefineName.table_Suppliers_SupplierState_Active && ComboBox_Suppliers_Status.Text != ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                dataTable_Suppliers = DB_Suppliers.SearchDataNonState(TB_Suppliers_Search.Text, ClassDefineName.table_Suppliers_SupplierState_OffState);
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            }
            else if (ComboBox_Suppliers_Status.Text == ClassDefineName.table_Suppliers_SupplierState_Active)
            {
                dataTable_Suppliers = DB_Suppliers.SearchDataWithState(TB_Suppliers_Search.Text, ClassDefineName.table_Suppliers_SupplierState_Active);
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            } 
            else if (ComboBox_Suppliers_Status.Text == ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                dataTable_Suppliers = DB_Suppliers.SearchDataWithState(TB_Suppliers_Search.Text, ClassDefineName.table_Suppliers_SupplierState_Inactive);
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            }
            else
            {
                MessageBox.Show("Invalid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        // Save button click ===============================================================================
        private void Button_SuppliersSave_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            int rowIndex = DGV_Suppliers.CurrentCell.RowIndex;

            // Check if a row is selected
            if (rowIndex >= 0)
            {
                DataGridViewRow SelectedRow = DGV_Suppliers.Rows[rowIndex];
                Class_Suppliers suppliers = new Class_Suppliers(TB_Suppliers_ID.Text, TB_Suppliers_Name.Text, TB_Suppliers_Address.Text, TB_Suppliers_Telephone.Text, CBB_Suppliers_Suppliers_StatusFix.Text);

                // Get the values from the selected row
                string OldID = SelectedRow.Cells["SupplierID"].Value.ToString();
                string NewID = TB_Suppliers_ID.Text;

                if (DataConditional())
                {
                    DialogResult result = MessageBox.Show("Do you want to save this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (OldID != NewID)
                        {
                            MessageBox.Show("Can't update Supplier ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (DB_Suppliers.UpdateData(suppliers, OldID))
                            {
                                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                                return;
                            }
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a row before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        // Add button click================================================================================
        private void Button_SuppliersAdd_Click(object sender, EventArgs e)
        {
            Class_Suppliers suppliers = new Class_Suppliers(TB_Suppliers_ID.Text, TB_Suppliers_Name.Text, TB_Suppliers_Address.Text, TB_Suppliers_Telephone.Text, CBB_Suppliers_Suppliers_StatusFix.Text);

            // Check condition
            if (DataConditional())
            {
                if (DB_Suppliers.IsDuplicateSupplier(TB_Suppliers_ID.Text) > 0)
                {
                    MessageBox.Show("Duplicate supplier found. Please check the Supplier ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to add this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (DB_Suppliers.InsertData(suppliers))
                        {
                            // Notifocation added successfull
                            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getEmptyTextBox();
                            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                return;
                }
            }
        }


        // Disable Add button when not have any data in the Textbox.
        private void TB_Suppliers_Telephone_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        private void CBB_Suppliers_Suppliers_StatusFix_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        private void TB_Suppliers_Name_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        private void TB_Suppliers_Address_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        private void AddButtonState()
        {
            if (TB_Suppliers_ID.Text == "" || TB_Suppliers_Name.Text == "" || TB_Suppliers_Address.Text == "" || CBB_Suppliers_Suppliers_StatusFix.Text == "")
            {
                BTN_Suppliers_Add.Enabled = false;
            }
            else
            {
                BTN_Suppliers_Add.Enabled = true;
            }
        }



        // Conditionnal for adding data to datbase
        private bool DataConditional()
        {
            
            if (TB_Suppliers_ID.Text.Length < 3 || TB_Suppliers_ID.Text.Length > 10)
            {
                MessageBox.Show("The 'Supplier Code' must be at least 3 to a maximum of 10 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TB_Suppliers_Name.Text.Length < 1 || TB_Suppliers_Name.Text.Length > 200)
            {
                MessageBox.Show("The 'Supplier Name' cannot be empty and must be maximum 200 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TB_Suppliers_Address.Text.Length < 1 || TB_Suppliers_Address.Text.Length > 200)
            {
                MessageBox.Show("The 'Supplier Address' cannot be empty and must be maximum 200 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TB_Suppliers_Telephone.Text.Length < 1 || TB_Suppliers_Telephone.Text.Length > 12)
            {
                MessageBox.Show("The 'Phone Telephone' cannot be empty, minimum 10 and maximum 11 numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CBB_Suppliers_Suppliers_StatusFix.Text != ClassDefineName.table_Suppliers_SupplierState_Active && CBB_Suppliers_Suppliers_StatusFix.Text != ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                MessageBox.Show("Invalid 'Suppliers status'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }





        // Set to all textbox is empty ========================================================================
        private void getEmptyTextBox()
        {
            TB_Suppliers_ID.Text = string.Empty;
            TB_Suppliers_Name.Text = string.Empty;
            TB_Suppliers_Address.Text = string.Empty;
            TB_Suppliers_Telephone.Text = string.Empty;
            TB_Suppliers_Search.Text = string.Empty;
            ComboBox_Suppliers_Status.Text = ClassDefineName.table_Suppliers_SupplierState_AllState;
            CBB_Suppliers_Suppliers_StatusFix.Text = ClassDefineName.table_Suppliers_SupplierState_Active;
        }



        // Create excel file to export data ===================================================================
        private void Button_Suppliers_Report_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            
            DialogResult result = MessageBox.Show("Do you want to create report Excel file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Prompt user to select a path using SaveFileDialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "Suppliers.xlsx"; // Default file name
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName;

                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = true;
                        excel.DisplayAlerts = false;
                        workbook = excel.Workbooks.Add();
                        workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                        // Merge cells (A1:E3) and set orange background
                        workSheet.Range["A1:E3"].Merge();
                        workSheet.Range["A1:E3"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);

                        // Add table name in the merged cell and format it
                        workSheet.Cells[1, 1] = $"Suppliers: {DGV_Suppliers.Rows.Count.ToString()} are working";
                        workSheet.Cells[1, 1].Font.Bold = true;
                        workSheet.Cells[1, 1].Font.Size = 20;

                        // Add headers in the fifth row
                        for (int j = 0; j < dataTable_Suppliers.Columns.Count; j++)
                        {
                            workSheet.Cells[5, j + 1] = dataTable_Suppliers.Columns[j].ColumnName;
                        }

                        // Add data starting from the sixth row
                        for (int i = 0; i < dataTable_Suppliers.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataTable_Suppliers.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 6, j + 1] = dataTable_Suppliers.Rows[i][j].ToString();
                            }
                        }

                        // Add borders to all cells with data
                        workSheet.Range["A5", $"E{5 + dataTable_Suppliers.Rows.Count}"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                        // Set background color and make text bold for cells (A5:E5)
                        workSheet.Range["A5:E5"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(246, 164, 103));
                        workSheet.Range["A5:E5"].Font.Bold = true;

                        // AutoFit columns for better visibility
                        workSheet.Columns.AutoFit();

                        workbook.SaveAs(path);
                        workbook.Close();
                        excel.Quit();

                        // Messsage to display if exported sucessful
                        MessageBox.Show("Export Successful");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook = null;
                    workSheet = null;
                }

            }
        }

        private void TB_Suppliers_ID_TextChanged(object sender, EventArgs e)
        {
            if (TB_Suppliers_ID.Text == "" || TB_Suppliers_Name.Text == "" || TB_Suppliers_Address.Text == "" || CBB_Suppliers_Suppliers_StatusFix.Text == "")
            {
                BTN_Suppliers_Add.Enabled = false;
            }
            else
            {
                BTN_Suppliers_Add.Enabled = true;
            }
        }
    }

}
