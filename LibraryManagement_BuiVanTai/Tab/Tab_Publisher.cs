using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai.Tab
{
    public partial class Tab_Publisher : UserControl
    {
        Database_Publisher DB_Publisher;
        System.Data.DataTable dataTable_Publisher = null;
        public Tab_Publisher()
        {
            InitializeComponent();
        }

        public void Tab_Publisher_Load(object sender, EventArgs e)
        {
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void GridViewFormLoad(string ServerName, string DatabaseName)
        {
            CBB_Publisher_StateSearch.Text = ClassDefineName.table_Suppliers_SupplierState_AllState;
            DB_Publisher = new Database_Publisher(ServerName, DatabaseName);
            DataTable dt = DB_Publisher.getCustomTable($"SELECT * FROM {ClassDefineName.table_Publishers_TableName}");
            TB_Publisher_ID.Enabled = false;
            CBB_Publisher_StateSearch.DisplayMember = "Active";
            CBB_Publisher_StateEdit.DisplayMember = "Active";


            if (dt != null)
            {
                DGV_Publisher.DataSource = dt;
                DGV_Publisher.RowHeadersVisible = false;

                foreach (DataGridViewColumn column in DGV_Publisher.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getEmptyTextBox()
        {
            CBB_Publisher_StateSearch.Text = "All";
            CBB_Publisher_StateEdit.Text = "";
            TB_Publisher_ID.Text = "";
            TB_Publisher_Name.Text = "";
            TB_Publisher_Tel.Text = "";
            TB_Publisher_Address.Text = "";
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
        }

        public void CheckNull()
        {
            if (TB_Publisher_ID.Text == "" || TB_Publisher_Name.Text == "" || TB_Publisher_Tel.Text == "" || TB_Publisher_Address.Text == "" || CBB_Publisher_StateEdit.Text == "")
            {
                BTN_Publisher_Add.Enabled = false;
                BTN_Publisher_Save.Enabled = false;
            }
            else
            {
                BTN_Publisher_Add.Enabled = true;
                BTN_Publisher_Save.Enabled = true;
            }
        }

        public void TB_Publisher_ID_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
            DataConditional();
        }

        public void TB_Publisher_Firstname_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
            DataConditional();
        }

        public void TB_Publisher_LastName_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
            DataConditional();
        }

        public void TB_Publisher_Tel_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
            DataConditional();
        }

        public void TB_Publisher_Address_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
            DataConditional();
        }

        public void CBB_Publisher_StateEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNull();
            DataConditional();
        }


        public void CBB_Publisher_StateSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_Publisher_StateSearch.Text == "Active")
            {
                TB_Publisher_Search.Clear();
                DB_Publisher = new Database_Publisher(ClassDefineName.servername, ClassDefineName.database_name);
                dataTable_Publisher = DB_Publisher.getActiveTable();
                DGV_Publisher.DataSource = dataTable_Publisher;
                return;

            }
            else if (CBB_Publisher_StateSearch.Text == "Inactive")
            {
                TB_Publisher_Search.Clear();
                DB_Publisher = new Database_Publisher(ClassDefineName.servername, ClassDefineName.database_name);
                dataTable_Publisher = DB_Publisher.getInActiveTable();
                DGV_Publisher.DataSource = dataTable_Publisher;
                return;
            }
            else
            {
                GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                return;
            }
        }

        public void BTN_Publisher_Add_Click(object sender, EventArgs e)
        {
            Class_Publisher publisher = new Class_Publisher(TB_Publisher_ID.Text, TB_Publisher_Name.Text, TB_Publisher_Address.Text, TB_Publisher_Tel.Text, CBB_Publisher_StateEdit.Text);

            // Check condition
            if (DataConditional())
            {
                if (DB_Publisher.IsDuplicatePublisherID(TB_Publisher_ID.Text) > 0)
                {
                    LB_Note.ForeColor = Color.Red;
                    LB_Note.Text = "Duplicate publisher found.\nPlease check the Publisher ID";
                    return;
                }
                else if (DB_Publisher.IsDuplicatePublisherTel(TB_Publisher_Tel.Text) > 0)
                {
                    LB_Note.ForeColor = Color.Red;
                    LB_Note.Text = "Duplicate publisher found.\nPlease check the Publisher telephone";
                    return;
                }
                else if (DB_Publisher.IsDuplicatePublisherName(TB_Publisher_Name.Text) > 0)
                {
                    LB_Note.ForeColor = Color.Red;
                    LB_Note.Text = "Duplicate publisher found.\nPlease check the Publisher name";
                    return;
                }
                else
                {
                    LB_Note.Text = "";
                    DialogResult result = MessageBox.Show("Do you want to add this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (DB_Publisher.InsertData(publisher))
                        {
                            MessageBox.Show("Publisher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getEmptyTextBox();
                            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                    return;
                }
            }
        }

        public bool DataConditional()
        {

            if (TB_Publisher_ID.Text.Length < 3 || TB_Publisher_ID.Text.Length > 20)
            {
                LB_Note.ForeColor = Color.Red;
                LB_Note.Text = "Incorrect Publisher ID\n(around 1 - 20 characters)";
                BTN_Publisher_Add.Enabled = false;
                BTN_Publisher_Save .Enabled = false;
                return false;
            }

            if (TB_Publisher_Name.Text.Length < 1 || TB_Publisher_Name.Text.Length > 200)
            {
                LB_Note.ForeColor = Color.Red;
                LB_Note.Text = "Incorrect publisher name\n(around 1 - 200 characters)";
                BTN_Publisher_Add.Enabled = false;
                BTN_Publisher_Save.Enabled = false;
                return false;
            }

            if (TB_Publisher_Tel.Text.Length < 1 || TB_Publisher_Tel.Text.Length > 11)
            {
                LB_Note.ForeColor = Color.Red;
                LB_Note.Text = "Incorrect telephone number\n(around 1 - 11 numbers)";
                BTN_Publisher_Add.Enabled = false;
                BTN_Publisher_Save.Enabled = false;
                return false;
            }

            if (TB_Publisher_Address.Text.Length < 1 || TB_Publisher_Address.Text.Length > 50)
            {
                LB_Note.ForeColor = Color.Red;
                LB_Note.Text = "Incorrect publisher address ID\n(around 1 - 50 characters)";
                BTN_Publisher_Add.Enabled = false;
                BTN_Publisher_Save.Enabled = false;
                return false;
            }

            if (CBB_Publisher_StateEdit.Text != ClassDefineName.table_Suppliers_SupplierState_Active && CBB_Publisher_StateEdit.Text != ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                LB_Note.ForeColor = Color.Red;
                LB_Note.Text = "Incorrect publisher state ID.\nPlease choose 'Active' or 'Inactive'";
                BTN_Publisher_Add.Enabled = false;
                BTN_Publisher_Save.Enabled = false;
                return false;
            }

            LB_Note.ForeColor = Color.Green;
            LB_Note.Text = "Everything look good!";
            return true;
        }

        public void BTN_Publisher_Save_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            int rowIndex = DGV_Publisher.CurrentCell.RowIndex;

            // Check if a row is selected
            if (rowIndex >= 0)
            {
                DataGridViewRow SelectedRow = DGV_Publisher.Rows[rowIndex];
                Class_Publisher publisher = new Class_Publisher(TB_Publisher_ID.Text, TB_Publisher_Name.Text, TB_Publisher_Address.Text, TB_Publisher_Tel.Text, CBB_Publisher_StateEdit.Text);

                // Get the values from the selected row
                string OldID = SelectedRow.Cells["PublisherID"].Value.ToString();
                string NewID = TB_Publisher_ID.Text;

                if (DataConditional())
                {
                    DialogResult result = MessageBox.Show("Do you want to save ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (OldID != NewID)
                        {
                            LB_Note.ForeColor = Color.Red;
                            LB_Note.Text = "Can't update publisher ID";
                        }
                        else
                        {
                            if (DB_Publisher.UpdatePub(publisher))
                            {
                                LB_Note.ForeColor = Color.Green;
                                LB_Note.Text = "Update successfully!";
                                return;
                            }
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a row before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BTN_Publisher_Save.Enabled = false;
        }

        public void BTN_Publisher_Refresh_Click(object sender, EventArgs e)
        {
            TB_Publisher_Search.Clear();
            GridViewFormLoad(ClassDefineName.servername, ClassDefineName.database_name);
            getEmptyTextBox();
            TB_Publisher_ID.Enabled = false;
            BTN_Publisher_Save.Enabled = false;
            return;
        }

        public void DGV_Publisher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Publisher_Save.Enabled = false;
            TB_Publisher_ID.Enabled = false;

            int index = e.RowIndex;
            TB_Publisher_ID.Enabled = true;
            DataGridViewRow SelectedRow = DGV_Publisher.Rows[index];
            TB_Publisher_ID.Text = SelectedRow.Cells[1].Value.ToString();
            TB_Publisher_Name.Text = SelectedRow.Cells[2].Value.ToString();
            TB_Publisher_Address.Text = SelectedRow.Cells[3].Value.ToString();
            TB_Publisher_Tel.Text = SelectedRow.Cells[4].Value.ToString();
            CBB_Publisher_StateEdit.Text = SelectedRow.Cells[5].Value.ToString();


            Class_Publisher publisher = new Class_Publisher(TB_Publisher_ID.Text);
            if (e.RowIndex >= 0 && DGV_Publisher.Columns[e.ColumnIndex].Name == "ActionColumn")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DB_Publisher.DeletePubByID(publisher) == true)
                    {
                        int rowIndex = DGV_Publisher.CurrentCell.RowIndex;
                        DGV_Publisher.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            BTN_Publisher_Add.Enabled = false;
        }

        public void TB_Publisher_Search_TextChanged(object sender, EventArgs e)
        {
            if (CBB_Publisher_StateSearch.Text == ClassDefineName.table_Suppliers_SupplierState_AllState)
            {
                dataTable_Publisher = DB_Publisher.SearchDataNonState(TB_Publisher_Search.Text);
                DGV_Publisher.DataSource = dataTable_Publisher;
                return;
            }
            else if (CBB_Publisher_StateSearch.Text == ClassDefineName.table_Suppliers_SupplierState_Active)
            {
                dataTable_Publisher = DB_Publisher.SearchDataWithState(TB_Publisher_Search.Text, ClassDefineName.table_Suppliers_SupplierState_Active);
                DGV_Publisher.DataSource = dataTable_Publisher;
                return;
            }
            else if (CBB_Publisher_StateSearch.Text == ClassDefineName.table_Suppliers_SupplierState_Inactive)
            {
                dataTable_Publisher = DB_Publisher.SearchDataWithState(TB_Publisher_Search.Text, ClassDefineName.table_Suppliers_SupplierState_Inactive);
                DGV_Publisher.DataSource = dataTable_Publisher;
                return;
            }
            else
            {
                MessageBox.Show("Invalid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

}
