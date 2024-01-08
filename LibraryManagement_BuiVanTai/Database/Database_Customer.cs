using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_Customer
    {
        Database db;
        DataTable dt;

        public Database_Customer(string servername, string databasename)
        {
            db = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            dt = new DataTable();
            dt = db.getTable("Customers");
            return dt;
        }

        public bool InsertData(Class_Customer ct)
        {
            string query = "INSERT INTO Customers VALUES (\'" + ct.Id + "\'," + "\'" + ct.FirstName + "\'," + "\'" + ct.LastName + "\'," + "\'" + ct.Tel + "\'," + "\'" + ct.Address + "\')";
            return db.ExecuteSQL(query);
        }

        public bool UpdateData(Class_Customer ct)
        {
            string query = "UPDATE Customers " +
            "Set FirstName = " + "\'" + ct.FirstName + "\'," + "LastName = " + "\'" + ct.LastName + "\'," + "Tel = " + "\'" + ct.Tel + "\'," + "Address = " + "\'" + ct.Address + "\'"
            + "WHERE CustomerID = \'" + ct.Id + "\'";
            return db.ExecuteSQL(query);
        }

        public bool DeleteData(Class_Customer ct)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = \'" + ct.Id + "\'";
            return db.ExecuteSQL(query);
        }

        public DataTable searchData(string keyword)
        {
            dt = db.ExecuteSQLReturnTable("SELECT * FROM Customers WHERE FirstName like '%" + keyword + "%' OR LastName like '%" + keyword + "%'");
            return dt;
        }
    }
}
