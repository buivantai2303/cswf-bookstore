using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryManagement_BuiVanTaiTests.Database
{
    [TestClass]
    public class Database_ImportRececiptAndDetails
    {
        // Declare
        Database_ImportReceipt database_ImportReceipt = new Database_ImportReceipt(ClassDefineName.servername, ClassDefineName.database_test);
        Database_ImportReceiptDetails database_ImportReceiptDetails = new Database_ImportReceiptDetails(ClassDefineName.servername, ClassDefineName.database_test);

        // IMPORT RECEIPT: INSERT
        [TestMethod]
        [DataRow("IMPRT0005", "2024-01-1111", "BloomsburyP", "23423523")]
        [DataRow("IMPRT0005", "2024-01-12", "Changjiang", "")]
        [DataRow("IMPRT0007", "2024-01-13", "GlobalBooks", "23423523")]
        [DataRow("IMPRT0008", "2024-01-14", "HDAKCo", "23423523")]
        [DataRow("IMPRT0009", "2024-01-15", "", "23423523")]
        [DataRow("IMPRT0010", "2024-01-16", "PaperTrail", "23423523")]
        public void IMPORT_InsertDataTest(string importID, DateTime Date, string PubID, string staffID)
        {
            Class_ImportReceipt import = new Class_ImportReceipt(importID, Date, PubID, staffID);
            Assert.IsTrue(database_ImportReceipt.InsertData(import));
        }


        // IMPORT RECEIPT DETAILS: INSERT
        [TestMethod()]
        [DataRow("", "B001", 100, "BookHaven", 100)]
        [DataRow("IMPRT0006", "B002", 100, "BookHaven", 100)]
        [DataRow("IMPRT0007", "B003", 100, "BookHaven", 100)]
        [DataRow("IMPRT0008", "B004", 100, "", 100)]
        [DataRow("IMPRT0009", "", 100, "TeamadeVietnam", 100)]
        [DataRow("IMPRT0010", "B006", 100, "TeamadeVietnam", 100)]
        public void IMPORTDETAILS_InsertDataTest(string importID, string BookID, int Amount, string SupllierID, decimal price)
        {
            Class_ImportReceiptDetails importDetails = new Class_ImportReceiptDetails(importID, BookID, Amount, SupllierID, price);
            Assert.IsTrue(database_ImportReceiptDetails.InsertData(importDetails));

        }


        // IMPORT RECEIPT DETAILS DELETE
        [TestMethod()]
        [DataRow("IMPRT0005")]
        [DataRow("IMPRT0006")]
        [DataRow("IMPRT0007")]
        public void IMPORTDETAILS_DeleteDataTest(string importID)
        {
            Class_ImportReceiptDetails deleteDetails = new Class_ImportReceiptDetails(importID);
            Assert.IsTrue(database_ImportReceiptDetails.DeleteData(deleteDetails));
        }


        // IMPORT RECEIPT: DELETE
        [DataRow("IMPRT0005")]
        [DataRow("IMPRT0006")]
        [DataRow("IMPRT0007")]
        [TestMethod]
        public void IMPORT_DeleteDataTest(string importID)
        {
            Class_ImportReceipt import = new Class_ImportReceipt(importID);
            Assert.IsTrue(database_ImportReceipt.DeletDataByID(import));
        }


    }
}
