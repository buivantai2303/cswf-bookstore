namespace LibraryManagement_BuiVanTai.Tab
{
    partial class Tab_SalesReceipt
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
            this.Panel_ImportReceipt_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ImportReceipt_Search = new System.Windows.Forms.TextBox();
            this.DGV_SaleReceipt_ImportReceipt = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.DGV_SaleReceipt_ReciptDetails = new System.Windows.Forms.DataGridView();
            this.LB_SaleReceipt_Total = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Panel_ImportReceipt_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_ImportReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_ReciptDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PTB_Suppliers_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 59);
            this.panel1.MinimumSize = new System.Drawing.Size(1203, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 59);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale Receipt";
            // 
            // PTB_Suppliers_Menu
            // 
            this.PTB_Suppliers_Menu.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Menu;
            this.PTB_Suppliers_Menu.Location = new System.Drawing.Point(16, 15);
            this.PTB_Suppliers_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PTB_Suppliers_Menu.Name = "PTB_Suppliers_Menu";
            this.PTB_Suppliers_Menu.Size = new System.Drawing.Size(35, 32);
            this.PTB_Suppliers_Menu.TabIndex = 0;
            this.PTB_Suppliers_Menu.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Panel_ImportReceipt_Right);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.DGV_SaleReceipt_ReciptDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1203, 742);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 22;
            // 
            // Panel_ImportReceipt_Right
            // 
            this.Panel_ImportReceipt_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ImportReceipt_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.Panel_ImportReceipt_Right.Controls.Add(this.BTN_Refresh);
            this.Panel_ImportReceipt_Right.Controls.Add(this.label2);
            this.Panel_ImportReceipt_Right.Controls.Add(this.LB_SaleReceipt_Total);
            this.Panel_ImportReceipt_Right.Controls.Add(this.TB_ImportReceipt_Search);
            this.Panel_ImportReceipt_Right.Controls.Add(this.DGV_SaleReceipt_ImportReceipt);
            this.Panel_ImportReceipt_Right.Controls.Add(this.panel2);
            this.Panel_ImportReceipt_Right.Controls.Add(this.label8);
            this.Panel_ImportReceipt_Right.Location = new System.Drawing.Point(4, 4);
            this.Panel_ImportReceipt_Right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_ImportReceipt_Right.Name = "Panel_ImportReceipt_Right";
            this.Panel_ImportReceipt_Right.Size = new System.Drawing.Size(525, 735);
            this.Panel_ImportReceipt_Right.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Search Sale date:";
            // 
            // TB_ImportReceipt_Search
            // 
            this.TB_ImportReceipt_Search.BackColor = System.Drawing.Color.White;
            this.TB_ImportReceipt_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ImportReceipt_Search.Location = new System.Drawing.Point(12, 111);
            this.TB_ImportReceipt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_ImportReceipt_Search.Name = "TB_ImportReceipt_Search";
            this.TB_ImportReceipt_Search.Size = new System.Drawing.Size(240, 29);
            this.TB_ImportReceipt_Search.TabIndex = 41;
            // 
            // DGV_SaleReceipt_ImportReceipt
            // 
            this.DGV_SaleReceipt_ImportReceipt.AllowUserToAddRows = false;
            this.DGV_SaleReceipt_ImportReceipt.AllowUserToDeleteRows = false;
            this.DGV_SaleReceipt_ImportReceipt.AllowUserToResizeColumns = false;
            this.DGV_SaleReceipt_ImportReceipt.AllowUserToResizeRows = false;
            this.DGV_SaleReceipt_ImportReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SaleReceipt_ImportReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SaleReceipt_ImportReceipt.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SaleReceipt_ImportReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_SaleReceipt_ImportReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_ImportReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_SaleReceipt_ImportReceipt.ColumnHeadersHeight = 29;
            this.DGV_SaleReceipt_ImportReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_SaleReceipt_ImportReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceiptID,
            this.StaffID,
            this.SaleDate,
            this.ActionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SaleReceipt_ImportReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_SaleReceipt_ImportReceipt.EnableHeadersVisualStyles = false;
            this.DGV_SaleReceipt_ImportReceipt.Location = new System.Drawing.Point(4, 150);
            this.DGV_SaleReceipt_ImportReceipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_SaleReceipt_ImportReceipt.MultiSelect = false;
            this.DGV_SaleReceipt_ImportReceipt.Name = "DGV_SaleReceipt_ImportReceipt";
            this.DGV_SaleReceipt_ImportReceipt.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_ImportReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_SaleReceipt_ImportReceipt.RowHeadersWidth = 51;
            this.DGV_SaleReceipt_ImportReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_SaleReceipt_ImportReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleReceipt_ImportReceipt.ShowCellErrors = false;
            this.DGV_SaleReceipt_ImportReceipt.ShowCellToolTips = false;
            this.DGV_SaleReceipt_ImportReceipt.ShowEditingIcon = false;
            this.DGV_SaleReceipt_ImportReceipt.ShowRowErrors = false;
            this.DGV_SaleReceipt_ImportReceipt.Size = new System.Drawing.Size(517, 478);
            this.DGV_SaleReceipt_ImportReceipt.TabIndex = 40;
            this.DGV_SaleReceipt_ImportReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SaleReceipt_ImportReceipt_CellClick);
            this.DGV_SaleReceipt_ImportReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SaleReceipt_ImportReceipt_CellContentClick);
            this.DGV_SaleReceipt_ImportReceipt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SaleReceipt_ImportReceipt_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(120, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 1);
            this.panel2.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(111, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 36);
            this.label8.TabIndex = 38;
            this.label8.Text = "Sale Receipt Detail";
            // 
            // DGV_SaleReceipt_ReciptDetails
            // 
            this.DGV_SaleReceipt_ReciptDetails.AllowUserToAddRows = false;
            this.DGV_SaleReceipt_ReciptDetails.AllowUserToDeleteRows = false;
            this.DGV_SaleReceipt_ReciptDetails.AllowUserToResizeColumns = false;
            this.DGV_SaleReceipt_ReciptDetails.AllowUserToResizeRows = false;
            this.DGV_SaleReceipt_ReciptDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SaleReceipt_ReciptDetails.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SaleReceipt_ReciptDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_SaleReceipt_ReciptDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_ReciptDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_SaleReceipt_ReciptDetails.ColumnHeadersHeight = 29;
            this.DGV_SaleReceipt_ReciptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_SaleReceipt_ReciptDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CustomerID,
            this.Price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SaleReceipt_ReciptDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_SaleReceipt_ReciptDetails.EnableHeadersVisualStyles = false;
            this.DGV_SaleReceipt_ReciptDetails.Location = new System.Drawing.Point(0, 0);
            this.DGV_SaleReceipt_ReciptDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_SaleReceipt_ReciptDetails.MultiSelect = false;
            this.DGV_SaleReceipt_ReciptDetails.Name = "DGV_SaleReceipt_ReciptDetails";
            this.DGV_SaleReceipt_ReciptDetails.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_ReciptDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_SaleReceipt_ReciptDetails.RowHeadersWidth = 51;
            this.DGV_SaleReceipt_ReciptDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_SaleReceipt_ReciptDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleReceipt_ReciptDetails.ShowCellErrors = false;
            this.DGV_SaleReceipt_ReciptDetails.ShowCellToolTips = false;
            this.DGV_SaleReceipt_ReciptDetails.ShowEditingIcon = false;
            this.DGV_SaleReceipt_ReciptDetails.ShowRowErrors = false;
            this.DGV_SaleReceipt_ReciptDetails.Size = new System.Drawing.Size(664, 686);
            this.DGV_SaleReceipt_ReciptDetails.TabIndex = 40;
            // 
            // LB_SaleReceipt_Total
            // 
            this.LB_SaleReceipt_Total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LB_SaleReceipt_Total.AutoSize = true;
            this.LB_SaleReceipt_Total.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SaleReceipt_Total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LB_SaleReceipt_Total.Location = new System.Drawing.Point(78, 671);
            this.LB_SaleReceipt_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_SaleReceipt_Total.Name = "LB_SaleReceipt_Total";
            this.LB_SaleReceipt_Total.Size = new System.Drawing.Size(77, 32);
            this.LB_SaleReceipt_Total.TabIndex = 37;
            this.LB_SaleReceipt_Total.Text = "Total:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn1.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SaleNumber";
            this.dataGridViewTextBoxColumn2.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.FillWeight = 81.32249F;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 2;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
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
            // ReceiptID
            // 
            this.ReceiptID.DataPropertyName = "ReceiptID";
            this.ReceiptID.FillWeight = 81.32249F;
            this.ReceiptID.HeaderText = "Receipt ID";
            this.ReceiptID.MinimumWidth = 2;
            this.ReceiptID.Name = "ReceiptID";
            this.ReceiptID.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.FillWeight = 81.32249F;
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.MinimumWidth = 2;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.FillWeight = 81.32249F;
            this.SaleDate.HeaderText = "Sale Date";
            this.SaleDate.MinimumWidth = 2;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // ActionColumn
            // 
            this.ActionColumn.FillWeight = 36.32773F;
            this.ActionColumn.HeaderText = "Delete";
            this.ActionColumn.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Delete1;
            this.ActionColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ActionColumn.MinimumWidth = 59;
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            this.ActionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.BTN_Refresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.ForeColor = System.Drawing.Color.White;
            this.BTN_Refresh.Location = new System.Drawing.Point(285, 111);
            this.BTN_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(157, 36);
            this.BTN_Refresh.TabIndex = 43;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = false;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // Tab_SalesReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1203, 801);
            this.Name = "Tab_SalesReceipt";
            this.Size = new System.Drawing.Size(1203, 801);
            this.Load += new System.EventHandler(this.Tab_SalesReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Panel_ImportReceipt_Right.ResumeLayout(false);
            this.Panel_ImportReceipt_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_ImportReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_ReciptDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PTB_Suppliers_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Panel_ImportReceipt_Right;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_SaleReceipt_Total;
        private System.Windows.Forms.DataGridView DGV_SaleReceipt_ReciptDetails;
        private System.Windows.Forms.DataGridView DGV_SaleReceipt_ImportReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_ImportReceipt_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewImageColumn ActionColumn;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}
