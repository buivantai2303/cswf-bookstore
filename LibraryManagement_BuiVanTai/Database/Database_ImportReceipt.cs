using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Database
{
    internal class Database_ImportReceipt
    {

        Database database = null;
        DataTable dataTable = null;


        public Database_ImportReceipt() { }


        // Declare new connection ============================================================================================
        public Database_ImportReceipt(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }


        // Get data from table ImportReceipt =================================================================================
        public DataTable getTable()
        {
            string sqlCommand = $"SELECT ImportID, " +
                               $"ImportDate, " +
                               $"PublisherName, " +
                               $"StaffName " + // Assuming this is the correct column for StaffName
                               $"FROM ImportReceipt " +
                               $"JOIN Publishers " +
                               $"ON ImportReceipt.PublisherID = " +
                               $"Publishers.PublisherID " +
                               $"JOIN Staffs " +
                               $"ON ImportReceipt.StaffID = " +
                               $"Staffs.StaffID";

            return database.GetDataTable(sqlCommand);
        }


        // Insert value to SQL ===============================================================================================
        public bool InsertData(Class_ImportReceipt obj, string PublisherName, string staffName)
        {
            string sqlCommand = $"INSERT INTO ImportReceipt (ImportID, ImportDate, PublisherID, StaffID) VALUES ('{obj.ImportID1}', '{obj.ImportDate1}', " +
                $"(SELECT PublisherID FROM Publishers WHERE PublisherName = '{PublisherName}'), " +
                $"(SELECT StaffID FROM Staffs WHERE StaffName = '{staffName}');";
            return database.ExecuteSQL(sqlCommand); 
        }


        // Delete data row by click in action column== =======================================================================
        public bool DeletDataByID(Class_ImportReceipt obj)
        {
            string sqlCommand = $"DELETE FROM ImportReceiptDetails WHERE ImportID = '{obj.ImportID1}';" +
                                $"DELETE FROM ImportReceipt WHERE ImportID = '{obj.ImportID1}';";
            return database.ExecuteSQL(sqlCommand);
        }




        // Searching data by search funtion from user ========================================================================
        public DataTable SearchData(string keyWords, string date)
        {
            string sqlCommand = $"SELECT * FROM ImportReceipt WHERE ImportID LIKE '%{keyWords}%' AND ImportDate LIKE '%{date}%';";
            return database.GetDataTable(sqlCommand);
        }

        // Get PublisherName to the CBB_ImportReceipt_SupplierName ===========================================================
        public DataTable GetPublisherName(string PubID)
        {
            string sqlCommand = $"SELECT PublisherName FROM Publishers WHERE PublisherID LIKE '%{PubID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffName(string StaffID)
        {
            string sqlCommand = $"SELECT StaffName FROM Staffs WHERE StaffID LIKE '%{StaffID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetPublisherID()
        {
            string sqlCommand = $"SELECT PublisherID FROM Publishers;";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetPublisherID(string PubName)
        {
            string sqlCommand = $"SELECT PublisherID FROM Publishers WHERE PublisherName LIKE '%{PubName}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffID()
        {
            string sqlCommand = $"SELECT StaffID FROM Staffs;";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffID(string staffName)
        {
            string sqlCommand = $"SELECT StaffID FROM Staffs WHERE StaffName LIKE '%{staffName}%';";
            return database.GetDataTable(sqlCommand);
        }

        public int IsDuplicateSupplier(string ImportID)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM ImportReceipt WHERE ImportID LIKE '%{ImportID}%'";
            return database.ExecuteSQL_CheckDuplicate(sqlCommand);
        }

        public DataTable getCustomTable(string command)
        {
            DataTable dt2 = new DataTable();
            dt2 = database.ExecuteSQLReturnTable(command);
            return dt2;
        }

    }
}
