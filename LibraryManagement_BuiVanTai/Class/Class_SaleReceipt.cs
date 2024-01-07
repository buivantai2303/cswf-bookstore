using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_SaleReceipt
    {
        public string ReceiptID { get; set; }
        public string StaffID { get; set; }
        public DateTime SaleDate { get; set; }
        public Class_SaleReceipt(string receiptID) 
        {
            ReceiptID = receiptID;
        }
        public Class_SaleReceipt(string receiptID, string staffID, DateTime saleDate) 
        {
            ReceiptID = receiptID;
            StaffID = staffID;
            SaleDate = saleDate;
        }  
    }
}
