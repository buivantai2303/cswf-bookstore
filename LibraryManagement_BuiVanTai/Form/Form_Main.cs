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
            tab_Authors.Visible = true;
            tab_Suppliers.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;

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
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
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
            tab_Suppliers.Visible = false;
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
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
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
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
            tab_SalesReceipt.Visible = true;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = false;
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
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = true;
            tab_Staffs.Visible = false;
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
            tab_SalesReceipt.Visible = false;
            tab_ImportReceipt.Visible = false;
            tab_Staffs.Visible = true;
        }


        // Sign out button ============================================================================ - Changed by Tai 
        private void btn_SignOut_Click(object sender, EventArgs e)
        {

        }


    }
}
