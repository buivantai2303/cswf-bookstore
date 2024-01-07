using LibraryManagement_BuiVanTai.Tab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement_BuiVanTai
{
    public partial class Form_Main : Form
    {
        public string name = "{?}";
        private Color originalButtonColor;


        // Main ======================================================================================= - Change by Tai 
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            tab_SearchBooks.BringToFront();

        }


        // Move UI to other panel by buttons. - Change by Tai 
        private void MovePanel(Control BTN)
        {
            MovePanelForBTN.Top = BTN.Top;
            MovePanelForBTN.Height = BTN.Height;
        }


        // ============================================================================================ - Change by Tai 
        // When we clicked other Button old button resot to old color 
        private void ResetButtonColors()
        {
            Button_Main_SeachBooks.BackColor = originalButtonColor;
            Button_Main_Authors.BackColor = originalButtonColor;
            Button_Main_Suppliers.BackColor = originalButtonColor;
            Button_Main_Customer.BackColor = originalButtonColor;
            Button_Main_SaleReceipt.BackColor = originalButtonColor;
            Button_Main_ImportReceipt.BackColor = originalButtonColor;
            Button_Main_Staff.BackColor = originalButtonColor;
            Button_Main_Books.BackColor = originalButtonColor;
            Button_Main_Publisher.BackColor = originalButtonColor;
        }


        // Search Book Click ========================================================================== - Change by Tai 
        private void btn_SeachBooks_Click(object sender, EventArgs e)
        {
            // Change color when clicked
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(Button_Main_SeachBooks);
            Button_Main_SeachBooks.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = true;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;

        }


        // Authors Click ============================================================================== - Changed by Tai 
        private void btn_Authors_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(Button_Main_Authors);
            Button_Main_Authors.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = true;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;

        }


        // Customer Click ============================================================================= - Changed by Tai 
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(Button_Main_Customer);
            Button_Main_Customer.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = true;
            tab_Authors.Visible = false;
            tab_Publisher.Visible = false;
            tab_Suppliers.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;

        }


        // Suppliers Click ============================================================================ - Changed by Tai 
        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(Button_Main_Suppliers);
            Button_Main_Suppliers.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = true;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;

        }


        // Sale Receipt Click ========================================================================= - Changed by Tai 
        private void btn_SaleReceipt_Click(object sender, EventArgs e)
        {


            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(Button_Main_SaleReceipt);
            Button_Main_SaleReceipt.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = true;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;

        }


        // Impoer Receipt Click ======================================================================= - Changed by Tai 
        private void btn_ImportReceipt_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(Button_Main_ImportReceipt);
            Button_Main_ImportReceipt.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = true;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;

        }


        // Staff Click ================================================================================ - Changed by Tai 
        private void btn_Staff_Click(object sender, EventArgs e)
        {

            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(Button_Main_Staff);
            Button_Main_Staff.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = true;
            tab_Book1.Visible = false;

        }




        // Sign out button ============================================================================ - Changed by Tai 
        private void btn_SignOut_Click(object sender, EventArgs e)
        {

        }

        private void Button_Main_Books_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(Button_Main_Books);
            Button_Main_Books.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = true;
        }

        private void Button_Main_Publisher_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = Button_Main_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(Button_Main_Publisher);
            Button_Main_Publisher.BackColor = Color.FromArgb(0, 67, 147);

            tab_SearchBooks.Visible = false;
            tab_Customers.Visible = false;
            tab_Authors.Visible = false;
            tab_Suppliers.Visible = false;
            tab_Publisher.Visible = true;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
            tab_Book1.Visible = false;
        }
    }
}
