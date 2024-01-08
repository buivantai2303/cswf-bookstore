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
            dt = db.getTable("Staffs");
            return dt;
        }

        public bool InsertData(Class_Staff st)
        {
            string query = "INSERT INTO Staffs VALUES (\'" + st.StaffId +"\'," + "\'" + st.StaffName +"\'," + "\'" + st.StaffDOB +"\'," + "\'" + st.StaffAddress +"\'," + "\'" + st.StaffTel +"\')";
            return db.ExecuteSQL(query);
        }

        public bool UpdateData(Class_Staff st)
        {
            string query = "UPDATE Staffs " +
            "Set StaffName = " + "\'" + st.StaffName +"\'," + "StaffDOB = " + "\'" + st.StaffDOB +"\'," + "StaffAddress = " + "\'" + st.StaffAddress +"\'," + "StaffTel = " + "\'" + st.StaffTel +"\'"
            + "WHERE StaffID = \'" + st.StaffId +"\'";
            return db.ExecuteSQL(query);
        }

        public bool DeleteData(Class_Staff st)
        {
            string query = "DELETE FROM Staffs WHERE AuthorID = \'" + st.StaffId +"\'";
            return db.ExecuteSQL(query);
        }

        public DataTable searchData(string keyword)
        {
            dt = db.ExecuteSQLReturnTable("SELECT * FROM Staffs WHERE StaffName like '%" + keyword + "%' OR StaffID like '%" + keyword + "%'");
            return dt;
        }
    }
}
