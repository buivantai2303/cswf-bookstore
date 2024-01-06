using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class ClassDefineName
    {

        // Server name
        public static string servername = "TAGO-MARK2\\TAGOS";

        // Database name
        public static string database_name = "QuanLyCuaHangSach2";

        // Class Table Customers.
        public static string table_Customer_TableName = "Customers";
        public static string table_Customer_CustomerID = "CustomerID";
        public static string table_Customer_FirstName = "FirstName";
        public static string table_Customer_LastName = "LastName";
        public static string table_Customer_Tel = "Tel";
        public static string table_Customer_Address = "Address";

        // Class Table Publishers.
        public static string table_Publishers_TableName = "Publishers";
        public static string table_Publishers_PublisherID = "PublisherID";
        public static string table_Publishers_PublisherName = "PublisherName";
        public static string table_Publishers_PublisherAddress = "PublisherAddress";
        public static string table_Publishers_PublisherTel = "PublisherTel";
        public static string table_Publishers_PublisherState = "PublisherState";

        // Class Table Authors:
        public static string table_Authors_TableName = "Authors";
        public static string table_Authors_AuthorID = "AuthorID";
        public static string table_Authors_AuthorName = "AuthorName";
        public static string table_Authors_AuthorDOB = "AuthorDOB";
        public static string table_Authors_AuthorAddress = "AuthorAddress";
        public static string table_Authors_AuthorEmail = "AuthorEmail";

        // Class Table Staff.
        public static string table_Staffs_TableName = "Staffs";
        public static string table_Staffs_StaffID = "StaffID";
        public static string table_Staffs_StaffName = "StaffName";
        public static string table_Staffs_StaffDOB = "StaffDOB";
        public static string table_Staffs_StaffAddress = "StaffAddress";
        public static string table_Staffs_StaffTell = "StaffTell";

        // Class Table Books.
        public static string table_Books_TableName = "Books";
        public static string table_Books_BookID = "BookID";
        public static string table_Books_BookName = "BookName";
        public static string table_Books_Remaining = "Remaining";
        public static string table_Books_BookType = "BookType";
        public static string table_Books_PublisherID = "PublisherID";
        public static string table_Books_AuthorID = "AuthorID";
        public static string table_Books_Price = "Price";

        // Class Table Suppliers define name.
        public static string table_Suppliers_TableName = "Suppliers";
        public static string table_Suppliers_SupplierID = "SupplierID";
        public static string table_Suppliers_SupplierName = "SupplierName";
        public static string table_Suppliers_SupplierAddress = "SupplierAddress";
        public static string table_Suppliers_SupplierTelephone = "SupplierTel";
        public static string table_Suppliers_SupplierState = "SupplierState";
        public static string table_Suppliers_SupplierState_Active = "Active";
        public static string table_Suppliers_SupplierState_Inactive = "Inactive";
        public static string table_Suppliers_SupplierState_AllState = "All";
        public static string table_Suppliers_SupplierState_OffState = "";
        public static string table_Suppliers_Supplier_ExportFileName = "Suppliers";

        // Class Table Suppliers define name
        public static string table_SaleReceipts_TableName = "SaleReceipts";
        public static string table_SaleReceipts_ReceiptID = "ReceiptID";
        public static string table_SaleReceipts_StaffID = "StaffID";
        public static string table_SaleReceipts_SaleDate = "SaleDate";

        // Class Table ImportReceipt define name
        public static string table_ImportReceipt_TableName = "ImportReceipt";
        public static string table_ImportReceipt_ImportID = "ImportID";
        public static string table_ImportReceipt_ImportDate = "ImportDate";
        public static string table_ImportReceipt_PublisherID = "PublisherID";
        public static string table_ImportReceipt_StaffID = "StaffID";

        // Class Table ImportReceiptDetails name.
        public static string table_ImportReceiptDetails_TableName = "ImportReceiptDetails";
        public static string table_ImportReceiptDetails_ImportID = "ImportID";
        public static string table_ImportReceiptDetails_BookID = "BookID";
        public static string table_ImportReceiptDetails_ImportAmount = "ImportAmount";
        public static string table_ImportReceiptDetails_SupplierID = "Price";



    }
}
