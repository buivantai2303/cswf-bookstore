using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement_BuiVanTai.Class;

namespace LibraryManagement_BuiVanTai.Database.Tests
{
    [TestClass()]
    public class Database_SaleReceiptsTests
    {
        Database_SaleReceipts database_Sal = new Database_SaleReceipts(ClassDefineName.servername, ClassDefineName.database_test);


        [TestMethod()]
        [DataRow("123", "123", "12-12-12")]
        [DataRow("1234", "1231", "12-12-12123")]
        [DataRow("123a", "123", "12-12-12")]
        [DataRow("123", "123", "12-12-12")]
        public void InsertDataTest(string id, string name, DateTime address)
        {
            Class_SaleReceipt sale = new Class_SaleReceipt(id, name, address);
            Assert.IsTrue(database_Sal.InsertData(sale));
        }

        [TestMethod()]
        [DataRow("123")]
        [DataRow("1234")]
        [DataRow("123a")]
        public void DeleteDataTest(string id)
        {
            Class_SaleReceipt sale = new Class_SaleReceipt(id);
            Assert.IsTrue(database_Sal.DeleteData(sale));
        }

/*        [TestMethod()]
        [DataRow("123", "NXB Something", "Trai Dat", "0123xxxxxxxx", "Active")]
        [DataRow("123", "NXB Something", "Trai Dat", "0123xxxxxxxx", "Inactive")]
        [DataRow("123", "NXB Somethinghi", "Trai Dat", "0123xxxxxxxxxxx", "Active")]*/
    }
}