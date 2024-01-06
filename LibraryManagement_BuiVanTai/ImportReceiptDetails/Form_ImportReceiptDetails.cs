using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using LibraryManagement_BuiVanTai.Tab;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.ImportReceiptDetails
{
    public partial class Form_ImportReceiptDetails : Form
    {
        private Database_ImportReceiptDetails DB_ImportReceiptDeatails = new Database_ImportReceiptDetails();
        private Database_ImportReceiptDetails DB_ImportReceiptDetails = null;
        private System.Data.DataTable dataTable_ImportReceiptDetails = null;
        private Tab_ImportReceipt Tab_ImportReceipt = new Tab_ImportReceipt();

        public Form_ImportReceiptDetails(string ImportID)
        {
            InitializeComponent();
            TB_ImportID.Text = ImportID;
            TB_ImportID.Enabled = false;
        }

        private void BTN_SeachBook_Pay_Click(object sender, EventArgs e)
        {
            AddCheckConditional();
        }

        private void Form_ImportReceiptDetails_Load(object sender, EventArgs e)
        {
            DB_ImportReceiptDeatails = new Database_ImportReceiptDetails(ClassDefineName.servername, ClassDefineName.database_name);

            // Add PublisherName fill to CBB_PubName:
            CBB_BookID.DisplayMember = ClassDefineName.table_Books_BookID;
            System.Data.DataTable DT_BookID = DB_ImportReceiptDeatails.GetBookID();

            // Add PublisherName fill to CBB_PubName:
            CBB_SupplierID.DisplayMember = ClassDefineName.table_Suppliers_SupplierID;
            System.Data.DataTable DT_SupplierID = DB_ImportReceiptDeatails.GetSuppliersID();

            if (DT_BookID != null && DT_SupplierID != null)
            {
                CBB_BookID.DataSource = DT_BookID;
                CBB_SupplierID.DataSource = DT_SupplierID;
            }
            else
            {
                MessageBox.Show("Failed to retrieve publisher names from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBB_BookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();
            System.Data.DataTable bookNameTable = DB_ImportReceiptDeatails.GetBookName(CBB_BookID.Text);

            foreach (DataRow row in bookNameTable.Rows)
            {
                TB_BookName.Text = row[ClassDefineName.table_Books_BookName].ToString();
            }
        }

        private void CBB_SupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();

            System.Data.DataTable supplierNameTable = DB_ImportReceiptDeatails.GetSuppliersName(CBB_SupplierID.Text);

            foreach (DataRow row in supplierNameTable.Rows)
            {
                TB_SupplierName.Text = row[ClassDefineName.table_Suppliers_SupplierName].ToString();
            }
        }

        private bool AddButtonState()
        {
            if (TB_ImportID == null || CBB_BookID == null || TB_ImportAmount == null || CBB_SupplierID == null || TB_BookName == null || TB_SupplierName == null)
            {
                BTN_Submit.Enabled = false;
                return false;
            }
            else
            {
                TB_ImportID.Enabled = true;
            }
            return true;
        }

        private void AddCheckConditional()
        {
            int importAmount;
            decimal price;

            if (int.TryParse(TB_ImportAmount.Text, out importAmount) && decimal.TryParse(TB_Price.Text, out price))
            {
                Class_ImportReceiptDetails importReceiptDetails = new Class_ImportReceiptDetails(TB_ImportID.Text, CBB_BookID.Text, importAmount, CBB_SupplierID.Text, price);

                if (AddButtonState())
                {
                    TB_ImportID.Enabled = true;
                    if (DB_ImportReceiptDeatails.InsertData(importReceiptDetails))
                    {
                        MessageBox.Show("New import receipt added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for Import Amount and Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
