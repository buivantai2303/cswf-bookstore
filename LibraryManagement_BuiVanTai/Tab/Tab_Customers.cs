using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Tab
{
    public partial class Tab_Customers : UserControl
    {
        Database_Customer DC;
        DataTable dt;
        public Tab_Customers()
        {
            InitializeComponent();
        }

        private void Tab_Customers_Load(object sender, EventArgs e)
        {
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void GridViewFormLoad(string SererName, string DatabaseName)
        {
            DC = new Database_Customer(SererName, DatabaseName);
            dt = DC.getTable();

            if (dt != null)
            {
                DGV_Customer.DataSource = dt;
                DGV_Customer.RowHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
