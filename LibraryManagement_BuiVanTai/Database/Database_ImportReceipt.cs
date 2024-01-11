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
    public class Database_ImportReceipt
    {

        Database database = null;

        public Database_ImportReceipt() { }

        public Database_ImportReceipt(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }


        public DataTable getTable()
        {
            string sqlCommand = $"SELECT ImportID, ImportDate, PublisherName, StaffName " +
                               $"FROM ImportReceipt " +
                               $"JOIN Publishers ON ImportReceipt.PublisherID = Publishers.PublisherID " +
                               $"JOIN Staffs ON ImportReceipt.StaffID = Staffs.StaffID";

            return database.GetDataTable(sqlCommand);
        }


        public bool InsertData(Class_ImportReceipt obj)
        {
            string sqlCommand = $"INSERT INTO ImportReceipt (ImportID, ImportDate, PublisherID, StaffID)" +
                                $"VALUES ('{obj.ImportID}', '{obj.ImportDate}', '{obj.PublisherID}', '{obj.StaffID}')";
            return database.ExecuteSQL(sqlCommand); 
        }


        public bool DeletDataByID(Class_ImportReceipt obj)
        {
            string sqlCommand = $"DELETE FROM ImportReceiptDetails WHERE ImportID = '{obj.ImportID}';" +
                                $"DELETE FROM ImportReceipt WHERE ImportID = '{obj.ImportID}';";
            return database.ExecuteSQL(sqlCommand);
        }


        public DataTable SearchData(string keyWords, string date)
        {
            string sqlCommand = $"SELECT * FROM ImportReceipt WHERE ImportID LIKE '%{keyWords}%' AND ImportDate LIKE '%{date}%';";
            return database.GetDataTable(sqlCommand);
        }


        public DataTable GetStaffID(string ImportID)
        {
            if (ImportID == "")
            {
                string sqlCommand = $"SELECT StaffID FROM Staffs;";
                return database.GetDataTable(sqlCommand);
            }
            else 
            {
                string sqlCommand = $"SELECT StaffID FROM ImportReceipt WHERE ImportID LIKE '%{ImportID}%';";
                return database.GetDataTable(sqlCommand);
            }
        }

        public DataTable GetStaffName(string StaffID)
        {
            string sqlCommand = $"SELECT StaffName FROM Staffs WHERE StaffID LIKE '%{StaffID}%';";
            return database.GetDataTable(sqlCommand);
        }


        public DataTable GetPublisherID(string ImportID)
        {
            if (ImportID == "GetID")
            {
                string sqlCommand = $"SELECT PublisherID FROM Publishers;";
                return database.GetDataTable(sqlCommand);

            } 
            else
            {
                string sqlCommand = $"SELECT PublisherName FROM Publishers WHERE PublisherID = '{ImportID}';";
                return database.GetDataTable(sqlCommand);
            }
        }

        public DataTable GetPublisherName(string PubID)
        {
            string sqlCommand = $"SELECT PublisherName FROM Publishers WHERE PublisherID LIKE '%{PubID}%';";
            return database.GetDataTable(sqlCommand);
        }

 

        public int IsDuplicateSupplier(string ImportID)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM ImportReceipt WHERE ImportID LIKE '%{ImportID}%'";
            return database.ExecuteSQL_CheckDuplicate(sqlCommand);
        }


    }
}
