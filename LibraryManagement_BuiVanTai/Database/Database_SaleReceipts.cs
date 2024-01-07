using LibraryManagement_BuiVanTai.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database_SaleReceipts
    {
        Database db1;
        DataTable dt;

        public Database_SaleReceipts(string servername, string databasename)
        {
            db1 = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            dt = new DataTable();
            dt = db1.getTable("SaleReceipts");
            return dt;
        }

        public bool InsertData(Class_SaleReceipt sale)
        {
            string query = "INSERT INTO SaleReceipts VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.StaffID + "\'," + "\'" + sale.SaleDate + "\')";
            return db1.ExecuteSQL(query);
        }

/*        public bool UpdateData(Class_SaleReceipt sale)
        {
            string query = "UPDATE SaleReceipts " +
            "Set  = " + "\'" +  + "\'," + " = " + "\'" +  + "\'," + " = " + "\'" +  + "\'," + " = " + "\'" +  + "\',"
            + "WHERE ReceiptID = \'" +  + "\'";
            return db.ExecuteSQL(query);
        }*/

        public bool DeleteData(Class_SaleReceipt sale)
        {
            string query = "DELETE FROM SaleReceipts WHERE ReceiptID = \'" + sale.ReceiptID + "\'";
            return db1.ExecuteSQL(query);
        }

        /*        public DataTable searchData(string keyword)
                {
                    dt = db.ExecuteSQLReturnTable("SELECT * FROM SaleReceipts WHERE ReceiptID like '%" + keyword + "%'");
                    return dt;
                }*/

        public DataTable getCustomTable(string command)
        {
            DataTable dt2 = new DataTable();
            dt2 = db1.ExecuteSQLReturnTable(command);
            return dt2;
        }

        public DataTable searchLeftData(string keyword)
        {
            DataTable dt2 = new DataTable();
            dt2 = db1.ExecuteSQLReturnTable("SELECT BookID, BookName, BookType, Remaining, Price FROM Books WHERE BookName like '%" + keyword + "%'");
            return dt2;
        }
    }
}
