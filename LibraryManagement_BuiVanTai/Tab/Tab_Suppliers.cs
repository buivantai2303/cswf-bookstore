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

            // Get total suppliers and active suppliets.
            DB_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_name);
            Label_Suppliers_TotalNumbers.Text = DGView_Suppliers.Rows.Count.ToString();
            Label_Suppliers_WorkingNumber.Text = DB_Suppliers.getActiveRowCount().ToString();
            DGView_Suppliers.RowHeadersVisible = false;

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
                TextBox_Suppliers_Search.Clear();
                DB_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_name);
                dataTable_Suppliers = DB_Suppliers.getActiveTable();
                DGView_Suppliers.DataSource = dataTable_Suppliers;

            } 
            else if (ComboBox_Suppliers_Status.Text == "Inactive") 
            {
                TextBox_Suppliers_Search.Clear();
                DB_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_name);
                dataTable_Suppliers = DB_Suppliers.getInActiveTable();
                DGView_Suppliers.DataSource = dataTable_Suppliers;
            } 
            else
            {
                GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            }
        }


        // Combo Box statement select =====================================================================
        private void Btn_Suppliers_Refresh_Click(object sender, EventArgs e) {
            TextBox_Suppliers_Search.Clear();
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            getEmptyTextBox();
        }


        // Load database to dataGridView_Suppliers function ===============================================
        public void GridViewFormLoad(string ServerName, string DatabaseName) {
            DB_Suppliers = new Database_Suppliers(ServerName, DatabaseName);
            dataTable_Suppliers = DB_Suppliers.getTable();
            DGView_Suppliers.DataSource = dataTable_Suppliers;
            Label_Suppliers_TotalNumbers.Text = DGView_Suppliers.Rows.Count.ToString();
        }


        // Use delete buton to dataGridView_Suppliers function ============================================
        private void dataGridView_Suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Class_Suppliers suppliers = new Class_Suppliers(TextBox_Suppliers_ID.Text);

            // Select only delete icon and question to delete access
            if (e.RowIndex >= 0 && DGView_Suppliers.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGView_Suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DB_Suppliers.DeletDataByID(columnIDValue);

                    int rowIndex = DGView_Suppliers.CurrentCell.RowIndex;
                    DGView_Suppliers.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        // Searching data (update) ========================================================================
        private void TextBox_Suppliers_Search_TextChanged(object sender, EventArgs e)
        {

            if (ComboBox_Suppliers_Status.Text != ClassDefineName.table_Suppliers_SupplierState_Active && ComboBox_Suppliers_Status.Text != ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                dataTable_Suppliers = DB_Suppliers.SearchDataNonState(TextBox_Suppliers_Search.Text, ClassDefineName.table_Suppliers_SupplierState_OffState);
                DGView_Suppliers.DataSource = dataTable_Suppliers;
            }
            else if (ComboBox_Suppliers_Status.Text == ClassDefineName.table_Suppliers_SupplierState_Active)
            {
                dataTable_Suppliers = DB_Suppliers.SearchDataWithState(TextBox_Suppliers_Search.Text, ClassDefineName.table_Suppliers_SupplierState_Active);
                DGView_Suppliers.DataSource = dataTable_Suppliers;
            } 
            else if (ComboBox_Suppliers_Status.Text == ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                dataTable_Suppliers = DB_Suppliers.SearchDataWithState(TextBox_Suppliers_Search.Text, ClassDefineName.table_Suppliers_SupplierState_Inactive);
                DGView_Suppliers.DataSource = dataTable_Suppliers;
            }
            else
            {
                MessageBox.Show("Invalid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Add button click ===============================================================================
        private void Button_SuppliersSave_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            int rowIndex = DGView_Suppliers.CurrentCell.RowIndex;

            // Check if a row is selected
            if (rowIndex >= 0)
            {
                DataGridViewRow SelectedRow = DGView_Suppliers.Rows[rowIndex];
                Class_Suppliers suppliers = new Class_Suppliers(TextBox_Suppliers_ID.Text, TextBox_Suppliers_Name.Text, Textbox_Suppliers_Address.Text, Textbox_Suppliers_Telephone.Text, ComboBox_Suppliers_Suppliers_StatusFix.Text);

                // Get the values from the selected row
                string OldID = SelectedRow.Cells["SupplierID"].Value.ToString();
                string NewID = TextBox_Suppliers_ID.Text;

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
                            }
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                       
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a row before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Add button click================================================================================
        private void Button_SuppliersAdd_Click(object sender, EventArgs e)
        {
            Class_Suppliers suppliers = new Class_Suppliers(TextBox_Suppliers_ID.Text, TextBox_Suppliers_Name.Text, Textbox_Suppliers_Address.Text, Textbox_Suppliers_Telephone.Text, ComboBox_Suppliers_Suppliers_StatusFix.Text);

            // Check condition
            if (DataConditional())
            {
                // Get over condition and excute adding process.
                DialogResult result = MessageBox.Show("Do you want to add this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DB_Suppliers.InsertData(suppliers))
                    {
                        // Notifocation added successfull
                        MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Add new data to dataGridSuppliers
                        DataRow dataGridSuppliers = dataTable_Suppliers.NewRow();
                        dataGridSuppliers[0] = TextBox_Suppliers_ID.Text;
                        dataGridSuppliers[1] = TextBox_Suppliers_Name.Text;
                        dataGridSuppliers[2] = Textbox_Suppliers_Address.Text;
                        dataGridSuppliers[3] = Textbox_Suppliers_Telephone.Text;
                        dataGridSuppliers[4] = ComboBox_Suppliers_Suppliers_StatusFix.Text;
                        dataTable_Suppliers.Rows.Add(dataGridSuppliers);

                        getEmptyTextBox();
                        GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        // Conditionnal for adding data to datbase
        private bool DataConditional()
        {
            
            if (TextBox_Suppliers_ID.Text.Length < 3 || TextBox_Suppliers_ID.Text.Length > 10)
            {
                MessageBox.Show("The 'Supplier Code' must be at least 3 to a maximum of 10 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TextBox_Suppliers_Name.Text.Length < 1 || TextBox_Suppliers_Name.Text.Length > 200)
            {
                MessageBox.Show("The 'Supplier Name' cannot be empty and must be maximum 200 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Textbox_Suppliers_Address.Text.Length < 1 || Textbox_Suppliers_Address.Text.Length > 200)
            {
                MessageBox.Show("The 'Supplier Address' cannot be empty and must be maximum 200 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Textbox_Suppliers_Telephone.Text.Length < 1 || Textbox_Suppliers_Telephone.Text.Length > 12)
            {
                MessageBox.Show("The 'Phone Telephone' cannot be empty, minimum 10 and maximum 11 numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ComboBox_Suppliers_Suppliers_StatusFix.Text != ClassDefineName.table_Suppliers_SupplierState_Active && ComboBox_Suppliers_Suppliers_StatusFix.Text != ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                MessageBox.Show("Invalid 'Suppliers status'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        // fill textbox by clikc on the datarows
        private void dataGridView_Suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow SelectedRow = DGView_Suppliers.Rows[index];
            TextBox_Suppliers_ID.Text = SelectedRow.Cells[1].Value.ToString();
            TextBox_Suppliers_Name.Text = SelectedRow.Cells[2].Value.ToString();
            Textbox_Suppliers_Address.Text = SelectedRow.Cells[3].Value.ToString();
            Textbox_Suppliers_Telephone.Text = SelectedRow.Cells[4].Value.ToString();
            ComboBox_Suppliers_Suppliers_StatusFix.Text = SelectedRow.Cells[5].Value.ToString();
        }



        // Set to all textbox is empty ========================================================================
        private void getEmptyTextBox()
        {
            TextBox_Suppliers_ID.Text = string.Empty;
            TextBox_Suppliers_Name.Text = string.Empty;
            Textbox_Suppliers_Address.Text = string.Empty;
            Textbox_Suppliers_Telephone.Text = string.Empty;
            TextBox_Suppliers_Search.Text = string.Empty;
            ComboBox_Suppliers_Status.Text = ClassDefineName.table_Suppliers_SupplierState_AllState;
            ComboBox_Suppliers_Suppliers_StatusFix.Text = ClassDefineName.table_Suppliers_SupplierState_Active;
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
                        workSheet.Cells[1, 1] = $"Suppliers: {DGView_Suppliers.Rows.Count.ToString()} are working";
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

    }

}
