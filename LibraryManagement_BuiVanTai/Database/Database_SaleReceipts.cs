using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_SaleReceipts
    {
        Database db;
        DataTable dt;

        public Database_SaleReceipts(string servername, string databasename)
        {
            db = new Database(servername, databasename);
        }


        public DataTable getTable()
        {
            string sqlCommand = $"SELECT * FROM SaleReceipts";
            return db.GetDataTable(sqlCommand);

        }


        public bool InsertData(Class_SaleReceipt sale)
        {
            string query = "INSERT INTO SaleReceipts VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.StaffID + "\'," + "\'" + sale.SaleDate + "\')";
            return db.ExecuteSQL(query);
        }


        public bool DeleteData(Class_SaleReceipt sale)
        {
            string query = "DELETE FROM SaleReceipts WHERE ReceiptID = \'" + sale.ReceiptID + "\'";
            return db.ExecuteSQL(query);
        }


        public DataTable getCustomTable(string command)
        {
            DataTable dt2 = new DataTable();
            dt2 = db.ExecuteSQLReturnTable(command);
            return dt2;
        }

        public DataTable searchLeftData(string keyword)
        {
            DataTable dt2 = new DataTable();
            dt2 = db.ExecuteSQLReturnTable("SELECT BookID, BookName, BookType, Remaining, Price FROM Books WHERE BookName like '%" + keyword + "%'");
            return dt2;
        }

        public DataTable searchSaleReceipt(string keyword)
        {
            DataTable dt2 = new DataTable();
            string sqlCommand = $"SELECT * FROM SaleReceipts WHERE ReceiptID LIKE '%{keyword}' OR StaffID LIKE '%{keyword}%' OR SaleDate LIKE '%{keyword}%'";
            dt2 = db.ExecuteSQLReturnTable(sqlCommand);
            return dt2;
        }


        public bool DeleteSaleByID(Class_SaleReceipt sale)
        {
            string query = $"DELETE FROM SaleReceiptDetails WHERE ReceiptID = '{sale.ReceiptID}' " +
                $"DELETE FROM SaleReceipts WHERE ReceiptID = '{sale.ReceiptID}'";
            return db.ExecuteSQL(query);
        }


    }
}
