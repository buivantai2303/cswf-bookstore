using LibraryManagement_BuiVanTai.Class;
using System.Data;
using System.Net;

namespace LibraryManagement_BuiVanTai.Database
{
    internal class Database_ImportReceiptDetails
    {
        private Database database = null;
        private DataTable dataTable = null;

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

        public bool InsertData(Class_ImportReceiptDetails obj)
        {
            string sqlCommand = $"INSERT INTO {ClassDefineName.table_ImportReceiptDetails_TableName} " +
                $"VALUES ('{obj.ImportID1}', '{obj.BookID1}', '{obj.ImportAmount1}', '{obj.SupplierID1}', '{obj.Price1}')";
            return database.ExecuteSQL(sqlCommand);
        }

        public DataTable GetBookName(string BookID)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Books_BookName} FROM {ClassDefineName.table_Books_TableName} WHERE {ClassDefineName.table_Books_BookID} LIKE '%{BookID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookID()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Books_BookID} FROM {ClassDefineName.table_Books_TableName};";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetSuppliersName(string SupplierID)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Suppliers_SupplierName} FROM {ClassDefineName.table_Suppliers_TableName} WHERE {ClassDefineName.table_Suppliers_SupplierID} LIKE '%{SupplierID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetSuppliersID()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Suppliers_SupplierID} FROM {ClassDefineName.table_Suppliers_TableName};";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookPrice(string BookID)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Books_Price} FROM {ClassDefineName.table_Books_TableName} WHERE {ClassDefineName.table_Books_BookID} LIKE '%{BookID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable DeleteData(string ImportID)
        {
            string sqlCommand = $"DELETE FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceipt_ImportID} = '{ImportID}';";
            return database.GetDataTable(sqlCommand);
            { }
        }
    }
}
