using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            dt = new DataTable();
            dt = db.getTable("SaleReceipts");
            return dt;
        }

        public bool InsertData(Class_SaleReceipt sale)
        {
            string query = "INSERT INTO SaleReceipts VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.StaffID + "\'," + "\'" + sale.SaleDate + "\')";
            return db.ExecuteSQL(query);
        }

/*        public bool UpdateData(Class_SaleReceipt sale)
        {
            string query = "UPDATE SaleReceipts " +
            "Set  = " + "\'" +  + "\'," + " = " + "\'" +  + "\'," + " = " + "\'" +  + "\'," + " = " + "\'" +  + "\',"
            + "WHERE ReceiptID = \'" +  + "\'";
            return db.ExecuteSQL(query);
        }*/

        public bool DeleteData(Class_SaleReceipt sale)
        {
            string query = "DELETE FROM SaleReceipts WHERE ReceiptID = \'" + sale.ReceiptID + "\'";
            return db.ExecuteSQL(query);
        }

        public DataTable searchData(string keyword)
        {
            dt = db.ExecuteSQLReturnTable("SELECT * FROM SaleReceipts WHERE ReceiptID like '%" + keyword + "%'");
            return dt;
        }
    }
}
