namespace LibraryManagement_BuiVanTai.ImportReceiptDetails
{
    partial class Form_ImportReceiptDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTN_SeachBook_Reset = new System.Windows.Forms.Button();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SupplierName = new System.Windows.Forms.TextBox();
            this.TB_BookName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CBB_SupplierID = new System.Windows.Forms.ComboBox();
            this.CBB_BookID = new System.Windows.Forms.ComboBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.SupplierID = new System.Windows.Forms.Label();
            this.TB_ImportAmount = new System.Windows.Forms.TextBox();
            this.ImportAmount = new System.Windows.Forms.Label();
            this.LBBook = new System.Windows.Forms.Label();
            this.ImportID = new System.Windows.Forms.Label();
            this.TB_ImportID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 313);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.Controls.Add(this.BTN_SeachBook_Reset);
            this.panel5.Controls.Add(this.BTN_Submit);
            this.panel5.Location = new System.Drawing.Point(600, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(105, 214);
            this.panel5.TabIndex = 43;
            // 
            // BTN_SeachBook_Reset
            // 
            this.BTN_SeachBook_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_SeachBook_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.BTN_SeachBook_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SeachBook_Reset.ForeColor = System.Drawing.Color.White;
            this.BTN_SeachBook_Reset.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Reset;
            this.BTN_SeachBook_Reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_SeachBook_Reset.Location = new System.Drawing.Point(20, 94);
            this.BTN_SeachBook_Reset.Name = "BTN_SeachBook_Reset";
            this.BTN_SeachBook_Reset.Size = new System.Drawing.Size(66, 58);
            this.BTN_SeachBook_Reset.TabIndex = 33;
            this.BTN_SeachBook_Reset.Text = "Reset";
            this.BTN_SeachBook_Reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_SeachBook_Reset.UseVisualStyleBackColor = false;
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(86)))));
            this.BTN_Submit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.ForeColor = System.Drawing.Color.White;
            this.BTN_Submit.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Wallet1;
            this.BTN_Submit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Submit.Location = new System.Drawing.Point(20, 30);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(66, 58);
            this.BTN_Submit.TabIndex = 32;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_SeachBook_Pay_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TB_SupplierName);
            this.panel3.Controls.Add(this.TB_BookName);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.CBB_SupplierID);
            this.panel3.Controls.Add(this.CBB_BookID);
            this.panel3.Controls.Add(this.TB_Price);
            this.panel3.Controls.Add(this.Price);
            this.panel3.Controls.Add(this.SupplierID);
            this.panel3.Controls.Add(this.TB_ImportAmount);
            this.panel3.Controls.Add(this.ImportAmount);
            this.panel3.Controls.Add(this.LBBook);
            this.panel3.Controls.Add(this.ImportID);
            this.panel3.Controls.Add(this.TB_ImportID);
            this.panel3.Location = new System.Drawing.Point(19, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 214);
            this.panel3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Supplier Name";
            // 
            // TB_SupplierName
            // 
            this.TB_SupplierName.Enabled = false;
            this.TB_SupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SupplierName.Location = new System.Drawing.Point(389, 127);
            this.TB_SupplierName.Name = "TB_SupplierName";
            this.TB_SupplierName.Size = new System.Drawing.Size(169, 25);
            this.TB_SupplierName.TabIndex = 16;
            // 
            // TB_BookName
            // 
            this.TB_BookName.Enabled = false;
            this.TB_BookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BookName.Location = new System.Drawing.Point(389, 50);
            this.TB_BookName.Name = "TB_BookName";
            this.TB_BookName.Size = new System.Drawing.Size(169, 25);
            this.TB_BookName.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(121, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 177);
            this.panel4.TabIndex = 14;
            // 
            // CBB_SupplierID
            // 
            this.CBB_SupplierID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_SupplierID.FormattingEnabled = true;
            this.CBB_SupplierID.Location = new System.Drawing.Point(132, 127);
            this.CBB_SupplierID.Name = "CBB_SupplierID";
            this.CBB_SupplierID.Size = new System.Drawing.Size(224, 25);
            this.CBB_SupplierID.TabIndex = 13;
            this.CBB_SupplierID.SelectedIndexChanged += new System.EventHandler(this.CBB_SupplierName_SelectedIndexChanged);
            // 
            // CBB_BookID
            // 
            this.CBB_BookID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_BookID.FormattingEnabled = true;
            this.CBB_BookID.Location = new System.Drawing.Point(132, 50);
            this.CBB_BookID.Name = "CBB_BookID";
            this.CBB_BookID.Size = new System.Drawing.Size(224, 25);
            this.CBB_BookID.TabIndex = 12;
            this.CBB_BookID.SelectedIndexChanged += new System.EventHandler(this.CBB_BookName_SelectedIndexChanged);
            // 
            // TB_Price
            // 
            this.TB_Price.Enabled = false;
            this.TB_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Price.Location = new System.Drawing.Point(132, 168);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(224, 25);
            this.TB_Price.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(15, 171);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(37, 17);
            this.Price.TabIndex = 10;
            this.Price.Text = "Price";
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSize = true;
            this.SupplierID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierID.Location = new System.Drawing.Point(15, 130);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(74, 17);
            this.SupplierID.TabIndex = 8;
            this.SupplierID.Text = "Supplier ID";
            // 
            // TB_ImportAmount
            // 
            this.TB_ImportAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ImportAmount.Location = new System.Drawing.Point(132, 87);
            this.TB_ImportAmount.Name = "TB_ImportAmount";
            this.TB_ImportAmount.Size = new System.Drawing.Size(224, 25);
            this.TB_ImportAmount.TabIndex = 7;
            // 
            // ImportAmount
            // 
            this.ImportAmount.AutoSize = true;
            this.ImportAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportAmount.Location = new System.Drawing.Point(15, 90);
            this.ImportAmount.Name = "ImportAmount";
            this.ImportAmount.Size = new System.Drawing.Size(100, 17);
            this.ImportAmount.TabIndex = 6;
            this.ImportAmount.Text = "ImportAmount";
            // 
            // LBBook
            // 
            this.LBBook.AutoSize = true;
            this.LBBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBook.Location = new System.Drawing.Point(16, 53);
            this.LBBook.Name = "LBBook";
            this.LBBook.Size = new System.Drawing.Size(56, 17);
            this.LBBook.TabIndex = 4;
            this.LBBook.Text = "Book ID";
            // 
            // ImportID
            // 
            this.ImportID.AutoSize = true;
            this.ImportID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportID.Location = new System.Drawing.Point(15, 19);
            this.ImportID.Name = "ImportID";
            this.ImportID.Size = new System.Drawing.Size(63, 17);
            this.ImportID.TabIndex = 3;
            this.ImportID.Text = "ImportID";
            // 
            // TB_ImportID
            // 
            this.TB_ImportID.Enabled = false;
            this.TB_ImportID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ImportID.Location = new System.Drawing.Point(132, 16);
            this.TB_ImportID.Name = "TB_ImportID";
            this.TB_ImportID.Size = new System.Drawing.Size(224, 25);
            this.TB_ImportID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(105, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 1);
            this.panel2.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Shopee Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(276, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 38);
            this.label8.TabIndex = 40;
            this.label8.Text = "Receipt Details";
            // 
            // Form_ImportReceiptDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(743, 337);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(576, 376);
            this.Name = "Form_ImportReceiptDetails";
            this.Text = "ImportReceiptDetails";
            this.Load += new System.EventHandler(this.Form_ImportReceiptDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TB_ImportID;
        private System.Windows.Forms.Label SupplierID;
        private System.Windows.Forms.TextBox TB_ImportAmount;
        private System.Windows.Forms.Label ImportAmount;
        private System.Windows.Forms.Label LBBook;
        private System.Windows.Forms.Label ImportID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CBB_SupplierID;
        private System.Windows.Forms.ComboBox CBB_BookID;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Button BTN_SeachBook_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SupplierName;
        private System.Windows.Forms.TextBox TB_BookName;
        private System.Windows.Forms.Label label2;
    }
}