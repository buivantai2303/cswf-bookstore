using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Database
{
    internal class Database_ImportReceiptDetails
    {

        Database database = null;
        DataTable dataTable = null;


        public Database_ImportReceiptDetails() { }

        // Dynamic change server and database =============================================================
        private string TableName = "ImportReceiptDetails";


        // Declare new connection ====================================================================================
        public Database_ImportReceiptDetails(string servername, string databasename, string user = "", string pass = "")
        {
            database = new Database(servername, databasename);
        }
        

        // Get data from table Databse_ImportReceiptDetails ==========================================================
        public DataTable getTable()
        {
            dataTable = new DataTable();
            dataTable = database.getTable(TableName);
            return dataTable;
        }


    }
}
