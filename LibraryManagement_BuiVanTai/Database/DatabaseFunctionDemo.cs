using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Database
{
    internal class DatabaseFunctionDemo
    {

        Database database = null;
        DataTable dataTable = null;


        public DatabaseFunctionDemo() { }


        // Declare new connection ====================================================================================
        public DatabaseFunctionDemo(string servername, string databasename, string user = "", string pass = "")
        {
            database = new Database(servername, databasename);
        }


        // Get data from table Databse_ImportReceiptDetails ==========================================================
        public DataTable getTable(string TableName)
        {
            dataTable = new DataTable();
            dataTable = database.getTable("'" + TableName + "'");
            return dataTable;
        }


    }
}
