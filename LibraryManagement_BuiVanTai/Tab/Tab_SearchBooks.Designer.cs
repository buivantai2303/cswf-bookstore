﻿namespace LibraryManagement_BuiVanTai.Tab
{
    partial class Tab_SearchBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PTB_Suppliers_Menu = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_SearchBook_Left = new System.Windows.Forms.DataGridView();
            this.ImportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.TB_SearchBook_Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LB_SearchBook_Total = new System.Windows.Forms.Label();
            this.BTN_SeachBook_Reset = new System.Windows.Forms.Button();
            this.DGV_SearchBook_Right = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_SeachBook_Pay = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SearchBook_Left)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SearchBook_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PTB_Suppliers_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 48);
            this.panel1.MinimumSize = new System.Drawing.Size(902, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 48);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Book";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.DGV_SearchBook_Left);
            this.splitContainer1.Panel1.Controls.Add(this.TB_SearchBook_Search);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(902, 603);
            this.splitContainer1.SplitterDistance = 456;
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search Book Name:";
            // 
            // DGV_SearchBook_Left
            // 
            this.DGV_SearchBook_Left.AllowUserToAddRows = false;
            this.DGV_SearchBook_Left.AllowUserToDeleteRows = false;
            this.DGV_SearchBook_Left.AllowUserToResizeColumns = false;
            this.DGV_SearchBook_Left.AllowUserToResizeRows = false;
            this.DGV_SearchBook_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SearchBook_Left.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SearchBook_Left.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SearchBook_Left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_SearchBook_Left.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SearchBook_Left.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_SearchBook_Left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_SearchBook_Left.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImportID,
            this.ImportDate,
            this.BookType,
            this.Price,
            this.ActionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SearchBook_Left.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_SearchBook_Left.EnableHeadersVisualStyles = false;
            this.DGV_SearchBook_Left.Location = new System.Drawing.Point(0, 215);
            this.DGV_SearchBook_Left.MultiSelect = false;
            this.DGV_SearchBook_Left.Name = "DGV_SearchBook_Left";
            this.DGV_SearchBook_Left.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SearchBook_Left.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_SearchBook_Left.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_SearchBook_Left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SearchBook_Left.ShowCellErrors = false;
            this.DGV_SearchBook_Left.ShowCellToolTips = false;
            this.DGV_SearchBook_Left.ShowEditingIcon = false;
            this.DGV_SearchBook_Left.ShowRowErrors = false;
            this.DGV_SearchBook_Left.Size = new System.Drawing.Size(453, 388);
            this.DGV_SearchBook_Left.TabIndex = 25;
            // 
            // ImportID
            // 
            this.ImportID.DataPropertyName = "BookID";
            this.ImportID.FillWeight = 81.32249F;
            this.ImportID.HeaderText = "Book ID";
            this.ImportID.MinimumWidth = 2;
            this.ImportID.Name = "ImportID";
            this.ImportID.ReadOnly = true;
            // 
            // ImportDate
            // 
            this.ImportDate.DataPropertyName = "BookName";
            this.ImportDate.FillWeight = 81.32249F;
            this.ImportDate.HeaderText = "Book Name";
            this.ImportDate.MinimumWidth = 2;
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.ReadOnly = true;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.FillWeight = 81.32249F;
            this.BookType.HeaderText = "Book Type";
            this.BookType.MinimumWidth = 2;
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 81.32249F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 2;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ActionColumn
            // 
            this.ActionColumn.FillWeight = 36.32773F;
            this.ActionColumn.HeaderText = "Add";
            this.ActionColumn.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Add_20;
            this.ActionColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ActionColumn.MinimumWidth = 59;
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            this.ActionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TB_SearchBook_Search
            // 
            this.TB_SearchBook_Search.Location = new System.Drawing.Point(12, 189);
            this.TB_SearchBook_Search.Name = "TB_SearchBook_Search";
            this.TB_SearchBook_Search.Size = new System.Drawing.Size(158, 20);
            this.TB_SearchBook_Search.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 134);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "THE CYBERBOOK STORE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.BTN_SeachBook_Reset);
            this.panel3.Controls.Add(this.DGV_SearchBook_Right);
            this.panel3.Controls.Add(this.BTN_SeachBook_Pay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 603);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LB_SearchBook_Total);
            this.panel4.Location = new System.Drawing.Point(200, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 58);
            this.panel4.TabIndex = 32;
            // 
            // LB_SearchBook_Total
            // 
            this.LB_SearchBook_Total.AutoSize = true;
            this.LB_SearchBook_Total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SearchBook_Total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LB_SearchBook_Total.Location = new System.Drawing.Point(3, 17);
            this.LB_SearchBook_Total.Name = "LB_SearchBook_Total";
            this.LB_SearchBook_Total.Size = new System.Drawing.Size(43, 17);
            this.LB_SearchBook_Total.TabIndex = 28;
            this.LB_SearchBook_Total.Text = "Total:";
            // 
            // BTN_SeachBook_Reset
            // 
            this.BTN_SeachBook_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_SeachBook_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.BTN_SeachBook_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SeachBook_Reset.ForeColor = System.Drawing.Color.White;
            this.BTN_SeachBook_Reset.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Reset;
            this.BTN_SeachBook_Reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_SeachBook_Reset.Location = new System.Drawing.Point(18, 333);
            this.BTN_SeachBook_Reset.Name = "BTN_SeachBook_Reset";
            this.BTN_SeachBook_Reset.Size = new System.Drawing.Size(66, 58);
            this.BTN_SeachBook_Reset.TabIndex = 31;
            this.BTN_SeachBook_Reset.Text = "Reset";
            this.BTN_SeachBook_Reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_SeachBook_Reset.UseVisualStyleBackColor = false;
            // 
            // DGV_SearchBook_Right
            // 
            this.DGV_SearchBook_Right.AllowUserToAddRows = false;
            this.DGV_SearchBook_Right.AllowUserToDeleteRows = false;
            this.DGV_SearchBook_Right.AllowUserToResizeColumns = false;
            this.DGV_SearchBook_Right.AllowUserToResizeRows = false;
            this.DGV_SearchBook_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SearchBook_Right.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SearchBook_Right.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SearchBook_Right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_SearchBook_Right.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SearchBook_Right.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_SearchBook_Right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_SearchBook_Right.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SearchBook_Right.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_SearchBook_Right.EnableHeadersVisualStyles = false;
            this.DGV_SearchBook_Right.Location = new System.Drawing.Point(0, 0);
            this.DGV_SearchBook_Right.MultiSelect = false;
            this.DGV_SearchBook_Right.Name = "DGV_SearchBook_Right";
            this.DGV_SearchBook_Right.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SearchBook_Right.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_SearchBook_Right.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_SearchBook_Right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SearchBook_Right.ShowCellErrors = false;
            this.DGV_SearchBook_Right.ShowCellToolTips = false;
            this.DGV_SearchBook_Right.ShowEditingIcon = false;
            this.DGV_SearchBook_Right.ShowRowErrors = false;
            this.DGV_SearchBook_Right.Size = new System.Drawing.Size(442, 318);
            this.DGV_SearchBook_Right.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn2.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BookType";
            this.dataGridViewTextBoxColumn3.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Book Type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // BTN_SeachBook_Pay
            // 
            this.BTN_SeachBook_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_SeachBook_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(86)))));
            this.BTN_SeachBook_Pay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SeachBook_Pay.ForeColor = System.Drawing.Color.White;
            this.BTN_SeachBook_Pay.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Wallet1;
            this.BTN_SeachBook_Pay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_SeachBook_Pay.Location = new System.Drawing.Point(90, 333);
            this.BTN_SeachBook_Pay.Name = "BTN_SeachBook_Pay";
            this.BTN_SeachBook_Pay.Size = new System.Drawing.Size(66, 58);
            this.BTN_SeachBook_Pay.TabIndex = 29;
            this.BTN_SeachBook_Pay.Text = "Pay";
            this.BTN_SeachBook_Pay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_SeachBook_Pay.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 36.32773F;
            this.dataGridViewImageColumn1.HeaderText = "Add";
            this.dataGridViewImageColumn1.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Add_20;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 59;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 64;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 36.32773F;
            this.dataGridViewImageColumn2.HeaderText = "Action";
            this.dataGridViewImageColumn2.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 59;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 65;
            // 
            // Tab_SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(902, 651);
            this.Name = "Tab_SearchBooks";
            this.Size = new System.Drawing.Size(902, 651);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SearchBook_Left)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SearchBook_Right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PTB_Suppliers_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_SearchBook_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGV_SearchBook_Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_SeachBook_Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn ActionColumn;
        private System.Windows.Forms.DataGridView DGV_SearchBook_Right;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BTN_SeachBook_Reset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LB_SearchBook_Total;
    }
}
