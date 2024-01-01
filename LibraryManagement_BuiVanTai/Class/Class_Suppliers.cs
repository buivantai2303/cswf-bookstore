using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai
{
    internal class Class_Suppliers
    {
        private string SupplierID;
        private string SupplierName;
        private string SupplierAddress;
        private string SupplierTel;
        private string SupplierState;

        public string SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public string SupplierName1 { get => SupplierName; set => SupplierName = value; }
        public string SupplierAddress1 { get => SupplierAddress; set => SupplierAddress = value; }
        public string SupplierTel1 { get => SupplierTel; set => SupplierTel = value; }
        public string SupplierState1 { get => SupplierState; set => SupplierState = value; }

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
