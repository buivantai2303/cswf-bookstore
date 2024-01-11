using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai
{
    public class Class_Suppliers
    {


        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierTel { get; set; }
        public string SupplierState { get; set; }

        public Class_Suppliers() { }

        public Class_Suppliers(string supplierID)
        {
            SupplierID = supplierID;
        }

        public Class_Suppliers(string supplierName, string supplierState)
        {
            SupplierName = supplierName;
            SupplierState = supplierState;
        }

        public Class_Suppliers(string supplierID, string supplierName, string supplierAddress, string supplierTel, string supplierState)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
            SupplierTel = supplierTel;
            SupplierState = supplierState;
        }
    }
}
