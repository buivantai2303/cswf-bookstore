using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_SaleReceiptDetail
    {
        Database db;
        DataTable dt;

        public Database_SaleReceiptDetail(string servername, string databasename)
        {
            db = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            dt = new DataTable();
            dt = db.getTable("SaleReceiptDetails");
            return dt;
        }

        public bool InsertData(Class_SaleReceiptDetails sale)
        {
            string query = "INSERT INTO SaleReceiptDetails VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.BookID + "\'," + "\'" + sale.SaleNumber + "\'," + "\'" + sale.CustomerID + "\'," + "\'" + sale.Price + "\')";
            return db.ExecuteSQL(query);
        }

        public bool DeleteData(Class_SaleReceiptDetails sale)
        {
            string query = "DELETE FROM SaleReceiptDetails WHERE ReceiptID = \'" + sale.ReceiptID + "\'";
            return db.ExecuteSQL(query);
        }

        public DataTable searchData(string keyword)
        {
            dt = db.ExecuteSQLReturnTable("SELECT * FROM SaleReceiptDetails WHERE ReceiptID like '%" + keyword + "%'");
            return dt;
        }
    }
}
