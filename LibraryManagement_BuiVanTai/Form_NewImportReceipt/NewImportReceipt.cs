using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using LibraryManagement_BuiVanTai.Tab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.AxHost;

namespace LibraryManagement_BuiVanTai.Form_NewImportReceipt
{
    public partial class NewImportReceipt : Form
    {

        private Database_ImportReceiptDetails DB_ImportReceiptDetails = null;
        private DataTable dataTable_ImportReceiptDetails = null;
        private string serverName = ClassDefineName.servername;
        private string databaseName = ClassDefineName.database_name;



        public NewImportReceipt(string ImportID, string ImportDate, string PublisherID, string PublisherName, string StaffID, string StaffName)
        {
            InitializeComponent();

            TB_ImportID.Text = ImportID;
            Date_ImportDate.Text = ImportDate;
            CBB_PubID.Text = PublisherID;
            TB_PubName.Text = PublisherName;
            CBB_StaffID.Text = StaffID;
            TB_StaffName.Text = StaffName;
        }

        private void NewImportReceipt_Load(object sender, EventArgs e)
        {
            GridViewFormLoad();

        }


        public void GridViewFormLoad()
        {
            AddState();
            BoxState(false);

            DB_ImportReceiptDetails = new Database_ImportReceiptDetails(serverName, databaseName);

            CBB_BookID.DisplayMember = "BookID";
            DataTable DT_BookID = DB_ImportReceiptDetails.GetBookID();

            CBB_SupplierID.DisplayMember = "SupplierID";
            DataTable DT_SupplierID = DB_ImportReceiptDetails.GetSuppliersID();

            CBB_AuthorName.DisplayMember = "AuthorName";
            DataTable DT_AuthorName = DB_ImportReceiptDetails.GetAuthorName();

            if (DT_BookID != null && DT_SupplierID != null && DT_AuthorName != null)
            {
                CBB_BookID.DataSource = DT_BookID;
                CBB_SupplierID.DataSource = DT_SupplierID;
                CBB_AuthorName.DataSource = DT_AuthorName;
            }
            else
            {
                MessageBox.Show("Failed to retrieve publisher names from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataTable_ImportReceiptDetails = new DataTable();
            dataTable_ImportReceiptDetails.Columns.Add("BookID");
            dataTable_ImportReceiptDetails.Columns.Add("BookName");
            dataTable_ImportReceiptDetails.Columns.Add("BookType");
            dataTable_ImportReceiptDetails.Columns.Add("AuthorName");
            dataTable_ImportReceiptDetails.Columns.Add("Remaining");
            dataTable_ImportReceiptDetails.Columns.Add("SupplierID");
            dataTable_ImportReceiptDetails.Columns.Add("Price");
        }


        private void CBB_BookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();

            DB_ImportReceiptDetails = new Database_ImportReceiptDetails(serverName, databaseName);

            DataTable DT_BookName = DB_ImportReceiptDetails.GetBookName(CBB_BookID.Text);
            DataTable DT_BookRemaining = DB_ImportReceiptDetails.GetBookRemaining(CBB_BookID.Text);
            DataTable DT_BooKType = DB_ImportReceiptDetails.GetBookType(CBB_BookID.Text);
            DataTable DT_BookSupplierName = DB_ImportReceiptDetails.GetBookSupplierName(CBB_SupplierID.Text);
            DataTable DT_BookPrice = DB_ImportReceiptDetails.GetBookPrice(CBB_BookID.Text);

            if (DT_BookName.Rows.Count > 0)
            {
                DataRow row_BookName = DT_BookName.Rows[0];
                TB_BookName.Text = row_BookName["BookName"].ToString();
            }

            if (DT_BookRemaining.Rows.Count > 0)
            {
                DataRow row_Remaining = DT_BookRemaining.Rows[0];
                TB_Remaining.Text = row_Remaining["Remaining"].ToString();
            }

            if (DT_BooKType.Rows.Count > 0)
            {
                DataRow row_BookType = DT_BooKType.Rows[0];
                TB_BookType.Text = row_BookType["BookType"].ToString();
            }

            CBB_SupplierID.DisplayMember = "SupplierID";
            DataTable DT_SupplierID = DB_ImportReceiptDetails.GetSuppliersID();

            if (DT_SupplierID != null)
            {
                CBB_SupplierID.DataSource = DT_SupplierID;
            }

            if (DT_BookSupplierName.Rows.Count > 0)
            {
                DataRow row_BookSupplierName = DT_BookSupplierName.Rows[0];
                TB_SupplierName.Text = row_BookSupplierName["SupplierName"].ToString();
            }

            CBB_AuthorName.DisplayMember = "AuthorName";
            DataTable DT_BookAuthorName = DB_ImportReceiptDetails.GetAuthorName(CBB_BookID.Text);

            if (DT_BookAuthorName != null)
            {
                CBB_AuthorName.DataSource = DT_BookAuthorName;
            }

            if (DT_BookPrice.Rows.Count > 0)
            {
                DataRow row_BookPrice = DT_BookPrice.Rows[0];
                TB_Price.Text = row_BookPrice["Price"].ToString();
            }
        }



        private void CBB_SupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();

            DataTable DT_BookPrice = DB_ImportReceiptDetails.GetBookPrice(CBB_BookID.Text);
            if (DT_BookPrice.Rows.Count > 0)
            {
                DataRow row_BookPrice = DT_BookPrice.Rows[0];
                TB_Price.Text = row_BookPrice["Price"].ToString();
            }

            DataTable DT_BookSupplierName = DB_ImportReceiptDetails.GetBookSupplierName(CBB_SupplierID.Text);
            if (DT_BookSupplierName.Rows.Count > 0)
            {
                DataRow row_BookSupplierName = DT_BookSupplierName.Rows[0];
                TB_SupplierName.Text = row_BookSupplierName["SupplierName"].ToString();
            }
        }



        private void BTN_AddToTable_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(TB_ImportAmount.Text))
                {
                    MessageBox.Show("Please enter Import Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int importAmount;

                if (!int.TryParse(TB_ImportAmount.Text, out importAmount))
                {
                    MessageBox.Show("Invalid Import Amount. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int currentRemaining = 0;
                if (!string.IsNullOrEmpty(TB_Remaining.Text))
                {
                    currentRemaining = int.Parse(TB_Remaining.Text);
                }

                int newRemaining = currentRemaining + importAmount;
                DataRow dataRow = dataTable_ImportReceiptDetails.NewRow();
                dataRow["BookID"] = CBB_BookID.Text;
                dataRow["BookName"] = TB_BookName.Text;
                dataRow["BookType"] = TB_BookType.Text;
                dataRow["AuthorName"] = CBB_AuthorName.Text;
                dataRow["Remaining"] = newRemaining.ToString();
                dataRow["SupplierID"] = CBB_SupplierID.Text;
                dataRow["Price"] = TB_Price.Text;

                dataTable_ImportReceiptDetails.Rows.Add(dataRow);

                DGV_NewImportReceipt.DataSource = dataTable_ImportReceiptDetails;

                Refresh();
        }

        public void AddState()
        {
            if (CBB_BookID.Text == "" || TB_BookName.Text == "" || TB_BookType.Text == "" || CBB_AuthorName.Text == "" || TB_Remaining.Text == "" || CBB_AuthorName.Text == "" || TB_ImportAmount.Text == "" || TB_Price.Text == "")
            {
                BTN_AddToTable.Enabled = false;
            }
            else
            {
                BTN_AddToTable.Enabled = true;
            }
        }


        private void DGV_NewImportReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGV_NewImportReceipt.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = DGV_NewImportReceipt.CurrentCell.RowIndex;
                    DGV_NewImportReceipt.Rows.RemoveAt(rowIndex);
                }
            }
        }


        private void BTN_Refresh_Click(object sender, EventArgs e)
        {

            GridViewFormLoad();
            BoxState(true);
            ResetAll();

        }

        private void ResetAll()
        {

            CBB_BookID.Text = "Enter new BookID";
            TB_BookName.Text = null;
            TB_Remaining.Text = "0";
            TB_BookType.Text = null;
            CBB_SupplierID.DataSource = null;
            TB_SupplierName.Text = null;
            CBB_AuthorName.DataSource = null;
            TB_Price.Text = null;
            TB_ImportAmount.Text = null;


            CBB_SupplierID.DisplayMember = "SupplierID";
            DataTable DT_ResetSupplierID = DB_ImportReceiptDetails.GetSuppliersID();

            CBB_AuthorName.DisplayMember = "AuthorName";
            CBB_SupplierID.DataSource = DT_ResetSupplierID;
            TB_SupplierName.Text = "";
            if (CBB_SupplierID.SelectedIndex >= 0)
            {
                DataTable DT_BookSupplierName = DB_ImportReceiptDetails.GetBookSupplierName(CBB_SupplierID.Text);
                if (DT_BookSupplierName.Rows.Count > 0)
                {
                    DataRow row_BookSupplierName = DT_BookSupplierName.Rows[0];
                    TB_SupplierName.Text = row_BookSupplierName["SupplierName"].ToString();
                }
            }

            CBB_BookID.Focus();
        }


        public void BoxState (bool state)
        {
            if (state == true)
            {
                TB_BookName.Enabled = true;
                TB_Remaining.Enabled = false;
                TB_BookType.Enabled = true;
                CBB_SupplierID.Enabled = true;
                TB_SupplierName.Enabled = true;
                CBB_AuthorName.Enabled = true;
                TB_Price.Enabled = true;
            } 
            else if (state == false)
            {
                TB_BookName.Enabled = false;
                TB_Remaining.Enabled = false;
                TB_BookType.Enabled = false;
                CBB_SupplierID.Enabled = true;
                TB_SupplierName.Enabled = false;
                CBB_AuthorName.Enabled = true;
                TB_Price.Enabled = false;
            }
        }

        private bool AddButtonState()
        {
            if (DGV_NewImportReceipt.DataSource == null || DGV_NewImportReceipt.Rows.Count == 0)
            {
                BTN_Pay.Enabled = false;
                return false;
            }
            else
            {
                BTN_Pay.Enabled = true;
            }
            return true;
        }


        private void AddCheckConditional()
        {


            foreach (DataGridViewRow dgr in DGV_NewImportReceipt.Rows)
            {
                Class_ImportReceiptDetails srd = new Class_ImportReceiptDetails(TB_ImportID.Text, dgr.Cells[1].Value.ToString(), Int32.Parse(dgr.Cells[5].Value.ToString()), dgr.Cells[6].Value.ToString(), Decimal.Parse(dgr.Cells[7].Value.ToString()));
                try
                {
                    DB_ImportReceiptDetails.InsertData(srd);
                }
                catch
                {
                    MessageBox.Show("There is something wrong!! Please Contact IT support");
                }
            }
        }
        

        private void BTN_Pay_Click(object sender, EventArgs e)
        {
            AddCheckConditional();
        }

        private void TB_ImportAmount_TextChanged(object sender, EventArgs e)
        {
            AddState();
        }

        private void TB_Remaining_TextChanged(object sender, EventArgs e)
        {
            AddState();

        }

        private void TB_BookType_TextChanged(object sender, EventArgs e)
        {
            AddState();

        }

        private void TB_BookName_TextChanged(object sender, EventArgs e)
        {
            AddState();

        }

        private void TB_Price_TextChanged(object sender, EventArgs e)
        {
            AddState();

        }

        private void TB_SupplierName_TextChanged(object sender, EventArgs e)
        {
            AddState();

        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = TB_Search.Text.ToLower();
            foreach (DataGridViewRow row in DGV_NewImportReceipt.Rows)
            {
                if (row.Visible)
                {
                    bool rowContainsSearchText = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                        {
                            rowContainsSearchText = true;
                            break;
                        }
                    }
                    row.Visible = rowContainsSearchText;
                }
            }
        }


        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DB_ImportReceiptDetails.DeleteData(TB_ImportID.Text);
                MessageBox.Show("Record cancel successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

