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
        Database db;
        DataTable dt;

        public Database_Publisher(string servername, string databasename)
        {
            db = new Database(servername, databasename);
        }

        public DataTable getTable(string tableName)
        {
            dt = new DataTable();
            dt = db.getTable("Publishers");
            return dt;
        }

        public bool InsertData(Class_Publisher pub)
        {
            string query = "INSERT INTO Publishers VALUES (\'" + pub.PublisherId +"\'," + "\'" + pub.PublisherName +"\'," + "\'" + pub.PublisherAddress +"\'," + "\'" + pub.PublisherTel +"\'," + "\'" + pub.PublisherState +"\')";
            return db.ExecuteSQL(query);
        }

        public bool UpdateDate(Class_Publisher pub)
        {
            string query = "UPDATE Publishers " +
            "Set PublisherName = " + "\'" + pub.PublisherName +"\'," + "PublisherAddress = " + "\'" + pub.PublisherAddress +"\'," + "PublisherTel = " + "\'" + pub.PublisherTel +"\'," + "PublisherState = " + "\'" + pub.PublisherState +"\',"
            + "WHERE PublisherID = \'" + pub.PublisherId +"\'";
            return db.ExecuteSQL(query);
        }

        public bool DeleteDate(Class_Publisher pub)
        {
            string query = "DELETE FROM Publishers WHERE PublisherID = \'" + pub.PublisherId +"\'";
            return db.ExecuteSQL(query);
        }

/*        public string toID(string name)
        {
            
            return pub.PublisherId;
        }*/
    }
}
