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
    public class Database_PublisherTests
    {
        Database_Publisher database_Publisher = new Database_Publisher(ClassDefineName.servername, ClassDefineName.database_test);


        [TestMethod()]
        [DataRow("123", "NXB Something", "Trai Dat", "0123xxxxxx", "Active")]
        [DataRow("1234", "NXB Something", "Trai Dat", "0123xxxxxx", "Active")]   
        [DataRow("123a", "NXB Something", "Trai Dat", "0123xxxxxxx", "Inactive")]
        [DataRow("123", "NXB Something", "Trai Dat", "0123xxxxxx", "Iactive")]
        public void InsertDataTest(string id, string name, string address, string tel, string state)
        {
            Class_Publisher pub = new Class_Publisher(id, name, address, address, state);
            Assert.IsTrue(database_Publisher.InsertData(pub));
        }

        [TestMethod()]
        [DataRow("123")]
        [DataRow("1234")]
        [DataRow("123a")]
        public void DeleteDataTest(string id)
        {
            Class_Publisher pub = new Class_Publisher(id);
            Assert.IsTrue(database_Publisher.DeletePubByID(pub));
        }

        [TestMethod()]
        [DataRow("123", "NXB Something", "Trai Dat", "0123xxxxxxxx", "Active")]
        [DataRow("123", "NXB Something", "Trai Dat", "0123xxxxxxxx", "Inactive")]
        [DataRow("123", "NXB Somethinghi", "Trai Dat", "0123xxxxxxxxxxx", "Active")]


        public void UpdateDataTest(string id, string name, string address, string tel, string state)
        {
            Class_Publisher pub = new Class_Publisher(id, name, address, address, state);
            Assert.IsTrue(database_Publisher.UpdatePub(pub));
        }
    }
}