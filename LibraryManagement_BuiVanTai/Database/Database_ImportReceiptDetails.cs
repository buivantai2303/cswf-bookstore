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
            string sqlCommand = $"SELECT BookID, " +
                               $"ImportAmount, " +
                               $"SupplierName, " +
                               $"Price " +
                               $"FROM ImportReceiptDetails " +
                               $"JOIN Suppliers " +
                               $"ON ImportReceiptDetails.SupplierID = " +
                               $"Suppliers.SupplierID " +
                               $"WHERE ImportID = '{ID}'";

            return database.GetDataTable(sqlCommand);
        }


        public bool InsertData(Class_ImportReceiptDetails obj)
        {
            string sqlCommand = $"INSERT INTO ImportReceiptDetails " +
                $"VALUES ('{obj.ImportID1}', '{obj.BookID1}', '{obj.ImportAmount1}', '{obj.SupplierID1}', '{obj.Price1}')";
            return database.ExecuteSQL(sqlCommand);
        }

        public DataTable GetBookID()
        {
            string sqlCommand = $"SELECT BookID FROM Books;";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookName(string BookID)
        {
            string sqlCommand = $"SELECT BookName FROM Books WHERE BookID = '{BookID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookPrice(string BookID, string PublisherID)
        {
            string sqlCommand = $"SELECT B.Price FROM Books B JOIN ImportReceiptDetails IRD ON B.BookID = IRD.BookID JOIN ImportReceipt IR ON IRD.ImportID = IR.ImportID WHERE B.BookID = '{BookID}' AND IR.PublisherID = '{PublisherID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookPriceNonState(string BookID)
        {
            string sqlCommand = $"SELECT B.Price FROM Books B JOIN ImportReceiptDetails IRD ON B.BookID = IRD.BookID JOIN ImportReceipt IR ON IRD.ImportID = IR.ImportID WHERE B.BookID = '{BookID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookPrice(string BookID)
        {
            string sqlCommand = $"SELECT Price FROM Books WHERE BookID = '{BookID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookRemaining(string BookID)
        {
            string sqlCommand = $"SELECT Remaining FROM Books WHERE BookID = '{BookID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookType(string BookID)
        {
            string sqlCommand = $"SELECT BookType FROM Books WHERE BookID = '{BookID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookPublisherName(string ID)
        {
            string sqlCommand = $"SELECT PublisherName FROM Books " +
                $"JOIN Publishers ON Books.PublisherID = Publishers.PublisherID " +
                $"WHERE BookID = '{ID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetSuppliersID()
        {
            string sqlCommand = $"SELECT SupplierID FROM Suppliers;";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetSuppliersID(string BookID, string PublisherID)
        {
            string sqlCommand = $"SELECT DISTINCT IRD.SupplierID FROM ImportReceiptDetails IRD JOIN Books B ON IRD.BookID = B.BookID WHERE B.PublisherID = '{PublisherID}' AND B.BookID = '{BookID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookSupplierName(string ID)
        {
            string sqlCommand = $"SELECT SupplierName FROM Suppliers WHERE SupplierID = '{ID}';";
            return database.GetDataTable(sqlCommand);
        }


        public DataTable GetSuppliersName(string SupplierID)
        {
            string sqlCommand = $"SELECT SupplierName FROM Suppliers WHERE SupplierID = '{SupplierID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetAuthorName()
        {
            string sqlCommand = $"SELECT AuthorName FROM Authors;";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetAuthorName(string BookID)
        {
            string sqlCommand = $"SELECT AuthorName FROM Books " +
                $"JOIN Authors ON Books.AuthorID = Authors.AuthorID " +
                $"WHERE BookID = '{BookID}'";
            return database.GetDataTable(sqlCommand);
        }


        public DataTable DeleteData(string ImportID)
        {
            string sqlCommand = $"DELETE FROM ImportReceipt WHERE ImportID = '{ImportID}';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetBookRow(string BookID, string PublisherID, string SupplierID)
        {
            string sqlCommand = $" SELECT " +
                $"B.BookName, B.BookType, A.AuthorName, B.Remaining, S.SupplierName, B.Price " +
                $"FROM Books B " +
                $"JOIN Authors A ON B.AuthorID = A.AuthorID " +
                $"LEFT JOIN ImportReceiptDetails IRD ON IRD.BookID = B.BookID " +
                $"LEFT JOIN Suppliers S ON IRD.SupplierID = S.SupplierID " +
                $"WHERE B.BookID = '{BookID}' AND S.SupplierID LIKE '%{SupplierID}%' AND B.PublisherID = '{PublisherID}';";

            return database.GetDataTable(sqlCommand);
        }


    }
}
