using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_Publisher
    {
        Database database;
        DataTable dataTable;

        public Database_Publisher(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            dataTable = new DataTable();
            dataTable = database.getTable("Publishers");
            return dataTable;
        }

        //  Get data rows active suppliers ================================================================
        public DataTable getActiveTable()
        {
            dataTable = new DataTable();
            dataTable = database.getTableByState(ClassDefineName.table_Publishers_TableName,
                ClassDefineName.table_Publishers_PublisherState, "Active");
            return dataTable;
        }


        // Get data rows Inactive suppliers ===============================================================
        public DataTable getInActiveTable()
        {
            dataTable = new DataTable();
            dataTable = database.getTableByState(ClassDefineName.table_Publishers_TableName,
                ClassDefineName.table_Publishers_PublisherState, "Inactive");
            return dataTable;
        }


        public bool InsertData(Class_Publisher pub)
        {
            string query = "INSERT INTO Publishers VALUES (\'" + pub.PublisherId +"\'," + "\'" + pub.PublisherName +"\'," + "\'" + pub.PublisherAddress +"\'," + "\'" + pub.PublisherTel +"\'," + "\'" + pub.PublisherState +"\')";
            return database.ExecuteSQL(query);
        }

        public bool UpdatePub(Class_Publisher pub)
        {
            string query = "UPDATE Publishers " +
            "Set PublisherName = " + "\'" + pub.PublisherName +"\'," + "PublisherAddress = " + "\'" + pub.PublisherAddress +"\'," + "PublisherTel = " + "\'" + pub.PublisherTel +"\'," + "PublisherState = " + "\'" + pub.PublisherState +"\'"
            + "WHERE PublisherID = \'" + pub.PublisherId +"\'";
            return database.ExecuteSQL(query);
        }

        public bool DeletePubByID(Class_Publisher pub)
        {
            string query = "DELETE FROM Publishers WHERE PublisherID = \'" + pub.PublisherId +"\'";
            return database.ExecuteSQL(query);
        }

        public DataTable getCustomTable(string command)
        {
            DataTable dt2 = new DataTable();
            dt2 = database.ExecuteSQLReturnTable(command);
            return dt2;
        }

        public int IsDuplicatePublisherID(string publisherID)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherID} = '{publisherID}'";

            return database.ExcuteSQL_CheckDuplicate(sqlCommand);
        }

        public int IsDuplicatePublisherTel(string publisherTel)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherTel} = '{publisherTel}'";

            return database.ExcuteSQL_CheckDuplicate(sqlCommand);
        }

        public int IsDuplicatePublisherName(string publisherName)
        {
            string sqlCommand = $"SELECT COUNT(*) FROM {ClassDefineName.table_Publishers_TableName} WHERE {ClassDefineName.table_Publishers_PublisherName} = '{publisherName}'";

            return database.ExcuteSQL_CheckDuplicate(sqlCommand);
        }

        public DataTable SearchDataWithState(string keyWords, string State)
        {
            dataTable = new DataTable();
            dataTable = database.getSeachAndDisplayTable(ClassDefineName.table_Publishers_TableName,
                ClassDefineName.table_Publishers_PublisherState, State, ClassDefineName.table_Publishers_PublisherName, keyWords);
            return dataTable;
        }

        public DataTable SearchDataNonState(string keyWords)
        {
            dataTable = new DataTable();
            dataTable = database.getSeachAndDisplayTableNonState(ClassDefineName.table_Publishers_TableName, ClassDefineName.table_Publishers_PublisherName, keyWords);
            return dataTable;
        }

    }
}
