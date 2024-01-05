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
            dataTable = new DataTable();
            dataTable = database.getTable(ClassDefineName.table_ImportReceipt_TableName);
            return dataTable;
        }

        public bool getNameFromID(string ID)
        {
            string sqlCommand = $"SELETCT {ClassDefineName.Pu} FROM {ClassDefineName.table_ImportReceipt_TableName} {ClassDefineName.table_ImportReceipt_ImportID} VALUES (;)";
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
        public bool InsertData(Class_Suppliers obj)
        {
            string sqlCommand = $"INSERT INTO {ClassDefineName.table_Suppliers_SupplierID} VALUES ('{obj.SupplierID1}', '{obj.SupplierName1}', '{obj.SupplierAddress1}', '{obj.SupplierTel1}', '{obj.SupplierState1}';)";
            return database.ExecuteSQL(sqlCommand);
        }

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

        public bool DeletDataByID(string ID)
        {
            string sqlCommand = $"DELETE FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceiptDetails_ImportID} = '{ID}';" +
                                $"DELETE FROM {ClassDefineName.table_ImportReceipt_TableName} WHERE {ClassDefineName.table_ImportReceipt_ImportID} = '{ID}';";
            return database.ExecuteSQL(sqlCommand);
        }


        public DataTable SearchDataWithState(string keyWords, string State)
        {
            dataTable = new DataTable();
            dataTable = database.getSeachAndDisplayTable(ClassDefineName.table_Suppliers_TableName,
                ClassDefineName.table_Suppliers_SupplierState, State, ClassDefineName.table_Suppliers_SupplierName, keyWords);
            return dataTable;
        }

        public DataTable SearchDataNonState(string keyWords, string State)
        {
            dataTable = new DataTable();
            dataTable = database.getSeachAndDisplayTableNonState(ClassDefineName.table_Suppliers_TableName, ClassDefineName.table_Suppliers_SupplierName, keyWords);
            return dataTable;
        }


        public bool getColumnID(string ColumnID, string ID)
        {
            string sqlCommand = $"SELECT {ColumnID} FROM {ClassDefineName.table_Suppliers_TableName} WHERE {ClassDefineName.table_Suppliers_SupplierID} = '{ID}';";
            return database.ExecuteSQL(sqlCommand);
        }
    }
}
