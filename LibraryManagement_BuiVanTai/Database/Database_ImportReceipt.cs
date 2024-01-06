using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool getNameFromID(string ID)
        {
            string sqlCommand = $"SELETCT {ClassDefineName.table_Publishers_PublisherName} FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherID} = '{ID}'";
            return database.ExecuteSQL(sqlCommand);
        }


        // Get numbers of active suppliers ================================================================
        public int getActiveRowCount()
        {
            int rowCount = 0;
            DataTable dataTable = database.getTableByState(ClassDefineName.table_Suppliers_TableName,
                ClassDefineName.table_Suppliers_SupplierState, ClassDefineName.table_Suppliers_SupplierState_Active);

            if (dataTable != null)
            {
                rowCount = dataTable.Rows.Count;
            }

            return rowCount;
        }


        // Insert value to SQL =============================================================================
        public bool c(Class_ImportReceipt obj, string SupplierName, string staffName)
        {
            string sqlCommand = $"INSERT INTO {ClassDefineName.table_ImportReceipt_TableName}" +
                $"VALUES ('{obj.ImportID1}', '{obj.ImportDate1}'," +
                $"(SELECT {ClassDefineName.table_Publishers_PublisherID} FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherName} = '{SupplierName}')," +
                $"(SELECT {ClassDefineName.table_Staffs_StaffID} FROM {ClassDefineName.table_Staffs_TableName} WHERE {ClassDefineName.table_Staffs_StaffName} = '{staffName}')" +
                $");";
            return database.ExecuteSQL(sqlCommand); 
        }

        // Update data by click "Add" button ===============================================================
        public bool UpdateData(Class_Suppliers obj, string ID)
        {
            string sqlCommand = $"UPDATE {ClassDefineName.table_Suppliers_TableName} " +
                $"SET {ClassDefineName.table_Suppliers_SupplierName} =  '{obj.SupplierName1}', " +
                $"{ClassDefineName.table_Suppliers_SupplierAddress} = '{obj.SupplierAddress1}', " +
                $"{ClassDefineName.table_Suppliers_SupplierTelephone} = '{obj.SupplierTel1}' , " +
                $"{ClassDefineName.table_Suppliers_SupplierState} = '{obj.SupplierState1}' " +
                $"WHERE {ClassDefineName.table_Suppliers_SupplierID} = '{ID}';";
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
        public DataTable GetPublisherNames()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Publishers_PublisherName} FROM {ClassDefineName.table_Publishers_TableName};";
            return database.GetDataTable(sqlCommand);
        }

        public DataTable GetStaffName()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_Staffs_StaffName} FROM {ClassDefineName.table_Staffs_TableName};";
            return database.GetDataTable(sqlCommand);
        }



    }
}
