namespace LibraryManagement_BuiVanTai.Tab
{
    partial class Tab_Book
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGV_Books = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BTN_Books_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Books_Search = new System.Windows.Forms.TextBox();
            this.BTN_Books_Save = new System.Windows.Forms.Button();
            this.BTN_Books_Add = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PTB_Suppliers_Menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Suppliers_1 = new System.Windows.Forms.Label();
            this.LB_Books_Total = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TB_Books_AuthorName = new System.Windows.Forms.TextBox();
            this.TB_Books_PublisherName = new System.Windows.Forms.TextBox();
            this.TB_Books_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBB_Books_AuthorID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBB_Books_PublisherID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Books_Type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Books_Remaining = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Books_Name = new System.Windows.Forms.TextBox();
            this.Label_SupplierName = new System.Windows.Forms.Label();
            this.TB_Books_ID = new System.Windows.Forms.TextBox();
            this.Label_SupplierID = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.DGV_Books);
            this.panel4.Controls.Add(this.BTN_Books_Refresh);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TB_Books_Search);
            this.panel4.Controls.Add(this.BTN_Books_Save);
            this.panel4.Controls.Add(this.BTN_Books_Add);
            this.panel4.Location = new System.Drawing.Point(0, 222);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.MinimumSize = new System.Drawing.Size(1203, 580);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1203, 580);
            this.panel4.TabIndex = 8;
            // 
            // DGV_Books
            // 
            this.DGV_Books.AllowUserToAddRows = false;
            this.DGV_Books.AllowUserToDeleteRows = false;
            this.DGV_Books.AllowUserToResizeColumns = false;
            this.DGV_Books.AllowUserToResizeRows = false;
            this.DGV_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Books.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Books.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_Books.ColumnHeadersHeight = 29;
            this.DGV_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Remaining,
            this.BookType,
            this.PublisherID,
            this.AuthorID,
            this.Price,
            this.ActionColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Books.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_Books.EnableHeadersVisualStyles = false;
            this.DGV_Books.Location = new System.Drawing.Point(24, 103);
            this.DGV_Books.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Books.MultiSelect = false;
            this.DGV_Books.Name = "DGV_Books";
            this.DGV_Books.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Books.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_Books.RowHeadersWidth = 51;
            this.DGV_Books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Books.ShowCellErrors = false;
            this.DGV_Books.ShowCellToolTips = false;
            this.DGV_Books.ShowEditingIcon = false;
            this.DGV_Books.ShowRowErrors = false;
            this.DGV_Books.Size = new System.Drawing.Size(1175, 442);
            this.DGV_Books.TabIndex = 8;
            this.DGV_Books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Books_CellClick);
            this.DGV_Books.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Books_CellContentDoubleClick);
            this.DGV_Books.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Books_CellContentDoubleClick);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.FillWeight = 89.54315F;
            this.BookID.HeaderText = "Book ID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.FillWeight = 89.54315F;
            this.BookName.HeaderText = "Book Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Remaining
            // 
            this.Remaining.DataPropertyName = "Remaining";
            this.Remaining.FillWeight = 89.54315F;
            this.Remaining.HeaderText = "Remaining";
            this.Remaining.MinimumWidth = 6;
            this.Remaining.Name = "Remaining";
            this.Remaining.ReadOnly = true;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.FillWeight = 89.54315F;
            this.BookType.HeaderText = "BookType";
            this.BookType.MinimumWidth = 6;
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            // 
            // PublisherID
            // 
            this.PublisherID.DataPropertyName = "PublisherID";
            this.PublisherID.FillWeight = 89.54315F;
            this.PublisherID.HeaderText = "PublisherID";
            this.PublisherID.MinimumWidth = 6;
            this.PublisherID.Name = "PublisherID";
            this.PublisherID.ReadOnly = true;
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "AuthorID";
            this.AuthorID.MinimumWidth = 6;
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ActionColumn
            // 
            this.ActionColumn.Description = "Details";
            this.ActionColumn.FillWeight = 40F;
            this.ActionColumn.HeaderText = "Action";
            this.ActionColumn.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Delete;
            this.ActionColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ActionColumn.MinimumWidth = 6;
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            this.ActionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BTN_Books_Refresh
            // 
            this.BTN_Books_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.BTN_Books_Refresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Books_Refresh.ForeColor = System.Drawing.Color.White;
            this.BTN_Books_Refresh.Location = new System.Drawing.Point(576, 46);
            this.BTN_Books_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Books_Refresh.Name = "BTN_Books_Refresh";
            this.BTN_Books_Refresh.Size = new System.Drawing.Size(157, 43);
            this.BTN_Books_Refresh.TabIndex = 7;
            this.BTN_Books_Refresh.Text = "Refresh";
            this.BTN_Books_Refresh.UseVisualStyleBackColor = false;
            this.BTN_Books_Refresh.Click += new System.EventHandler(this.BTN_Books_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Suppliers Name:";
            // 
            // TB_Books_Search
            // 
            this.TB_Books_Search.BackColor = System.Drawing.Color.White;
            this.TB_Books_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Search.Location = new System.Drawing.Point(24, 52);
            this.TB_Books_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_Search.Name = "TB_Books_Search";
            this.TB_Books_Search.Size = new System.Drawing.Size(508, 29);
            this.TB_Books_Search.TabIndex = 2;
            this.TB_Books_Search.TextChanged += new System.EventHandler(this.TB_Books_Search_TextChanged);
            // 
            // BTN_Books_Save
            // 
            this.BTN_Books_Save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Books_Save.BackColor = System.Drawing.Color.SeaShell;
            this.BTN_Books_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Books_Save.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Save2;
            this.BTN_Books_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Books_Save.Location = new System.Drawing.Point(938, 22);
            this.BTN_Books_Save.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Books_Save.Name = "BTN_Books_Save";
            this.BTN_Books_Save.Size = new System.Drawing.Size(87, 59);
            this.BTN_Books_Save.TabIndex = 17;
            this.BTN_Books_Save.Text = "Save";
            this.BTN_Books_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Books_Save.UseVisualStyleBackColor = false;
            this.BTN_Books_Save.Click += new System.EventHandler(this.BTN_Books_Save_Click);
            // 
            // BTN_Books_Add
            // 
            this.BTN_Books_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Books_Add.BackColor = System.Drawing.Color.SeaShell;
            this.BTN_Books_Add.Enabled = false;
            this.BTN_Books_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Books_Add.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Add;
            this.BTN_Books_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Books_Add.Location = new System.Drawing.Point(812, 22);
            this.BTN_Books_Add.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Books_Add.Name = "BTN_Books_Add";
            this.BTN_Books_Add.Size = new System.Drawing.Size(87, 59);
            this.BTN_Books_Add.TabIndex = 18;
            this.BTN_Books_Add.Text = "Add";
            this.BTN_Books_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Books_Add.UseVisualStyleBackColor = false;
            this.BTN_Books_Add.Click += new System.EventHandler(this.BTN_Books_Add_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PTB_Suppliers_Menu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 59);
            this.panel1.MinimumSize = new System.Drawing.Size(1203, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 59);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books";
            // 
            // PTB_Suppliers_Menu
            // 
            this.PTB_Suppliers_Menu.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Menu;
            this.PTB_Suppliers_Menu.Location = new System.Drawing.Point(16, 15);
            this.PTB_Suppliers_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.PTB_Suppliers_Menu.Name = "PTB_Suppliers_Menu";
            this.PTB_Suppliers_Menu.Size = new System.Drawing.Size(35, 32);
            this.PTB_Suppliers_Menu.TabIndex = 0;
            this.PTB_Suppliers_Menu.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Label_Suppliers_1);
            this.panel2.Controls.Add(this.LB_Books_Total);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.MaximumSize = new System.Drawing.Size(303, 148);
            this.panel2.MinimumSize = new System.Drawing.Size(303, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 148);
            this.panel2.TabIndex = 6;
            // 
            // Label_Suppliers_1
            // 
            this.Label_Suppliers_1.AutoSize = true;
            this.Label_Suppliers_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Suppliers_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Suppliers_1.Location = new System.Drawing.Point(20, 65);
            this.Label_Suppliers_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Suppliers_1.Name = "Label_Suppliers_1";
            this.Label_Suppliers_1.Size = new System.Drawing.Size(107, 23);
            this.Label_Suppliers_1.TabIndex = 2;
            this.Label_Suppliers_1.Text = "Total books:";
            // 
            // LB_Books_Total
            // 
            this.LB_Books_Total.AutoSize = true;
            this.LB_Books_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Books_Total.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_Books_Total.Location = new System.Drawing.Point(13, 11);
            this.LB_Books_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Books_Total.Name = "LB_Books_Total";
            this.LB_Books_Total.Size = new System.Drawing.Size(97, 39);
            this.LB_Books_Total.TabIndex = 1;
            this.LB_Books_Total.Text = "8888";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Book_50;
            this.pictureBox1.Location = new System.Drawing.Point(209, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.TB_Books_AuthorName);
            this.panel3.Controls.Add(this.TB_Books_PublisherName);
            this.panel3.Controls.Add(this.TB_Books_Price);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.CBB_Books_AuthorID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.CBB_Books_PublisherID);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.TB_Books_Type);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TB_Books_Remaining);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TB_Books_Name);
            this.panel3.Controls.Add(this.Label_SupplierName);
            this.panel3.Controls.Add(this.TB_Books_ID);
            this.panel3.Controls.Add(this.Label_SupplierID);
            this.panel3.Location = new System.Drawing.Point(311, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 148);
            this.panel3.MinimumSize = new System.Drawing.Size(892, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 148);
            this.panel3.TabIndex = 7;
            // 
            // TB_Books_AuthorName
            // 
            this.TB_Books_AuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Books_AuthorName.BackColor = System.Drawing.Color.White;
            this.TB_Books_AuthorName.Enabled = false;
            this.TB_Books_AuthorName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_AuthorName.Location = new System.Drawing.Point(652, 103);
            this.TB_Books_AuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_AuthorName.Name = "TB_Books_AuthorName";
            this.TB_Books_AuthorName.Size = new System.Drawing.Size(114, 29);
            this.TB_Books_AuthorName.TabIndex = 24;
            // 
            // TB_Books_PublisherName
            // 
            this.TB_Books_PublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Books_PublisherName.BackColor = System.Drawing.Color.White;
            this.TB_Books_PublisherName.Enabled = false;
            this.TB_Books_PublisherName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_PublisherName.Location = new System.Drawing.Point(652, 34);
            this.TB_Books_PublisherName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_PublisherName.Name = "TB_Books_PublisherName";
            this.TB_Books_PublisherName.Size = new System.Drawing.Size(218, 29);
            this.TB_Books_PublisherName.TabIndex = 23;
            // 
            // TB_Books_Price
            // 
            this.TB_Books_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Books_Price.BackColor = System.Drawing.Color.White;
            this.TB_Books_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Price.Location = new System.Drawing.Point(774, 103);
            this.TB_Books_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_Price.Name = "TB_Books_Price";
            this.TB_Books_Price.Size = new System.Drawing.Size(96, 29);
            this.TB_Books_Price.TabIndex = 22;
            this.TB_Books_Price.TextChanged += new System.EventHandler(this.TB_Books_Price_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(770, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Book Price:";
            // 
            // CBB_Books_AuthorID
            // 
            this.CBB_Books_AuthorID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBB_Books_AuthorID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Books_AuthorID.FormattingEnabled = true;
            this.CBB_Books_AuthorID.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CBB_Books_AuthorID.Location = new System.Drawing.Point(468, 103);
            this.CBB_Books_AuthorID.Margin = new System.Windows.Forms.Padding(4);
            this.CBB_Books_AuthorID.MaximumSize = new System.Drawing.Size(159, 0);
            this.CBB_Books_AuthorID.MinimumSize = new System.Drawing.Size(159, 0);
            this.CBB_Books_AuthorID.Name = "CBB_Books_AuthorID";
            this.CBB_Books_AuthorID.Size = new System.Drawing.Size(159, 29);
            this.CBB_Books_AuthorID.TabIndex = 19;
            this.CBB_Books_AuthorID.SelectedIndexChanged += new System.EventHandler(this.CBB_Books_AuthorID_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Author ID";
            // 
            // CBB_Books_PublisherID
            // 
            this.CBB_Books_PublisherID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBB_Books_PublisherID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Books_PublisherID.FormattingEnabled = true;
            this.CBB_Books_PublisherID.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CBB_Books_PublisherID.Location = new System.Drawing.Point(468, 34);
            this.CBB_Books_PublisherID.Margin = new System.Windows.Forms.Padding(4);
            this.CBB_Books_PublisherID.MaximumSize = new System.Drawing.Size(159, 0);
            this.CBB_Books_PublisherID.MinimumSize = new System.Drawing.Size(159, 0);
            this.CBB_Books_PublisherID.Name = "CBB_Books_PublisherID";
            this.CBB_Books_PublisherID.Size = new System.Drawing.Size(159, 29);
            this.CBB_Books_PublisherID.TabIndex = 13;
            this.CBB_Books_PublisherID.SelectedIndexChanged += new System.EventHandler(this.CBB_Books_PublisherName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Publisher ID";
            // 
            // TB_Books_Type
            // 
            this.TB_Books_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Books_Type.BackColor = System.Drawing.Color.White;
            this.TB_Books_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Type.Location = new System.Drawing.Point(257, 105);
            this.TB_Books_Type.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_Type.MaximumSize = new System.Drawing.Size(193, 25);
            this.TB_Books_Type.MinimumSize = new System.Drawing.Size(193, 25);
            this.TB_Books_Type.Name = "TB_Books_Type";
            this.TB_Books_Type.Size = new System.Drawing.Size(193, 29);
            this.TB_Books_Type.TabIndex = 15;
            this.TB_Books_Type.TextChanged += new System.EventHandler(this.TB_Books_Type_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "BookType:";
            // 
            // TB_Books_Remaining
            // 
            this.TB_Books_Remaining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Books_Remaining.BackColor = System.Drawing.Color.White;
            this.TB_Books_Remaining.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Remaining.Location = new System.Drawing.Point(257, 36);
            this.TB_Books_Remaining.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_Remaining.MaximumSize = new System.Drawing.Size(193, 25);
            this.TB_Books_Remaining.MinimumSize = new System.Drawing.Size(193, 25);
            this.TB_Books_Remaining.Name = "TB_Books_Remaining";
            this.TB_Books_Remaining.Size = new System.Drawing.Size(193, 29);
            this.TB_Books_Remaining.TabIndex = 13;
            this.TB_Books_Remaining.TextChanged += new System.EventHandler(this.TB_Books_Remaining_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remaining:";
            // 
            // TB_Books_Name
            // 
            this.TB_Books_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Books_Name.BackColor = System.Drawing.Color.White;
            this.TB_Books_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Name.Location = new System.Drawing.Point(20, 103);
            this.TB_Books_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_Name.MaximumSize = new System.Drawing.Size(223, 25);
            this.TB_Books_Name.MinimumSize = new System.Drawing.Size(223, 25);
            this.TB_Books_Name.Name = "TB_Books_Name";
            this.TB_Books_Name.Size = new System.Drawing.Size(223, 29);
            this.TB_Books_Name.TabIndex = 11;
            this.TB_Books_Name.TextChanged += new System.EventHandler(this.TB_Books_Name_TextChanged);
            // 
            // Label_SupplierName
            // 
            this.Label_SupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SupplierName.AutoSize = true;
            this.Label_SupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SupplierName.Location = new System.Drawing.Point(20, 79);
            this.Label_SupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SupplierName.Name = "Label_SupplierName";
            this.Label_SupplierName.Size = new System.Drawing.Size(103, 23);
            this.Label_SupplierName.TabIndex = 10;
            this.Label_SupplierName.Text = "BookName:";
            // 
            // TB_Books_ID
            // 
            this.TB_Books_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Books_ID.BackColor = System.Drawing.Color.White;
            this.TB_Books_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_ID.Location = new System.Drawing.Point(20, 34);
            this.TB_Books_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Books_ID.MaximumSize = new System.Drawing.Size(223, 25);
            this.TB_Books_ID.MinimumSize = new System.Drawing.Size(223, 25);
            this.TB_Books_ID.Name = "TB_Books_ID";
            this.TB_Books_ID.Size = new System.Drawing.Size(223, 29);
            this.TB_Books_ID.TabIndex = 9;
            this.TB_Books_ID.TextChanged += new System.EventHandler(this.TB_Books_ID_TextChanged);
            // 
            // Label_SupplierID
            // 
            this.Label_SupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SupplierID.AutoSize = true;
            this.Label_SupplierID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SupplierID.Location = new System.Drawing.Point(20, 9);
            this.Label_SupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SupplierID.Name = "Label_SupplierID";
            this.Label_SupplierID.Size = new System.Drawing.Size(79, 23);
            this.Label_SupplierID.TabIndex = 0;
            this.Label_SupplierID.Text = "Book ID:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Details";
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 66;
            // 
            // Tab_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1203, 801);
            this.Name = "Tab_Book";
            this.Size = new System.Drawing.Size(1203, 801);
            this.Load += new System.EventHandler(this.Tab_Book_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DGV_Books;
        private System.Windows.Forms.Button BTN_Books_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Books_Search;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BTN_Books_Save;
        private System.Windows.Forms.Button BTN_Books_Add;
        private System.Windows.Forms.PictureBox PTB_Suppliers_Menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_Suppliers_1;
        private System.Windows.Forms.Label LB_Books_Total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CBB_Books_PublisherID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Books_Remaining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Books_Name;
        private System.Windows.Forms.Label Label_SupplierName;
        private System.Windows.Forms.TextBox TB_Books_ID;
        private System.Windows.Forms.Label Label_SupplierID;
        private System.Windows.Forms.TextBox TB_Books_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBB_Books_AuthorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Books_PublisherName;
        private System.Windows.Forms.TextBox TB_Books_AuthorName;
        private System.Windows.Forms.TextBox TB_Books_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn ActionColumn;
    }
}
