using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Database
{
    internal class Database_ImportReceiptDetails
    {

        Database database = null;
        DataTable dataTable = null;


        public Database_ImportReceiptDetails() { }

        // Dynamic change server and database =============================================================
        private string TableName = ClassDefineName.table_ImportReceiptDetails_TableName;


        // Declare new connection ====================================================================================
        public Database_ImportReceiptDetails(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }


        // Get data from table Databse_ImportReceiptDetails ==========================================================
        public DataTable getTable(string ID)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_ImportReceiptDetails_BookID}, " +
                               $"{ClassDefineName.table_ImportReceiptDetails_ImportAmount}, " +
                               $"{ClassDefineName.table_Suppliers_SupplierName}, " +
                               $"{ClassDefineName.table_ImportReceiptDetails_Price} " + // Assuming this is the correct column for StaffName
                               $"FROM {ClassDefineName.table_ImportReceiptDetails_TableName} " +
                               $"JOIN {ClassDefineName.table_Suppliers_TableName} " +
                               $"ON {ClassDefineName.table_ImportReceiptDetails_TableName}.{ClassDefineName.table_ImportReceiptDetails_SupplierID} = " +
                               $"{ClassDefineName.table_Suppliers_TableName}.{ClassDefineName.table_Suppliers_SupplierID} " +
                               $"WHERE {ClassDefineName.table_ImportReceiptDetails_ImportID} = '{ID}'";
                               
            return database.GetDataTable(sqlCommand);
        }


    }
}
