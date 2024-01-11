using LibraryManagement_BuiVanTai.Class;
using System.Data;


namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_SaleReceipts
    {
        Database database;
        DataTable dt;

        public Database_SaleReceipts(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }


        public DataTable getTable()
        {
            string sqlCommand = $"SELECT * FROM SaleReceipts";
            return database.GetDataTable(sqlCommand);

        }


        public bool InsertData(Class_SaleReceipt sale)
        {
            string query = "INSERT INTO SaleReceipts VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.StaffID + "\'," + "\'" + sale.SaleDate + "\')";
            return database.ExecuteSQL(query);
        }


        public bool DeleteData(Class_SaleReceipt sale)
        {
            string query = "DELETE FROM SaleReceipts WHERE ReceiptID = \'" + sale.ReceiptID + "\'";
            return database.ExecuteSQL(query);
        }


        public DataTable getCustomTable(string command)
        {
            dt = database.ExecuteSQLReturnTable(command);
            return dt;
        }

        public DataTable searchLeftData(string keyword)
        {
            dt = database.ExecuteSQLReturnTable("SELECT BookID, BookName, BookType, Remaining, Price FROM Books WHERE BookName like '%" + keyword + "%'");
            return dt;
        }

        public DataTable searchSaleReceipt(string keyword)
        {
            string sqlCommand = $"SELECT * FROM SaleReceipts WHERE ReceiptID LIKE '%{keyword}' OR StaffID LIKE '%{keyword}%' OR SaleDate LIKE '%{keyword}%'";
            dt = database.ExecuteSQLReturnTable(sqlCommand);
            return dt;
        }


        public DataTable GetPublisherID()
        {
            string sqlCommand = $"SELECT ReceiptID FROM Publishers;";
            return database.GetDataTable(sqlCommand);
        }

        public bool DeleteSaleByID(Class_SaleReceipt sale)
        {
            string query =  $"DELETE FROM SaleReceiptDetails WHERE ReceiptID = '{sale.ReceiptID}' " +
                            $"DELETE FROM SaleReceipts WHERE ReceiptID = '{sale.ReceiptID}'";
            return database.ExecuteSQL(query);
        }

    }
}
