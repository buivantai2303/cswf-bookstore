using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Database
{
    internal class Database_Suppliers
    {

        Database database;
        DataTable dataTable;

        public Database_Suppliers(string servername, string databasename) 
        {
            database = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            dataTable = new DataTable();
            dataTable = database.getTable(ClassDefineName.table_Suppliers_TableName);
            return dataTable;
        }

        //  Get data rows active suppliers ================================================================
        public DataTable getActiveTable()
        {
            dataTable = new DataTable();
            dataTable = database.GetDataTable("SELECT * FROM Suppliers WHERE SupplierState = 'Active'");
            return dataTable;
        }


        // Get data rows Inactive suppliers ===============================================================
        public DataTable getInActiveTable()
        {

            dataTable = new DataTable();
            dataTable = database.GetDataTable("SELECT * FROM Suppliers WHERE SupplierState = 'Inactive'");
            return dataTable;
        }


        // Get numbers of active suppliers ================================================================
        public int getActiveRowCount()
        {
            int rowCount = 0;
            dataTable = database.GetDataTable("SELECT * FROM Suppliers WHERE SupplierState = 'Active'");
            if (dataTable != null)
            {
                rowCount = dataTable.Rows.Count;
            }

            return rowCount;
        }


        // Insert value to SQL =============================================================================
        public bool InsertData(Class_Suppliers obj)
        {
            string sqlCommand = $"INSERT INTO Suppliers VALUES ('{obj.SupplierID1}', '{obj.SupplierName1}', '{obj.SupplierAddress1}', '{obj.SupplierTel1}', '{obj.SupplierState1}')";
            return database.ExecuteSQL(sqlCommand);
        }

        public bool UpdateData (Class_Suppliers obj, string ID)
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
            string sqlCommand = $"DELETE FROM {ClassDefineName.table_Suppliers_TableName} WHERE {ClassDefineName.table_Suppliers_SupplierID} = '{ID}';";
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


        public int IsDuplicateSupplier(string supplierID)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM {ClassDefineName.table_Suppliers_TableName} WHERE {ClassDefineName.table_Suppliers_SupplierID} = '{supplierID}'";

            return database.ExecuteSQL_CheckDuplicate(sqlCommand);
        }

    }
}
