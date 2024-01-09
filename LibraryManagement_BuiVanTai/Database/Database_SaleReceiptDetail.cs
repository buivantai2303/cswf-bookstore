using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_SaleReceiptDetail
    {
        Database database;
        DataTable dataTable;

        public Database_SaleReceiptDetail(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }

        public DataTable getTable(string SaleID)
        {
            dataTable = new DataTable();
            dataTable = database.ExecuteSQLReturnTable($"SELECT BookName, SaleNumber, sd.CustomerID, sd.Price FROM SaleReceiptDetails sd INNER JOIN Books b ON sd.BookID = b.BookID WHERE sd.ReceiptID = '{SaleID}'");
            return dataTable;
        }

        public bool InsertData(Class_SaleReceiptDetails sale)
        {
            string query = "INSERT INTO SaleReceiptDetails VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.BookID + "\'," + "\'" + sale.SaleNumber + "\'," + "\'" + sale.CustomerID + "\'," + "\'" + sale.Price + "\')";
            return database.ExecuteSQL(query);
        }

        public bool DeleteData(Class_SaleReceiptDetails sale)
        {
            string query = "DELETE FROM SaleReceiptDetails WHERE ReceiptID = \'" + sale.ReceiptID + "\'";
            return database.ExecuteSQL(query);
        }

    }
}
