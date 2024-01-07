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
        Database database;
        DataTable dataTable;

        public Database_SaleReceiptDetail(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }

        public DataTable getTable(string SaleID)
        {
            dataTable = new DataTable();
            dataTable = database.ExecuteSQLReturnTable($"SELECT {ClassDefineName.table_Books_TableName}.{ClassDefineName.table_Books_BookName}, " +
                $"{ClassDefineName.table_SaleReceiptDetails_TableName}.{ClassDefineName.table_SaleReceiptDetails_SaleNumber}, " +
                $"{ClassDefineName.table_Suppliers_TableName}.{ClassDefineName.table_Suppliers_SupplierName}, " +
                $"{ClassDefineName.table_SaleReceiptDetails_TableName}.{ClassDefineName.table_ImportReceiptDetails_Price} " +
                $"FROM {ClassDefineName.table_SaleReceiptDetails_TableName} " +
                $"JOIN {ClassDefineName.table_Books_TableName} ON {ClassDefineName.table_Books_TableName}.{ClassDefineName.table_Books_BookID} = {ClassDefineName.table_SaleReceiptDetails_TableName}.{ClassDefineName.table_SaleReceiptDetails_BookID} " +
                $"JOIN {ClassDefineName.table_Suppliers_TableName} ON {ClassDefineName.table_Suppliers_TableName}.{ClassDefineName.table_Suppliers_SupplierID} = {ClassDefineName.table_SaleReceiptDetails_TableName}.{ClassDefineName.table_SaleReceiptDetails_SupplierID} " +
                $"WHERE {ClassDefineName.table_SaleReceiptDetails_ReceiptID} = '{SaleID}';");
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

        public DataTable searchData(string keyword)
        {
            dataTable = database.ExecuteSQLReturnTable("SELECT * FROM SaleReceiptDetails WHERE ReceiptID like '%" + keyword + "%'");
            return dataTable;
        }
    }
}
