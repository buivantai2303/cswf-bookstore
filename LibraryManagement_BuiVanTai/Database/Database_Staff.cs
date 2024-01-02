using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_Staff
    {
        Database db;
        DataTable dt;

        public Database_Staff(string servername, string databasename)
        {
            db = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            dt = new DataTable();
            dt = db.getTable("Books");
            return dt;
        }

        public bool InsertData(Class_Book book)
        {
            string query = "INSERT INTO Books VALUES (\'" + book.BookId + "\'," + "\'" + book.BookTitle + "\'," + "\'" + book.Remaining + "\'," + "\'" + book.BookType + "\'," + "\'" + book.PublisherId + "\'" + "\'" + book.AuthorId + "\'" + "\'" + book.Price + "\')";
            return db.ExecuteSQL(query);
        }

        public bool UpdateDate(Class_Book book)
        {
            string query = "UPDATE Books " +
            "Set BookName = " + "\'" + book.BookTitle + "\'," + "Remaining = " + "\'" + book.Remaining + "\'," + "BookType = " + "\'" + book.BookType + "\'," + "PublisherID = " + "\'" + book.PublisherId + "\'," + "AuthorID = " + "\'" + book.AuthorId + "\'," + "Price = " + "\'" + book.Price + "\',"
            + "WHERE BookID = \'" + book.BookId + "\'";
            return db.ExecuteSQL(query);
        }

        public bool DeleteDate(Class_Book book)
        {
            string query = "DELETE FROM Books WHERE BookID = \'" + book.BookId + "\'";
            return db.ExecuteSQL(query);
        }
    }
}
