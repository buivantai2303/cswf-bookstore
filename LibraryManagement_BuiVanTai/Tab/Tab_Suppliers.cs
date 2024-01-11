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
        string databaseName = ClassDefineName.database_name;
        string serverName = ClassDefineName.servername;

        public Tab_Suppliers()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Label_TimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Dynamic change server and database =============================================================
        public int oTotal = 0;
        public Timer timer;


        // Tab loading ====================================================================================
        public void Tab_Suppliers_Load(object sender, EventArgs e) {

            GridViewFormLoad(serverName, databaseName);
            BTN_Suppliers_Add.Enabled = false;

            DB_Suppliers = new Database_Suppliers(serverName, databaseName);
            Label_Suppliers_TotalNumbers.Text = DGV_Suppliers.Rows.Count.ToString();
            Label_Suppliers_WorkingNumber.Text = DB_Suppliers.getActiveRowCount().ToString();
            DGV_Suppliers.RowHeadersVisible = false;

            ComboBox_Suppliers_Status.Text = ClassDefineName.table_Suppliers_SupplierState_AllState;

            LabelDateNow.Text = DateTime.Now.ToShortDateString();
            timer.Start();
            Label_TimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        // Combo Box statement select =====================================================================
        public void ComboBox_Library_Status_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboBox_Suppliers_Status.Text == "Active")
            {
                TB_Suppliers_Search.Clear();
                dataTable_Suppliers = DB_Suppliers.getTable(TB_Suppliers_Search.Text, "Active");
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;

            } 
            else if (ComboBox_Suppliers_Status.Text == "Inactive") 
            {
                TB_Suppliers_Search.Clear();
                dataTable_Suppliers = DB_Suppliers.getTable(TB_Suppliers_Search.Text, "Active");
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            } 
            else
            {
                GridViewFormLoad(serverName, databaseName);
                return;
            }
        }


        // Combo Box statement select =====================================================================
        public void Btn_Suppliers_Refresh_Click(object sender, EventArgs e) {
            TB_Suppliers_Search.Clear();
            GridViewFormLoad(serverName, databaseName);
            getEmptyTextBox();
            TB_Suppliers_ID.Enabled = true;
            BTN_Suppliers_Add.Enabled = false;
            BTN_Suppliers_Save.Enabled = false;
            return;
        }


        // Load database to dataGridView_Suppliers function ===============================================
        public void GridViewFormLoad(string ServerName, string DatabaseName) {
            DB_Suppliers = new Database_Suppliers(ServerName, DatabaseName);
            dataTable_Suppliers = DB_Suppliers.getTable("", "All");

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
        public void dataGridView_Suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && DGV_Suppliers.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string columnIDValue = DGV_Suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Class_Suppliers suppliers = new Class_Suppliers(columnIDValue, TB_Suppliers_Name.Text, TB_Suppliers_Address.Text, TB_Suppliers_Telephone.Text, CBB_Suppliers_Suppliers_StatusFix.Text);
                    DB_Suppliers.DeletData(suppliers);

                    int rowIndex = DGV_Suppliers.CurrentCell.RowIndex;
                    DGV_Suppliers.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                return;
            }
        }


        // Searching data (update) ========================================================================
        public void TextBox_Suppliers_Search_TextChanged(object sender, EventArgs e)
        {

            if (ComboBox_Suppliers_Status.Text != "Active" && ComboBox_Suppliers_Status.Text != "Inactive")
            {
                dataTable_Suppliers = DB_Suppliers.getTable(TB_Suppliers_Search.Text, "All");
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            }
            else if (ComboBox_Suppliers_Status.Text == "Active")
            {
                dataTable_Suppliers = DB_Suppliers.getTable(TB_Suppliers_Search.Text, "Active");
                DGV_Suppliers.DataSource = dataTable_Suppliers;
                return;
            } 
            else if (ComboBox_Suppliers_Status.Text == "Inactive")
            {
                dataTable_Suppliers = DB_Suppliers.getTable(TB_Suppliers_Search.Text, "Inactive");
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
        public void Button_SuppliersSave_Click(object sender, EventArgs e)
        {
            int rowIndex = DGV_Suppliers.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow SelectedRow = DGV_Suppliers.Rows[rowIndex];
                Class_Suppliers suppliers = new Class_Suppliers(TB_Suppliers_ID.Text, TB_Suppliers_Name.Text, TB_Suppliers_Address.Text, TB_Suppliers_Telephone.Text, CBB_Suppliers_Suppliers_StatusFix.Text);

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
                            if (DB_Suppliers.UpdateData(suppliers))
                            {
                                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GridViewFormLoad(serverName, databaseName);
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
            BTN_Suppliers_Save.Enabled = false;
        }


        public void Button_SuppliersAdd_Click(object sender, EventArgs e)
        {
            Class_Suppliers suppliers = new Class_Suppliers(TB_Suppliers_ID.Text, TB_Suppliers_Name.Text, TB_Suppliers_Address.Text, TB_Suppliers_Telephone.Text, CBB_Suppliers_Suppliers_StatusFix.Text);

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
                            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getEmptyTextBox();
                            GridViewFormLoad(serverName, databaseName);
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


        public void TB_Suppliers_Telephone_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        public void CBB_Suppliers_Suppliers_StatusFix_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        public void TB_Suppliers_Name_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        public void TB_Suppliers_Address_TextChanged(object sender, EventArgs e)
        {
            AddButtonState();
        }

        
        public void AddButtonState()
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



        public bool DataConditional()
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

            if (CBB_Suppliers_Suppliers_StatusFix.Text != "Active" && CBB_Suppliers_Suppliers_StatusFix.Text != "Inactive")
            {
                MessageBox.Show("Invalid 'Suppliers status'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void getEmptyTextBox()
        {
            TB_Suppliers_ID.Text = string.Empty;
            TB_Suppliers_Name.Text = string.Empty;
            TB_Suppliers_Address.Text = string.Empty;
            TB_Suppliers_Telephone.Text = string.Empty;
            TB_Suppliers_Search.Text = string.Empty;
            ComboBox_Suppliers_Status.Text = ClassDefineName.table_Suppliers_SupplierState_AllState;
            CBB_Suppliers_Suppliers_StatusFix.Text = "Active";
        }


        public void Button_Suppliers_Report_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            
            DialogResult result = MessageBox.Show("Do you want to create report Excel file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "Suppliers.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName;

                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = true;
                        excel.DisplayAlerts = false;
                        workbook = excel.Workbooks.Add();
                        workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                        workSheet.Range["A1:E3"].Merge();
                        workSheet.Range["A1:E3"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
                        workSheet.Cells[1, 1] = $"Suppliers: {DGV_Suppliers.Rows.Count.ToString()} are working";
                        workSheet.Cells[1, 1].Font.Bold = true;
                        workSheet.Cells[1, 1].Font.Size = 20;
                        for (int j = 0; j < dataTable_Suppliers.Columns.Count; j++)
                        {
                            workSheet.Cells[5, j + 1] = dataTable_Suppliers.Columns[j].ColumnName;
                        }

                        for (int i = 0; i < dataTable_Suppliers.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataTable_Suppliers.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 6, j + 1] = dataTable_Suppliers.Rows[i][j].ToString();
                            }
                        }

                        workSheet.Range["A5", $"E{5 + dataTable_Suppliers.Rows.Count}"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        workSheet.Range["A5:E5"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(246, 164, 103));
                        workSheet.Range["A5:E5"].Font.Bold = true;
                        workSheet.Columns.AutoFit();
                        workbook.SaveAs(path);
                        workbook.Close();
                        excel.Quit();
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

        public void TB_Suppliers_ID_TextChanged(object sender, EventArgs e)
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

        public void DGV_Suppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Suppliers_ID.Enabled = false;
            BTN_Suppliers_Save.Enabled = true;
            int index = e.RowIndex;
            DataGridViewRow SelectedRow = DGV_Suppliers.Rows[index];
            TB_Suppliers_ID.Text = SelectedRow.Cells[1].Value.ToString();
            TB_Suppliers_Name.Text = SelectedRow.Cells[2].Value.ToString();
            TB_Suppliers_Address.Text = SelectedRow.Cells[3].Value.ToString();
            TB_Suppliers_Telephone.Text = SelectedRow.Cells[4].Value.ToString();
            CBB_Suppliers_Suppliers_StatusFix.Text = SelectedRow.Cells[5].Value.ToString();
            BTN_Suppliers_Add.Enabled = false;
        }
    }

}
