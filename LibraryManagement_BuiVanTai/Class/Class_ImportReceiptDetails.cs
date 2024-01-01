using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    internal class Class_ImportReceiptDetails
    {
        private string ImportID;
        private string BookID;
        private string ImportAmount;
        private string SupplierID;
        private decimal Price;


        public string ImportID1 { get => ImportID; set => ImportID = value; }
        public string BookID1 { get => BookID; set => BookID = value; }
        public string ImportAmount1 { get => ImportAmount; set => ImportAmount = value; }
        public string SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public decimal Price1 { get => Price; set => Price = value; }

        public Class_ImportReceiptDetails() { }

        public Class_ImportReceiptDetails(string importID, string bookID, string importAmount, string supplierID, decimal price)
        {
            ImportID = importID;
            BookID = bookID;
            ImportAmount = importAmount;
            SupplierID = supplierID;
            Price = price;
        }
    }
}
