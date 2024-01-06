using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_Book
    {
        Database db;
        DataTable dt;

        public Database_Book(string servername, string databasename)
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
            string query = "INSERT INTO Books VALUES (\'" + book.BookId + "\'," + "\'" + book.BookTitle + "\'," + "\'" + book.Remaining + "\'," + "\'" + book.BookType + "\'," + "\'" + book.PublisherId + "\'," + "\'" + book.AuthorId + "\'," + "\'" + book.Price + "\')";
            return db.ExecuteSQL(query);
        }

        public bool UpdateData(Class_Book book)
        {
            string query = "UPDATE Books " +
            "Set BookName = " + "\'" + book.BookTitle + "\'," + "Remaining = " + "\'" + book.Remaining + "\'," + "BookType = " + "\'" + book.BookType + "\'," + "PublisherID = " + "\'" + book.PublisherId + "\'," + "AuthorID = " + "\'" + book.AuthorId +"\'," + "Price = " + "\'" + book.Price +"\'"
            + "WHERE BookID = \'" + book.BookId + "\';";
            return db.ExecuteSQL(query);
        }

        public bool DeleteData(Class_Book book)
        {
            string query = "DELETE FROM Books WHERE BookID = \'" + book.BookId + "\'";
            return db.ExecuteSQL(query);
        }

        public DataTable getCustomTable(string command)
        {
            DataTable dt2 = new DataTable();
            dt2 = db.ExecuteSQLReturnTable(command);
            return dt2;
        }

        public DataTable searchData(string keyword)
        {
            dt = db.ExecuteSQLReturnTable("SELECT BookID, BookName, Remaining, BookType, PublisherName, AuthorName, Price FROM Books b \r\nINNER JOIN Publishers p ON b.PublisherID=p.PublisherID\r\nINNER JOIN Authors a ON a.AuthorID=b.AuthorID\r\nWHERE BookName like '%" + keyword + "%'");
            return dt;
        }
    }
}
