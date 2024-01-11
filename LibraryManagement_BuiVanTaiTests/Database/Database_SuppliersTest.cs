using LibraryManagement_BuiVanTai;
using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using LibraryManagement_BuiVanTaiTests.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace LibraryManagement_BuiVanTaiTests.Database
{
    [TestClass]
    public class Database_SupplierTest
    {
        Database_Suppliers database_Suppliers = new Database_Suppliers(ClassDefineName.servername, ClassDefineName.database_test);

        [TestMethod]
        [DataRow("PUBA", "PUBG A", "Ha Noi", "0965422203", "Active")]
        [DataRow("PUBB", "PUBG B", "Ho Chi Minh", "0965422204", "Inactive")]
        [DataRow("PUBC", "PUBG C", "Ha Noi", "0965422205", "Active")]
        [DataRow("PUBD", "PUBG D", "Ho Chi Minh", "0965422206", "Inactive")]
        [DataRow("PUBE", "PUBG E", "Ha Noi", "0965422207", "Active")]
        [DataRow("PUBF", "PUBG F", "Ho Chi Minh", "0965422208", "Active")]

        public void InsertDataTest(string ID, string Name, string Address, string Tel, string State)
        {
            Class_Suppliers suppliers = new Class_Suppliers(ID, Name, Address, Tel, State);
            Assert.IsTrue(database_Suppliers.InsertData(suppliers));
        }

        [TestMethod()]
        [DataRow("PUBA", "PUBG A", "Da Nang", "0965422203", "Active")]
        [DataRow("PUBB", "PUBG B", "Da Nang", "0965422204", "Inactive")]
        [DataRow("PUBC", "PUBG C", "Da Nang", "0965422205", "Active")]
        [DataRow("PUBD", "PUBG D", "Da Nangh", "0965422206", "Inactive")]
        [DataRow("PUBE", "PUBG E", "Da Nang", "0965422207", "Active")]
        [DataRow("PUBF", "PUBG F", "Da Nang", "0965422208", "Active")]
        public void UpdateDataTest(string ID, string Name, string Address, string Tel, string State)
        {
            Class_Suppliers suppliers = new Class_Suppliers(ID, Name, Address, Tel, State);
            Assert.IsTrue(database_Suppliers.UpdateData(suppliers));
        }

        [TestMethod]
        [DataRow("PUBB")]
        [DataRow("PUBD")]
        [DataRow("PUBF")]
        public void DeleteDataTest(string ID)
        {
            Class_Suppliers suppliers = new Class_Suppliers(ID);
            Assert.IsTrue(database_Suppliers.DeletData(suppliers));
        }
    }
}
