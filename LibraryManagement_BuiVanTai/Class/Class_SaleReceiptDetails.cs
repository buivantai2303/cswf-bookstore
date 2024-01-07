using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_SaleReceiptDetails
    {
        public string ReceiptID { get; set; }
        public string BookID { get; set; }
        public int SaleNumber { get; set; }
        public string CustomerID {  get; set; }
        public int Price { get; set; }
        public Class_SaleReceiptDetails(string receiptID) 
        {
            ReceiptID = receiptID;
        }
        public Class_SaleReceiptDetails(string receiptID, string bookId, int saleNumber, string customerID, int price) 
        {
            ReceiptID = receiptID;
            BookID = bookId;
            SaleNumber = saleNumber;
            CustomerID = customerID;
            Price = price;
        }
    }
}
