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
        Database database;
        DataTable dataTable;

        public Database_SaleReceipts(string servername, string databasename)
        {
            database = new Database(servername, databasename);
        }

        public DataTable getTable()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_SaleReceipts_ReceiptID}, {ClassDefineName.table_Staffs_StaffName}, {ClassDefineName.table_SaleReceipts_SaleDate} " +
                $"FROM {ClassDefineName.table_SaleReceipts_TableName} " +
                $"JOIN {ClassDefineName.table_Staffs_TableName} ON {ClassDefineName.table_Staffs_TableName}.{ClassDefineName.table_Staffs_StaffID} = {ClassDefineName.table_SaleReceipts_TableName}.{ClassDefineName.table_SaleReceipts_StaffID}";
            return database.GetDataTable(sqlCommand);
        }


        public bool InsertData(Class_SaleReceipt sale)
        {
            string query = "INSERT INTO SaleReceipts VALUES (\'" + sale.ReceiptID + "\'," + "\'" + sale.StaffID + "\'," + "\'" + sale.SaleDate + "\')";
            return database.ExecuteSQL(query);
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
            return database.ExecuteSQL(query);
        }

/*        public DataTable searchData(string keyword)
        {
            dt = db.ExecuteSQLReturnTable("SELECT * FROM SaleReceipts WHERE ReceiptID like '%" + keyword + "%'");
            return dt;
        }*/

        public DataTable searchLeftData(string keyword)
        {
            DataTable dt2 = new DataTable();
            dt2 = database.ExecuteSQLReturnTable("SELECT BookID, BookName, BookType, Remaining, Price FROM Books WHERE BookName like '%" + keyword + "%'");
            return dt2;
        }


        public DataTable GetPublisherID()
        {
            string sqlCommand = $"SELECT {ClassDefineName.table_SaleReceipts_ReceiptID} FROM {ClassDefineName.table_Publishers_TableName};";
            return database.GetDataTable(sqlCommand);
        }

        public bool DeleteSaleByID(Class_SaleReceipt sale)
        {
            string query = $"DELETE FROM SaleReceiptDetails WHERE ReceiptID = '{sale.ReceiptID}' " +
                $"DELETE FROM SaleReceipts WHERE ReceiptID = '{sale.ReceiptID}'";
            return database.ExecuteSQL(query);
        }


    }
}
