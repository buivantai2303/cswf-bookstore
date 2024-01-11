using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_ImportReceiptDetails
    {

        public string ImportID { get; set; }
        public string BookID { get; set; }
        public int ImportAmount { get; set; }
        public string SupplierID { get; set; }
        public decimal Price { get; set; }

        public Class_ImportReceiptDetails(string importID) {
            ImportID = importID; 
        }

        public Class_ImportReceiptDetails(string importID, string bookID, int importAmount, string supplierID, decimal price)
        {
            ImportID = importID;
            BookID = bookID;
            ImportAmount = importAmount;
            SupplierID = supplierID;
            Price = price;
        }
    }
}
