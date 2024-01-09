using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Database
{
    public class Database
    {
        SqlConnection SQLCONN;
        SqlCommand CMD;
        string CONSTRING;
        DataSet DS;


        public Database(string servername, string databasename, string user = "sa", string pass = "180403")
        {
            // Kết nối csdl theo servername và database name
            DS = new DataSet();
            CONSTRING = "Data Source=" + servername + ";Initial Catalog=" + databasename + ";PersistSecurityInfo=True;User ID=" + user + ";Password=" + pass + ";Encrypt=True;TrustServerCertificate=True";
            SQLCONN = new SqlConnection(CONSTRING);
            SQLCONN.Open();
        }



        public DataTable getTable(string tablename)
        {
            DataTable datatable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + tablename, this.SQLCONN);
            dataAdapter.Fill(datatable);
            DS.Tables.Add(datatable);
            return datatable;
        }



        public DataTable getTableByState(string tablename, string ColumnState, string State)
        {
            DataTable datatable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + tablename + " WHERE " + ColumnState + " = '" + State + "'", this.SQLCONN);
            dataAdapter.Fill(datatable);
            DS.Tables.Add(datatable);
            return datatable;
        }


        public DataTable getSeachAndDisplayTable(string tablename, string ColumnState, string State,  string columnName, string keyWords)
        {
            DataTable datatable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + tablename + " WHERE " + ColumnState + " = '" + State + "' AND " + columnName + " LIKE '%" + keyWords + "%';", this.SQLCONN);
            dataAdapter.Fill(datatable);
            DS.Tables.Add(datatable);
            return datatable;
        }


        public DataTable getSeachAndDisplayTableNonState(string tablename, string columnName, string keyWords)
        {
            DataTable datatable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + tablename + " WHERE " + columnName + " LIKE '%" + keyWords + "%';", this.SQLCONN);
            dataAdapter.Fill(datatable);
            DS.Tables.Add(datatable);
            return datatable;
        }



        public DataTable GetDataTable(string sqlCommand)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, SQLCONN))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public bool ExecuteSQL(string sqlCommand)
        {
            try
            {
                CMD = new SqlCommand(sqlCommand);
                CMD.CommandType = CommandType.Text;
                CMD.Connection = SQLCONN;
                CMD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing SQL command: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable ExecuteSQLReturnTable(string sqlCommand)
        {
            DataTable datatable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.SQLCONN);
            dataAdapter.Fill(datatable);
            DS.Tables.Add(datatable);
            return datatable;
        }



        public int ExecuteSQL_CheckDuplicate(string sqlCommand)
        {
            try
            {
                CMD = new SqlCommand(sqlCommand);
                CMD.CommandType = CommandType.Text;
                CMD.Connection = SQLCONN;

                // Use ExecuteScalar to get the count of duplicates
                int count = (int)CMD.ExecuteScalar();

                return count; // Return the count of duplicates
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing SQL command: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate failure
            }
        }

   



        /*        public bool executeSQL(string sql)
                {
                    CMD = new SqlCommand(sql);
                    CMD.CommandType = CommandType.Text;
                    CMD.Connection = SQLCONN;
                    if (CMD.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    return false;
                }



                public bool executeProcedure(string nameProcedure, SqlParameter[] SQL_Para)
                {
                    CMD = new SqlCommand(nameProcedure);
                    CMD.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter par in SQL_Para)
                    {
                        CMD.Parameters.Add(par);
                    }
                    CMD.Connection = SQLCONN;
                    if (CMD.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    return false;
                }*/



    }
}
