﻿namespace LibraryManagement_BuiVanTai.Tab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelDateNow = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label_TimeNow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Books = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Books_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Books_Search = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Suppliers_1 = new System.Windows.Forms.Label();
            this.LB_Books_Total = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TB_Books_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBB_Books_AuthorName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBB_Books_PublisherName = new System.Windows.Forms.ComboBox();
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
            this.ActionColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PTB_Suppliers_Menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Books_Save = new System.Windows.Forms.Button();
            this.BTN_Books_Add = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LabelDateNow);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.Label_TimeNow);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.DGV_Books);
            this.panel4.Controls.Add(this.BTN_Books_Refresh);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TB_Books_Search);
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.MinimumSize = new System.Drawing.Size(902, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 471);
            this.panel4.TabIndex = 8;
            // 
            // LabelDateNow
            // 
            this.LabelDateNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDateNow.AutoSize = true;
            this.LabelDateNow.Location = new System.Drawing.Point(49, 450);
            this.LabelDateNow.Name = "LabelDateNow";
            this.LabelDateNow.Size = new System.Drawing.Size(21, 13);
            this.LabelDateNow.TabIndex = 12;
            this.LabelDateNow.Text = "{?}";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date:";
            // 
            // Label_TimeNow
            // 
            this.Label_TimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TimeNow.AutoSize = true;
            this.Label_TimeNow.Location = new System.Drawing.Point(638, 450);
            this.Label_TimeNow.Name = "Label_TimeNow";
            this.Label_TimeNow.Size = new System.Drawing.Size(21, 13);
            this.Label_TimeNow.TabIndex = 10;
            this.Label_TimeNow.Text = "{?}";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time now:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Remaining,
            this.BookType,
            this.PublisherName,
            this.AuthorName,
            this.ActionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Books.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Books.EnableHeadersVisualStyles = false;
            this.DGV_Books.Location = new System.Drawing.Point(18, 84);
            this.DGV_Books.MultiSelect = false;
            this.DGV_Books.Name = "DGV_Books";
            this.DGV_Books.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Books.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Books.ShowCellErrors = false;
            this.DGV_Books.ShowCellToolTips = false;
            this.DGV_Books.ShowEditingIcon = false;
            this.DGV_Books.ShowRowErrors = false;
            this.DGV_Books.Size = new System.Drawing.Size(881, 359);
            this.DGV_Books.TabIndex = 8;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.FillWeight = 89.54315F;
            this.BookID.HeaderText = "Book ID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.FillWeight = 89.54315F;
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Remaining
            // 
            this.Remaining.DataPropertyName = "Remaining";
            this.Remaining.FillWeight = 89.54315F;
            this.Remaining.HeaderText = "Remaining";
            this.Remaining.Name = "Remaining";
            this.Remaining.ReadOnly = true;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.FillWeight = 89.54315F;
            this.BookType.HeaderText = "BookType";
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.FillWeight = 89.54315F;
            this.PublisherName.HeaderText = "Publisher Name";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // BTN_Books_Refresh
            // 
            this.BTN_Books_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.BTN_Books_Refresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Books_Refresh.ForeColor = System.Drawing.Color.White;
            this.BTN_Books_Refresh.Location = new System.Drawing.Point(432, 37);
            this.BTN_Books_Refresh.Name = "BTN_Books_Refresh";
            this.BTN_Books_Refresh.Size = new System.Drawing.Size(118, 35);
            this.BTN_Books_Refresh.TabIndex = 7;
            this.BTN_Books_Refresh.Text = "Refresh";
            this.BTN_Books_Refresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Suppliers Name:";
            // 
            // TB_Books_Search
            // 
            this.TB_Books_Search.BackColor = System.Drawing.Color.White;
            this.TB_Books_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Search.Location = new System.Drawing.Point(18, 42);
            this.TB_Books_Search.Name = "TB_Books_Search";
            this.TB_Books_Search.Size = new System.Drawing.Size(382, 25);
            this.TB_Books_Search.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
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
            this.panel1.MaximumSize = new System.Drawing.Size(0, 48);
            this.panel1.MinimumSize = new System.Drawing.Size(902, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 48);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books";
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
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.MaximumSize = new System.Drawing.Size(227, 120);
            this.panel2.MinimumSize = new System.Drawing.Size(227, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 120);
            this.panel2.TabIndex = 6;
            // 
            // Label_Suppliers_1
            // 
            this.Label_Suppliers_1.AutoSize = true;
            this.Label_Suppliers_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Suppliers_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Suppliers_1.Location = new System.Drawing.Point(15, 53);
            this.Label_Suppliers_1.Name = "Label_Suppliers_1";
            this.Label_Suppliers_1.Size = new System.Drawing.Size(84, 17);
            this.Label_Suppliers_1.TabIndex = 2;
            this.Label_Suppliers_1.Text = "Total books:";
            // 
            // LB_Books_Total
            // 
            this.LB_Books_Total.AutoSize = true;
            this.LB_Books_Total.Font = new System.Drawing.Font("Shopee Display ExtBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Books_Total.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_Books_Total.Location = new System.Drawing.Point(10, 9);
            this.LB_Books_Total.Name = "LB_Books_Total";
            this.LB_Books_Total.Size = new System.Drawing.Size(75, 44);
            this.LB_Books_Total.TabIndex = 1;
            this.LB_Books_Total.Text = "8888";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.TB_Books_Price);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.CBB_Books_AuthorName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.BTN_Books_Save);
            this.panel3.Controls.Add(this.CBB_Books_PublisherName);
            this.panel3.Controls.Add(this.BTN_Books_Add);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.TB_Books_Type);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TB_Books_Remaining);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TB_Books_Name);
            this.panel3.Controls.Add(this.Label_SupplierName);
            this.panel3.Controls.Add(this.TB_Books_ID);
            this.panel3.Controls.Add(this.Label_SupplierID);
            this.panel3.Location = new System.Drawing.Point(233, 54);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 120);
            this.panel3.MinimumSize = new System.Drawing.Size(669, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 120);
            this.panel3.TabIndex = 7;
            // 
            // TB_Books_Price
            // 
            this.TB_Books_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Books_Price.BackColor = System.Drawing.Color.White;
            this.TB_Books_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Price.Location = new System.Drawing.Point(508, 84);
            this.TB_Books_Price.Name = "TB_Books_Price";
            this.TB_Books_Price.Size = new System.Drawing.Size(146, 25);
            this.TB_Books_Price.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(508, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Book Price:";
            // 
            // CBB_Books_AuthorName
            // 
            this.CBB_Books_AuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBB_Books_AuthorName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Books_AuthorName.FormattingEnabled = true;
            this.CBB_Books_AuthorName.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CBB_Books_AuthorName.Location = new System.Drawing.Point(364, 84);
            this.CBB_Books_AuthorName.MaximumSize = new System.Drawing.Size(120, 0);
            this.CBB_Books_AuthorName.MinimumSize = new System.Drawing.Size(120, 0);
            this.CBB_Books_AuthorName.Name = "CBB_Books_AuthorName";
            this.CBB_Books_AuthorName.Size = new System.Drawing.Size(120, 25);
            this.CBB_Books_AuthorName.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Author Name:";
            // 
            // CBB_Books_PublisherName
            // 
            this.CBB_Books_PublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBB_Books_PublisherName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Books_PublisherName.FormattingEnabled = true;
            this.CBB_Books_PublisherName.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CBB_Books_PublisherName.Location = new System.Drawing.Point(364, 28);
            this.CBB_Books_PublisherName.MaximumSize = new System.Drawing.Size(120, 0);
            this.CBB_Books_PublisherName.MinimumSize = new System.Drawing.Size(120, 0);
            this.CBB_Books_PublisherName.Name = "CBB_Books_PublisherName";
            this.CBB_Books_PublisherName.Size = new System.Drawing.Size(120, 25);
            this.CBB_Books_PublisherName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Publisher Name:";
            // 
            // TB_Books_Type
            // 
            this.TB_Books_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Books_Type.BackColor = System.Drawing.Color.White;
            this.TB_Books_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Type.Location = new System.Drawing.Point(199, 84);
            this.TB_Books_Type.MaximumSize = new System.Drawing.Size(146, 25);
            this.TB_Books_Type.MinimumSize = new System.Drawing.Size(146, 25);
            this.TB_Books_Type.Name = "TB_Books_Type";
            this.TB_Books_Type.Size = new System.Drawing.Size(146, 25);
            this.TB_Books_Type.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "BookType:";
            // 
            // TB_Books_Remaining
            // 
            this.TB_Books_Remaining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Books_Remaining.BackColor = System.Drawing.Color.White;
            this.TB_Books_Remaining.Enabled = false;
            this.TB_Books_Remaining.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Books_Remaining.Location = new System.Drawing.Point(199, 28);
            this.TB_Books_Remaining.MaximumSize = new System.Drawing.Size(146, 25);
            this.TB_Books_Remaining.MinimumSize = new System.Drawing.Size(146, 25);
            this.TB_Books_Remaining.Name = "TB_Books_Remaining";
            this.TB_Books_Remaining.Size = new System.Drawing.Size(146, 25);
            this.TB_Books_Remaining.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
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
            this.TB_Books_Name.Location = new System.Drawing.Point(15, 84);
            this.TB_Books_Name.MaximumSize = new System.Drawing.Size(168, 25);
            this.TB_Books_Name.MinimumSize = new System.Drawing.Size(168, 25);
            this.TB_Books_Name.Name = "TB_Books_Name";
            this.TB_Books_Name.Size = new System.Drawing.Size(168, 25);
            this.TB_Books_Name.TabIndex = 11;
            // 
            // Label_SupplierName
            // 
            this.Label_SupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SupplierName.AutoSize = true;
            this.Label_SupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SupplierName.Location = new System.Drawing.Point(15, 64);
            this.Label_SupplierName.Name = "Label_SupplierName";
            this.Label_SupplierName.Size = new System.Drawing.Size(79, 17);
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
            this.TB_Books_ID.Location = new System.Drawing.Point(15, 28);
            this.TB_Books_ID.MaximumSize = new System.Drawing.Size(168, 25);
            this.TB_Books_ID.MinimumSize = new System.Drawing.Size(168, 25);
            this.TB_Books_ID.Name = "TB_Books_ID";
            this.TB_Books_ID.Size = new System.Drawing.Size(168, 25);
            this.TB_Books_ID.TabIndex = 9;
            // 
            // Label_SupplierID
            // 
            this.Label_SupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SupplierID.AutoSize = true;
            this.Label_SupplierID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SupplierID.Location = new System.Drawing.Point(15, 7);
            this.Label_SupplierID.Name = "Label_SupplierID";
            this.Label_SupplierID.Size = new System.Drawing.Size(61, 17);
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
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 66;
            // 
            // ActionColumn
            // 
            this.ActionColumn.Description = "Details";
            this.ActionColumn.FillWeight = 40F;
            this.ActionColumn.HeaderText = "Action";
            this.ActionColumn.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Delete;
            this.ActionColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            this.ActionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PTB_Suppliers_Menu
            // 
            this.PTB_Suppliers_Menu.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Menu;
            this.PTB_Suppliers_Menu.Location = new System.Drawing.Point(12, 12);
            this.PTB_Suppliers_Menu.Name = "PTB_Suppliers_Menu";
            this.PTB_Suppliers_Menu.Size = new System.Drawing.Size(26, 26);
            this.PTB_Suppliers_Menu.TabIndex = 0;
            this.PTB_Suppliers_Menu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Book_50;
            this.pictureBox1.Location = new System.Drawing.Point(157, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Books_Save
            // 
            this.BTN_Books_Save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Books_Save.BackColor = System.Drawing.Color.SeaShell;
            this.BTN_Books_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Books_Save.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Save2;
            this.BTN_Books_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Books_Save.Location = new System.Drawing.Point(579, 7);
            this.BTN_Books_Save.Name = "BTN_Books_Save";
            this.BTN_Books_Save.Size = new System.Drawing.Size(65, 48);
            this.BTN_Books_Save.TabIndex = 17;
            this.BTN_Books_Save.Text = "Save";
            this.BTN_Books_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Books_Save.UseVisualStyleBackColor = false;
            // 
            // BTN_Books_Add
            // 
            this.BTN_Books_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Books_Add.BackColor = System.Drawing.Color.SeaShell;
            this.BTN_Books_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Books_Add.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Add;
            this.BTN_Books_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Books_Add.Location = new System.Drawing.Point(508, 7);
            this.BTN_Books_Add.Name = "BTN_Books_Add";
            this.BTN_Books_Add.Size = new System.Drawing.Size(65, 48);
            this.BTN_Books_Add.TabIndex = 18;
            this.BTN_Books_Add.Text = "Add";
            this.BTN_Books_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Books_Add.UseVisualStyleBackColor = false;
            // 
            // Tab_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(902, 651);
            this.Name = "Tab_Book";
            this.Size = new System.Drawing.Size(902, 651);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelDateNow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label_TimeNow;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ComboBox CBB_Books_PublisherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Books_Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Books_Remaining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Books_Name;
        private System.Windows.Forms.Label Label_SupplierName;
        private System.Windows.Forms.TextBox TB_Books_ID;
        private System.Windows.Forms.Label Label_SupplierID;
        private System.Windows.Forms.TextBox TB_Books_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBB_Books_AuthorName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewImageColumn ActionColumn;
    }
}
