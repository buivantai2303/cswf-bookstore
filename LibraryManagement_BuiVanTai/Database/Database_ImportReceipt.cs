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


        // Declare new connection ====================================================================================
        public Database_ImportReceipt(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }


        // Get data from table ImportReceipt =========================================================================
        public DataTable getTable()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_ImportReceiptDetails_ImportID}, " +
                               $"{ClassDefineName.table_ImportReceipt_ImportDate}, " +
                               $"{ClassDefineName.table_Publishers_PublisherName}, " +
                               $"{ClassDefineName.table_Staffs_StaffName} " + // Assuming this is the correct column for StaffName
                               $"FROM {ClassDefineName.table_ImportReceipt_TableName} " +
                               $"JOIN {ClassDefineName.table_Publishers_TableName} " +
                               $"ON {ClassDefineName.table_ImportReceipt_TableName}.{ClassDefineName.table_Publishers_PublisherID} = " +
                               $"{ClassDefineName.table_Publishers_TableName}.{ClassDefineName.table_Publishers_PublisherID} " +
                               $"JOIN {ClassDefineName.table_Staffs_TableName} " +
                               $"ON {ClassDefineName.table_ImportReceipt_TableName}.{ClassDefineName.table_Staffs_StaffID} = " +
                               $"{ClassDefineName.table_Staffs_TableName}.{ClassDefineName.table_Staffs_StaffID}";

            return database.GetDataTable(sqlCommand);
        }



        // Insert value to SQL =============================================================================
        public bool InsertData(Class_ImportReceipt obj, ComboBox PublisherName, ComboBox staffName)
        {
            string sqlCommand = $"INSERT INTO {ClassDefineName.table_ImportReceipt_TableName} ({ClassDefineName.table_ImportReceipt_ImportID}, {ClassDefineName.table_ImportReceipt_ImportDate}, {ClassDefineName.table_ImportReceipt_PublisherID}, {ClassDefineName.table_ImportReceipt_StaffID})" +
                $"VALUES ('{obj.ImportID1}', '{obj.ImportDate1}'," +
                $"(SELECT {ClassDefineName.table_Publishers_PublisherID} FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherName} = '{PublisherName.Text}')," +
                $"(SELECT {ClassDefineName.table_Staffs_StaffID} FROM {ClassDefineName.table_Staffs_TableName} WHERE {ClassDefineName.table_Staffs_StaffName} = '{staffName.Text}')" +
                $");";
            return database.ExecuteSQL(sqlCommand); 
        }


        // Delete data row by click in action column== =====================================================
        public bool DeletDataByID(string ID)
        {
            string sqlCommand = $"DELETE FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceiptDetails_ImportID} = '{ID}';" +
                                $"DELETE FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceipt_ImportID} = '{ID}';";
            return database.ExecuteSQL(sqlCommand);
        }

        // Searching data by search funtion from user ======================================================
        public DataTable SearchData(string keyWords, string date)
        {
            string sqlCommand = $"SELECT * FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceipt_ImportID} LIKE '%{keyWords}%' AND {ClassDefineName.table_ImportReceipt_ImportDate} LIKE '%{date}%';";
            return database.GetDataTable(sqlCommand);
        }

        // Get PublisherName to the CBB_ImportReceipt_SupplierName =========================================
        public DataTable GetPublisherName(string PubID)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Publishers_PublisherName} FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherID} LIKE '%{PubID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffName(string StaffID)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Staffs_StaffName} FROM {ClassDefineName.table_Staffs_TableName} WHERE {ClassDefineName.table_Staffs_StaffID} LIKE '%{StaffID}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetPublisherID()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Publishers_PublisherID} FROM {ClassDefineName.table_Publishers_TableName};";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetPublisherID(string PubName)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Publishers_PublisherID} FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherName} LIKE '%{PubName}%';";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffID()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Staffs_StaffID} FROM {ClassDefineName.table_Staffs_TableName};";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffID(string staffName)
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Staffs_StaffID} FROM {ClassDefineName.table_Staffs_TableName} WHERE {ClassDefineName.table_Staffs_StaffName} LIKE '%{staffName}%';";
            return database.GetDataTable(sqlCommand);
        }

        public int IsDuplicateSupplier(string ImportID)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceipt_ImportID} LIKE '%{ImportID}%'";
            return database.ExcuteSQL_CheckDuplicate(sqlCommand);
        }


    }
}
