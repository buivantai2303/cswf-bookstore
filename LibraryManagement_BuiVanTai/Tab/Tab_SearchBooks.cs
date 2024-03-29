﻿using LibraryManagement_BuiVanTai.Class;
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
    public partial class Tab_SearchBooks : UserControl
    {
        DataTable dt;
        Database_SaleReceipts database_SaleReceipts;
        Database_SaleReceiptDetail database_Details;
        Database_Book database_Book;
        int amount = 1;
        public Tab_SearchBooks()
        {
            InitializeComponent();
        }

        private void Tab_SearchBooks_Load(object sender, EventArgs e)
        {
            GridViewFormLoadLeft(ClassDefineName.servername, ClassDefineName.database_name);
            DataTable dtCustomer = database_SaleReceipts.getCustomTable("SELECT CustomerID FROM Customers");
            DataTable dtStaff = database_SaleReceipts.getCustomTable("SELECT StaffID FROM Staffs");

            CBB_StaffID.DisplayMember = "StaffID";
            CBB_StaffID.DataSource = dtStaff;
            CBB_CustomerID.DisplayMember = "CustomerID";
            CBB_CustomerID.DataSource = dtCustomer;
        }

        public void GridViewFormLoadLeft(string SererName, string DatabaseName)
        {
            database_Book = new Database_Book(SererName, DatabaseName);
            database_Details = new Database_SaleReceiptDetail(SererName, DatabaseName);
            database_SaleReceipts = new Database_SaleReceipts(SererName, DatabaseName);
            dt = database_SaleReceipts.getCustomTable("SELECT BookID, BookName, BookType, Remaining, Price FROM Books");
            DataTable dtCustomer = database_SaleReceipts.getCustomTable("SELECT CustomerID FROM Customers");

            if (dt != null)
            {
                DGV_SearchBook_Left.DataSource = dt;
                DGV_SearchBook_Left.RowHeadersVisible = false;

                CBB_CustomerID.DisplayMember = "CustomerID";
                CBB_CustomerID.DataSource = dtCustomer;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_SearchBook_Left_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = DGV_SearchBook_Left.Columns[e.ColumnIndex].Name;

            if (Int32.Parse(DGV_SearchBook_Left.Rows[e.RowIndex].Cells[4].Value.ToString()) != 0)
            {
                foreach (DataGridViewRow dgr in DGV_SearchBook_Right.Rows)
                {
                    if (DGV_SearchBook_Left.Rows[e.RowIndex].Cells[1].Value.ToString() == dgr.Cells[0].Value.ToString())
                    {
                        int temp = Int32.Parse(dgr.Cells[4].Value.ToString());
                        temp++;
                        dgr.Cells[4].Value = temp;
                        return;
                    }
                }
                DGV_SearchBook_Right.Rows.Add(DGV_SearchBook_Left.Rows[e.RowIndex].Cells[1].Value.ToString(), DGV_SearchBook_Left.Rows[e.RowIndex].Cells[2].Value.ToString(), DGV_SearchBook_Left.Rows[e.RowIndex].Cells[3].Value.ToString(), DGV_SearchBook_Left.Rows[e.RowIndex].Cells[5].Value.ToString(), amount);
            }
        }

        private void BTN_SeachBook_Pay_Click(object sender, EventArgs e)
        {
            addtoSaleReceipt();
            LB_SearchBook_Total.Text = "Total:";
            foreach (DataGridViewRow dr  in DGV_SearchBook_Right.Rows)
            {
                database_Book.executeCMD($"UPDATE Books SET Remaining = (Remaining - {Int32.Parse(dr.Cells[4].Value.ToString())} WHERE BookID = {dr.Cells[0].Value.ToString()}");
            }
            GridViewFormLoadLeft(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void addtoSaleReceipt()
        {
            string receiptID = "RECPT" + getID();
            try
            {
                Class_SaleReceipt sr = new Class_SaleReceipt(receiptID, CBB_StaffID.Text, DateTime.Now);
                 
                if (database_SaleReceipts.InsertData(sr) == true)
                {
                    MessageBox.Show("Add Successfuly");
                    GridViewFormLoadLeft(ClassDefineName.servername, ClassDefineName.database_name);
                    
                }
                else
                {
                    MessageBox.Show("There is something wrong!! Please Contact IT support");
                }

                foreach (DataGridViewRow dgr in DGV_SearchBook_Right.Rows)
                {
                    Class_SaleReceiptDetails srd = new Class_SaleReceiptDetails(receiptID, dgr.Cells[0].Value.ToString(), Int32.Parse(dgr.Cells[4].Value.ToString()), CBB_CustomerID.Text, Int32.Parse(dgr.Cells[3].Value.ToString()));
                    try
                    {
                        database_Details.InsertData(srd);
                        
                    } catch
                    {
                        MessageBox.Show("There is something wrong!! Please Contact IT support");
                    }
                }
                CheckOut(receiptID, TB_CustomerName.Text);
                DGV_SearchBook_Right.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("There is something wrong!! Please Contact IT support");
            }
        }

        public string getID()
        {
            int rid;
            dt = database_SaleReceipts.getCustomTable("SELECT ReceiptID FROM SaleReceipts");
            if (dt.Rows.Count == 0)
            {
                rid = 1;
                return rid.ToString();
            }
            string id = dt.Rows[dt.Rows.Count - 1][0].ToString();
            rid = Int32.Parse(id.Substring(5)) + 1;

            return rid.ToString();
        }

        public void CheckOut(string filename, string custName)
        {
            int[] price = new int[DGV_SearchBook_Right.Rows.Count];
            for (int i = 0; i < price.Length; i++)
            {
                price[i] = Int32.Parse(DGV_SearchBook_Right.Rows[i].Cells[3].Value.ToString());
            }
            int[] amount = new int[DGV_SearchBook_Right.Rows.Count];
            for (int i = 0; i < price.Length; i++)
            {
                amount[i] = Int32.Parse(DGV_SearchBook_Right.Rows[i].Cells[4].Value.ToString());
            }

            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = currentPath.LastIndexOf("bin");
            string Path = currentPath.Substring(0, binIndex) + "\\Recipt\\Recipt1.xlsx";


            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;


            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Open(Path);
                workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Hóa Đơn Bán Hàng"];
                 
                for (int i = 0; i < DGV_SearchBook_Right.Rows.Count; i++)
                {
                    for (int j = 0; j < DGV_SearchBook_Right.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 8, j + 2] = DGV_SearchBook_Right.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workSheet.Cells[18, 2] = CountTotal(price, amount).ToString();
                workSheet.Cells[4, 1] = "Tên khách hàng: " + custName;

                workbook.SaveAs(filename);

                workbook.Close();

                excel.Quit();

                MessageBox.Show("Xuat du lieu thanh cong");
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

        public int CountTotal(int[] BookAmount, int[] Price, int i = 0, int sum = 0)
        {
            if (i == BookAmount.Length)
            {
                return sum;
            }
            sum += BookAmount[i] * Price[i];
            i++;
            return CountTotal(BookAmount, Price, i, sum);
        }

        private void CBB_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCustomer = database_SaleReceipts.getCustomTable("SELECT CustomerID, FirstName FROM Customers");

            foreach (DataRow dr in dtCustomer.Rows)
            {
                if (CBB_CustomerID.Text == dr[0].ToString())
                {
                    TB_CustomerName.Text = dr[1].ToString();
                }
            }
        }

        private void BTN_SeachBook_Reset_Click(object sender, EventArgs e)
        {
            DGV_SearchBook_Right.Rows.Clear();
            LB_SearchBook_Total.Text = "Total:    0";
        }

        private void CBB_StaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtStaff = database_SaleReceipts.getCustomTable("SELECT StaffID, StaffName FROM Staffs");

            foreach (DataRow dr in dtStaff.Rows)
            {
                if (CBB_StaffID.Text == dr[0].ToString())
                {
                    TB_StaffName.Text = dr[1].ToString();
                }
            }
        }

        private void TB_CustomerName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DGV_SearchBook_Right_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int[] price = new int[DGV_SearchBook_Right.Rows.Count];
            for (int i = 0; i < price.Length; i++)
            {
                price[i] = Int32.Parse(DGV_SearchBook_Right.Rows[i].Cells[3].Value.ToString());
            }
            int[] amount = new int[DGV_SearchBook_Right.Rows.Count];
            for (int i = 0; i < price.Length; i++)
            {
                amount[i] = Int32.Parse(DGV_SearchBook_Right.Rows[i].Cells[4].Value.ToString());
            }
            LB_SearchBook_Total.Text = "Total:    " + CountTotal(price, amount).ToString();
        }

        private void DGV_SearchBook_Right_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int[] price = new int[DGV_SearchBook_Right.Rows.Count];
            for (int i = 0; i < price.Length; i++)
            {
                price[i] = Int32.Parse(DGV_SearchBook_Right.Rows[i].Cells[3].Value.ToString());
            }
            int[] amount = new int[DGV_SearchBook_Right.Rows.Count];
            for (int i = 0; i < price.Length; i++)
            {
                amount[i] = Int32.Parse(DGV_SearchBook_Right.Rows[i].Cells[4].Value.ToString());
            }
            LB_SearchBook_Total.Text = "Total:    " + CountTotal(price, amount).ToString();
        }

        private void TB_SearchBook_Search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = database_SaleReceipts.searchLeftData(TB_SearchBook_Search.Text);
            DGV_SearchBook_Left.DataSource = dt2;
        }
    }
}
