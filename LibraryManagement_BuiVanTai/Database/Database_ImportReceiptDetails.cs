using LibraryManagement_BuiVanTai.Class;
using System.Data;
using System.Net;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_ImportReceiptDetails
    {
        public Database database = null;

        public Database_ImportReceiptDetails() { }

        public Database_ImportReceiptDetails(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }

        public DataTable getTable(string ID)
        {
            string sqlCommand = $"SELECT BookID, ImportAmount, SupplierName, Price " +
                                $"FROM ImportReceiptDetails " +
                                $"JOIN Suppliers " +
                                $"ON ImportReceiptDetails.SupplierID = Suppliers.SupplierID " +
                                $"WHERE ImportID = '{ID}'";

            return database.GetDataTable(sqlCommand);
        }


        // Insert
        public bool InsertData(Class_ImportReceiptDetails obj)
        {
            string sqlCommand = $"INSERT INTO ImportReceiptDetails VALUES ('{obj.ImportID}', '{obj.BookID}', '{obj.ImportAmount}', '{obj.SupplierID}', '{obj.Price}')";
            return database.ExecuteSQL(sqlCommand);
        }


        // Delete
        public bool DeleteData(Class_ImportReceiptDetails obj)
        {
            string sqlCommand = $"DELETE FROM ImportReceipt WHERE ImportID = '{obj.ImportID}';";
            return database.ExecuteSQL(sqlCommand);
        }



        public DataTable GetBook(string Request, string BookID)
        {
            if (Request == "GetBookID" && BookID == null)
            {
                string sqlCommand = $"SELECT BookID FROM Books;";
                return database.GetDataTable(sqlCommand);
            }
            else if (Request == "GetBookPrice" && BookID != null)
            {
                string sqlCommand = $"SELECT Price FROM Books WHERE BookID LIKE '%{BookID}%';";
                return database.GetDataTable(sqlCommand);
            }
            else if (Request == "GetBookName" && BookID != null)
            {
                string sqlCommand = $"SELECT BookName FROM Books WHERE BookID LIKE '%{BookID}%';";
                return database.GetDataTable(sqlCommand);
            }
            return null;
        }

        public DataTable GetSuppliers(string Request, string SupplierID)
        {
            if (Request == "GetSupplierName" && SupplierID != null)
            {
                string sqlCommand = $"SELECT SupplierName FROM Suppliers WHERE SupplierID LIKE '%{SupplierID}%';";
                return database.GetDataTable(sqlCommand);
            } 
            else if (Request == "GetSupplierID" && SupplierID == null)
            {
                string sqlCommand = $"SELECT SupplierID FROM Suppliers;";
                return database.GetDataTable(sqlCommand);
            }
            return null;
        }
        
    }
}
