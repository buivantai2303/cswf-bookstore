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
        private Database_ImportReceiptDetails DB_ImportReceiptDetails = new Database_ImportReceiptDetails();
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
            DialogResult result = MessageBox.Show("Are you sure you want to add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AddCheckConditional();
            } 
            else if (result == DialogResult.No)
            {
            }
        }


        private void Form_ImportReceiptDetails_Load(object sender, EventArgs e)
        {
            DB_ImportReceiptDetails = new Database_ImportReceiptDetails(ClassDefineName.servername, ClassDefineName.database_name);

            // Add PublisherName fill to CBB_PubName:
            CBB_BookID.DisplayMember = ClassDefineName.table_Books_BookID;
            System.Data.DataTable DT_BookID = DB_ImportReceiptDetails.GetBookID();

            // Add PublisherName fill to CBB_PubName:
            CBB_SupplierID.DisplayMember = ClassDefineName.table_Suppliers_SupplierID;
            System.Data.DataTable DT_SupplierID = DB_ImportReceiptDetails.GetSuppliersID();

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

            System.Data.DataTable bookPriceTable = DB_ImportReceiptDetails.GetBookPrice(CBB_BookID.Text);

            if (decimal.TryParse(TB_ImportAmount.Text, out decimal importAmount))
            {
                foreach (DataRow row in bookPriceTable.Rows)
                {
                    if (decimal.TryParse(row[ClassDefineName.table_Books_Price].ToString(), out decimal bookPrice))
                    {
                        decimal totalPrice = importAmount * bookPrice;
                        TB_Price.Text = totalPrice.ToString();
                    }
                    else
                    {
                        // Handle the case where book price is not a valid decimal
                        TB_Price.Text = "Invalid Price";
                    }
                }
            }
            else
            {
                // Handle the case where import amount is not a valid decimal
                TB_Price.Text = "Invalid Amount";
            }

            System.Data.DataTable bookNameTable = DB_ImportReceiptDetails.GetBookName(CBB_BookID.Text);
            foreach (DataRow row in bookNameTable.Rows)
            {
                TB_BookName.Text = row[ClassDefineName.table_Books_BookName].ToString();
            }
        }


        private void CBB_SupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButtonState();

            System.Data.DataTable supplierNameTable = DB_ImportReceiptDetails.GetSuppliersName(CBB_SupplierID.Text);

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
                    if (DB_ImportReceiptDetails.InsertData(importReceiptDetails))
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

        private void TB_ImportAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TB_ImportAmount.Text, out decimal importAmount))
            {
                System.Data.DataTable bookNameTable = DB_ImportReceiptDetails.GetBookPrice(CBB_BookID.Text);

                foreach (DataRow row in bookNameTable.Rows)
                {
                    if (decimal.TryParse(row[ClassDefineName.table_Books_Price].ToString(), out decimal bookPrice))
                    {
                        decimal totalPrice = importAmount * bookPrice;
                        TB_Price.Text = totalPrice.ToString();
                    }
                    else
                    {
                        // Handle the case where book price is not a valid decimal
                        TB_Price.Text = "Invalid Price";
                    }
                }

                // Reset the notification label
                Label_ImportAmountNotification.Text = "";
            }
            else
            {
                // Handle the case where import amount is not a valid decimal
                TB_Price.Text = "Note: Invalid Amount";

                // Display a notification in the label
                Label_ImportAmountNotification.Text = "Note: Invalid Import Amount. Please enter a valid number.";
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DB_ImportReceiptDetails.DeleteData(TB_ImportID.Text);
                this.Close();
            }
        }
    }
}
