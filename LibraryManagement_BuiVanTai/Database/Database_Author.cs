using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManagement_BuiVanTai.Class;
using System.Runtime.Remoting.Contexts;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_Author
    {
        Database db;
        DataTable dt;

        public Database_Author(string servername, string databasename)
        {
            db = new Database(servername, databasename);
        }

        public DataTable getTable(string tableName)
        {
            dt = new DataTable();
            dt = db.getTable("Authors");
            return dt;
        }

        public bool InsertData(Class_Author at)
        {
            string query = "INSERT INTO Authors VALUES (\'" + at.AuthorId + "\'," + "\'" + at.AuthorName + "\'," + "\'" + at.AuthorDOB + "\'," + "\'" + at.AuthorAddress + "\'," + "\'" + at.AuthorEmail + "\')";
            return db.ExecuteSQL(query);
        }

        public bool UpdateDate(Class_Author at)
        {
            string query = "UPDATE Authors " +
            "Set AuthorName = " + "\'" + at.AuthorName + "\'," + "AuthorDOB = " + "\'" + at.AuthorDOB + "\'," + "AuthorAddress = " + "\'" + at.AuthorAddress + "\'," + "AuthorEmail = " + "\'" + at.AuthorEmail + "\',"
            + "WHERE AuthorID = \'" + at.AuthorId + "\'";
            return db.ExecuteSQL(query);
        }

        public bool DeleteDate(Class_Author at)
        {
            string query = "DELETE FROM Authors WHERE AuthorID = \'" + at.AuthorId + "\'";
            return db.ExecuteSQL(query);
        }
    }
}
