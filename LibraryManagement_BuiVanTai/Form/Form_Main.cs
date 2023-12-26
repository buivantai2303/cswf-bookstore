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
            btn_SeachBooks.BackColor = originalButtonColor;
            btn_Authors.BackColor = originalButtonColor;
            btn_Suppliers.BackColor = originalButtonColor;
            btn_Customer.BackColor = originalButtonColor;
            btn_SaleReceipt.BackColor = originalButtonColor;
            btn_ImportReceipt.BackColor = originalButtonColor;
            btn_Staff.BackColor = originalButtonColor;
        }


        // Search Book Click ========================================================================== - Change by Tai 
        private void btn_SeachBooks_Click(object sender, EventArgs e)
        {
            // Change color when clicked
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(btn_SeachBooks);
            btn_SeachBooks.BackColor = Color.FromArgb(0, 67, 147);

        }


        // Authors Click ============================================================================== - Changed by Tai 
        private void btn_Authors_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(btn_Authors);
            btn_Authors.BackColor = Color.FromArgb(0, 67, 147);
        }


        // Customer Click ============================================================================= - Changed by Tai 
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(btn_Customer);
            btn_Customer.BackColor = Color.FromArgb(0, 67, 147);
        }


        // Suppliers Click ============================================================================ - Changed by Tai 
        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(btn_Suppliers);
            btn_Suppliers.BackColor = Color.FromArgb(0, 67, 147);
        }


        // Sale Receipt Click ========================================================================= - Changed by Tai 
        private void btn_SaleReceipt_Click(object sender, EventArgs e)
        {


            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }

            ResetButtonColors();
            MovePanel(btn_SaleReceipt);
            btn_SaleReceipt.BackColor = Color.FromArgb(0, 67, 147);
        }


        // Impoer Receipt Click ======================================================================= - Changed by Tai 
        private void btn_ImportReceipt_Click(object sender, EventArgs e)
        {
            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(btn_ImportReceipt);
            btn_ImportReceipt.BackColor = Color.FromArgb(0, 67, 147);
        }


        // Staff Click ================================================================================ - Changed by Tai 
        private void btn_Staff_Click(object sender, EventArgs e)
        {

            if (originalButtonColor == default(Color))
            {
                originalButtonColor = btn_SeachBooks.BackColor;
            }
            ResetButtonColors();
            MovePanel(btn_Staff);
            btn_Staff.BackColor = Color.FromArgb(0, 67, 147);
        }


        // Sign out button ============================================================================ - Changed by Tai 
        private void btn_SignOut_Click(object sender, EventArgs e)
        {

        }


    }
}
