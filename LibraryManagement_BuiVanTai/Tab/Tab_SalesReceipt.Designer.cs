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
            this.DGV_SaleReceipt_Left = new System.Windows.Forms.DataGridView();
            this.ReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_SaleReceipt_Total = new System.Windows.Forms.Label();
            this.DGV_SaleReceipt_Right = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Panel_ImportReceipt_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_Right)).BeginInit();
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
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale Receipt";
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
            this.splitContainer1.Panel1.Controls.Add(this.Panel_ImportReceipt_Right);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.DGV_SaleReceipt_Right);
            this.splitContainer1.Size = new System.Drawing.Size(902, 603);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 22;
            // 
            // Panel_ImportReceipt_Right
            // 
            this.Panel_ImportReceipt_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ImportReceipt_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.Panel_ImportReceipt_Right.Controls.Add(this.DGV_SaleReceipt_Left);
            this.Panel_ImportReceipt_Right.Controls.Add(this.panel2);
            this.Panel_ImportReceipt_Right.Controls.Add(this.label8);
            this.Panel_ImportReceipt_Right.Controls.Add(this.LB_SaleReceipt_Total);
            this.Panel_ImportReceipt_Right.Location = new System.Drawing.Point(3, 3);
            this.Panel_ImportReceipt_Right.Name = "Panel_ImportReceipt_Right";
            this.Panel_ImportReceipt_Right.Size = new System.Drawing.Size(394, 597);
            this.Panel_ImportReceipt_Right.TabIndex = 23;
            // 
            // DGV_SaleReceipt_Left
            // 
            this.DGV_SaleReceipt_Left.AllowUserToAddRows = false;
            this.DGV_SaleReceipt_Left.AllowUserToDeleteRows = false;
            this.DGV_SaleReceipt_Left.AllowUserToResizeColumns = false;
            this.DGV_SaleReceipt_Left.AllowUserToResizeRows = false;
            this.DGV_SaleReceipt_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SaleReceipt_Left.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SaleReceipt_Left.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SaleReceipt_Left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_SaleReceipt_Left.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_Left.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_SaleReceipt_Left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_SaleReceipt_Left.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceiptID,
            this.ImportDate,
            this.SaleDate,
            this.ActionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SaleReceipt_Left.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_SaleReceipt_Left.EnableHeadersVisualStyles = false;
            this.DGV_SaleReceipt_Left.Location = new System.Drawing.Point(3, 58);
            this.DGV_SaleReceipt_Left.MultiSelect = false;
            this.DGV_SaleReceipt_Left.Name = "DGV_SaleReceipt_Left";
            this.DGV_SaleReceipt_Left.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_Left.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_SaleReceipt_Left.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_SaleReceipt_Left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleReceipt_Left.ShowCellErrors = false;
            this.DGV_SaleReceipt_Left.ShowCellToolTips = false;
            this.DGV_SaleReceipt_Left.ShowEditingIcon = false;
            this.DGV_SaleReceipt_Left.ShowRowErrors = false;
            this.DGV_SaleReceipt_Left.Size = new System.Drawing.Size(388, 388);
            this.DGV_SaleReceipt_Left.TabIndex = 40;
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
            // ImportDate
            // 
            this.ImportDate.DataPropertyName = "StaffName";
            this.ImportDate.FillWeight = 81.32249F;
            this.ImportDate.HeaderText = "Staff Name";
            this.ImportDate.MinimumWidth = 2;
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(90, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Shopee Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(83, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 38);
            this.label8.TabIndex = 38;
            this.label8.Text = "Sale Receipt Detail";
            // 
            // LB_SaleReceipt_Total
            // 
            this.LB_SaleReceipt_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_SaleReceipt_Total.AutoSize = true;
            this.LB_SaleReceipt_Total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SaleReceipt_Total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LB_SaleReceipt_Total.Location = new System.Drawing.Point(6, 449);
            this.LB_SaleReceipt_Total.Name = "LB_SaleReceipt_Total";
            this.LB_SaleReceipt_Total.Size = new System.Drawing.Size(43, 17);
            this.LB_SaleReceipt_Total.TabIndex = 37;
            this.LB_SaleReceipt_Total.Text = "Total:";
            // 
            // DGV_SaleReceipt_Right
            // 
            this.DGV_SaleReceipt_Right.AllowUserToAddRows = false;
            this.DGV_SaleReceipt_Right.AllowUserToDeleteRows = false;
            this.DGV_SaleReceipt_Right.AllowUserToResizeColumns = false;
            this.DGV_SaleReceipt_Right.AllowUserToResizeRows = false;
            this.DGV_SaleReceipt_Right.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SaleReceipt_Right.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SaleReceipt_Right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_SaleReceipt_Right.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_Right.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_SaleReceipt_Right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_SaleReceipt_Right.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SaleReceipt_Right.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_SaleReceipt_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SaleReceipt_Right.EnableHeadersVisualStyles = false;
            this.DGV_SaleReceipt_Right.Location = new System.Drawing.Point(0, 0);
            this.DGV_SaleReceipt_Right.MultiSelect = false;
            this.DGV_SaleReceipt_Right.Name = "DGV_SaleReceipt_Right";
            this.DGV_SaleReceipt_Right.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SaleReceipt_Right.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_SaleReceipt_Right.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_SaleReceipt_Right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleReceipt_Right.ShowCellErrors = false;
            this.DGV_SaleReceipt_Right.ShowCellToolTips = false;
            this.DGV_SaleReceipt_Right.ShowEditingIcon = false;
            this.DGV_SaleReceipt_Right.ShowRowErrors = false;
            this.DGV_SaleReceipt_Right.Size = new System.Drawing.Size(498, 603);
            this.DGV_SaleReceipt_Right.TabIndex = 40;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ImportAmount";
            this.dataGridViewTextBoxColumn2.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PublisherID";
            this.dataGridViewTextBoxColumn4.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.FillWeight = 81.32249F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Tab_SalesReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(902, 651);
            this.Name = "Tab_SalesReceipt";
            this.Size = new System.Drawing.Size(902, 651);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Suppliers_Menu)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Panel_ImportReceipt_Right.ResumeLayout(false);
            this.Panel_ImportReceipt_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleReceipt_Right)).EndInit();
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
        private System.Windows.Forms.DataGridView DGV_SaleReceipt_Right;
        private System.Windows.Forms.DataGridView DGV_SaleReceipt_Left;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewImageColumn ActionColumn;
    }
}
