namespace LibraryManagement_BuiVanTai
{
    partial class Form_Main
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MovePanelForBTN = new System.Windows.Forms.Panel();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ImportReceipt = new System.Windows.Forms.Button();
            this.btn_SaleReceipt = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Authors = new System.Windows.Forms.Button();
            this.btn_SeachBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.btn_Customer);
            this.panel2.Controls.Add(this.MovePanelForBTN);
            this.panel2.Controls.Add(this.btn_Suppliers);
            this.panel2.Controls.Add(this.btn_SignOut);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_ImportReceipt);
            this.panel2.Controls.Add(this.btn_SaleReceipt);
            this.panel2.Controls.Add(this.btn_Staff);
            this.panel2.Controls.Add(this.btn_Authors);
            this.panel2.Controls.Add(this.btn_SeachBooks);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.MinimumSize = new System.Drawing.Size(162, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 659);
            this.panel2.TabIndex = 1;
            // 
            // MovePanelForBTN
            // 
            this.MovePanelForBTN.BackColor = System.Drawing.Color.White;
            this.MovePanelForBTN.Location = new System.Drawing.Point(3, 250);
            this.MovePanelForBTN.Name = "MovePanelForBTN";
            this.MovePanelForBTN.Size = new System.Drawing.Size(5, 41);
            this.MovePanelForBTN.TabIndex = 10;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suppliers.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.White;
            this.btn_Suppliers.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Supplier1;
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(3, 395);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(156, 43);
            this.btn_Suppliers.TabIndex = 9;
            this.btn_Suppliers.Text = "  Suppliers";
            this.btn_Suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Suppliers.UseVisualStyleBackColor = true;
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Logout2;
            this.btn_SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.Location = new System.Drawing.Point(34, 617);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(89, 32);
            this.btn_SignOut.TabIndex = 8;
            this.btn_SignOut.Text = "Sign out";
            this.btn_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.User_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(43, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome, user!";
            // 
            // btn_ImportReceipt
            // 
            this.btn_ImportReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_ImportReceipt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_ImportReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportReceipt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_ImportReceipt.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Receipt_and_Change;
            this.btn_ImportReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImportReceipt.Location = new System.Drawing.Point(3, 493);
            this.btn_ImportReceipt.Name = "btn_ImportReceipt";
            this.btn_ImportReceipt.Size = new System.Drawing.Size(156, 43);
            this.btn_ImportReceipt.TabIndex = 5;
            this.btn_ImportReceipt.Text = "  Import Receipt";
            this.btn_ImportReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImportReceipt.UseVisualStyleBackColor = false;
            this.btn_ImportReceipt.Click += new System.EventHandler(this.btn_ImportReceipt_Click);
            // 
            // btn_SaleReceipt
            // 
            this.btn_SaleReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_SaleReceipt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_SaleReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaleReceipt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_SaleReceipt.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Receipt_and_Change;
            this.btn_SaleReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaleReceipt.Location = new System.Drawing.Point(3, 444);
            this.btn_SaleReceipt.Name = "btn_SaleReceipt";
            this.btn_SaleReceipt.Size = new System.Drawing.Size(156, 43);
            this.btn_SaleReceipt.TabIndex = 3;
            this.btn_SaleReceipt.Text = "  Sales Reciept";
            this.btn_SaleReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaleReceipt.UseVisualStyleBackColor = false;
            this.btn_SaleReceipt.Click += new System.EventHandler(this.btn_SaleReceipt_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_Staff.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Staff;
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Staff.Location = new System.Drawing.Point(3, 542);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(156, 43);
            this.btn_Staff.TabIndex = 2;
            this.btn_Staff.Text = "  Staffs";
            this.btn_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Authors
            // 
            this.btn_Authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_Authors.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Authors.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Authors.ForeColor = System.Drawing.Color.White;
            this.btn_Authors.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Author;
            this.btn_Authors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Authors.Location = new System.Drawing.Point(3, 346);
            this.btn_Authors.Name = "btn_Authors";
            this.btn_Authors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Authors.Size = new System.Drawing.Size(156, 43);
            this.btn_Authors.TabIndex = 1;
            this.btn_Authors.Text = "  Authors";
            this.btn_Authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Authors.UseVisualStyleBackColor = false;
            this.btn_Authors.Click += new System.EventHandler(this.btn_Authors_Click);
            // 
            // btn_SeachBooks
            // 
            this.btn_SeachBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_SeachBooks.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_SeachBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeachBooks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeachBooks.ForeColor = System.Drawing.Color.White;
            this.btn_SeachBooks.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Search_2;
            this.btn_SeachBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SeachBooks.Location = new System.Drawing.Point(3, 249);
            this.btn_SeachBooks.Name = "btn_SeachBooks";
            this.btn_SeachBooks.Size = new System.Drawing.Size(156, 43);
            this.btn_SeachBooks.TabIndex = 0;
            this.btn_SeachBooks.Text = "  Search Books";
            this.btn_SeachBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeachBooks.UseVisualStyleBackColor = false;
            this.btn_SeachBooks.Click += new System.EventHandler(this.btn_SeachBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.MinimumSize = new System.Drawing.Size(1030, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 45);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-157, -34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 28);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(169, 52);
            this.panel1.MinimumSize = new System.Drawing.Size(902, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 651);
            this.panel1.TabIndex = 0;
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Image = global::LibraryManagement_BuiVanTai.Properties.Resources.Staff;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(3, 297);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(156, 43);
            this.btn_Customer.TabIndex = 11;
            this.btn_Customer.Text = "  Customer";
            this.btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1073, 705);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1089, 744);
            this.MinimumSize = new System.Drawing.Size(1089, 744);
            this.Name = "Form_Main";
            this.Text = "Suppliers";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_SeachBooks;
        private System.Windows.Forms.Button btn_Authors;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_ImportReceipt;
        private System.Windows.Forms.Button btn_SaleReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Panel MovePanelForBTN;
        private System.Windows.Forms.Button btn_Customer;
    }
}

