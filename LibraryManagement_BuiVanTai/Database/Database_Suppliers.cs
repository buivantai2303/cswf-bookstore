using System.Data;


namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_Suppliers
    {

        Database database;
        DataTable dataTable;

        public Database_Suppliers(string servername, string databasename) 
        {
            database = new Database(servername, databasename);
        }

        // Get and Search Table
        public DataTable getTable(string keyword, string state)
        {
            
            if (keyword == "" && state == "All")
            {
                dataTable = new DataTable();
                dataTable = database.GetDataTable($"SELECT * FROM Suppliers");
                return dataTable;
            }
            else if (keyword == "" && state != "All")
            {
                dataTable = new DataTable();
                dataTable = database.GetDataTable($"SELECT * FROM Suppliers WHERE SupplierState = '{state}'");
                return dataTable;
            }
            else if (keyword != "" && state != "")
            {
                dataTable = new DataTable();
                string sqlCommand = $"SELECT * FROM Suppliers WHERE SupplierID LIKE '%{keyword}%' AND SupplierState = '{state}' OR SupplierName LIKE '%{keyword}%' AND SupplierState = '{state}';";
                dataTable = database.GetDataTable(sqlCommand);
                return dataTable;
            }
            else if (keyword != "" && state == "All")
            {
                dataTable = new DataTable();
                string sqlCommand = $"SELECT * FROM Suppliers WHERE SupplierID LIKE '%{keyword}%' AND SupplierState = '{state}' OR SupplierName LIKE '%{keyword}%' AND SupplierState = '{state}';";
                dataTable = database.GetDataTable(sqlCommand);
                return dataTable;
            }

            return dataTable;
        }


        // Get count of supplier
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

        // Insert
        public bool InsertData(Class_Suppliers obj)
        {
            string sqlCommand = $"INSERT INTO Suppliers VALUES ('{obj.SupplierID}', '{obj.SupplierName}', '{obj.SupplierAddress}', '{obj.SupplierTel}', '{obj.SupplierState}')";
            return database.ExecuteSQL(sqlCommand);
        }


        // Update
        public bool UpdateData (Class_Suppliers obj)
        {
            string sqlCommand = $"UPDATE Suppliers SET SupplierName =  '{obj.SupplierName}', SupplierAddress = '{obj.SupplierAddress}', SupplierTelephone = '{obj.SupplierTel}' , SupplierState = '{obj.SupplierState}' WHERE SupplierID = '{obj.SupplierID}';";
            return database.ExecuteSQL(sqlCommand);
        } 


        // Delete
        public bool DeletData(Class_Suppliers obj )
        {
            string sqlCommand = $"DELETE FROM Suppliers WHERE SupplierID = '{obj.SupplierID}';";
            return database.ExecuteSQL(sqlCommand);
        }


        // Check duplicate
        public int IsDuplicateSupplier(string supplierID)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM Suppliers WHERE SupplierID = '{supplierID}'";

            return database.ExecuteSQL_CheckDuplicate(sqlCommand);
        }

    }
}
