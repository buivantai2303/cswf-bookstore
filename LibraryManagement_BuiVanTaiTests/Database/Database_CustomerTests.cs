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
    public class Database_CustomerTests
    {
        Database_Customer database_Customer = new Database_Customer(ClassDefineName.servername, ClassDefineName.database_test);


        [TestMethod()]
        [DataRow("123", "Nguyen Van ", "A", "01231223123", "Ha Noi")]
        [DataRow("12345678912", "Nguyen Van ", "A", "01231223123", "Ha Noi")]
        [DataRow("1230", "Nguyen Van ", "A", "012312231232", "Ha Noi")]
        [DataRow("123", "Nguyen Van ", "D", "01231223123", "Ha Noi")]

        public void InsertDataTest(string id, string fname, string lname, string address, string email)
        {
            Class_Customer customer = new Class_Customer(id, fname, lname, address, email);
            Assert.IsTrue(database_Customer.InsertData(customer));
        }

        [TestMethod()]
        [DataRow("123")]
        [DataRow("12345678912")]
        [DataRow("123a")]
        public void DeleteDataTest(string id)
        {
            Class_Customer customer = new Class_Customer(id);
            Assert.IsTrue(database_Customer.DeleteData(customer));
        }

        [TestMethod()]
        [DataRow("123", "Nguyen Van ", "B", "12312231233", "Ha Noi")]
        [DataRow("12345678912", "Nguyen Van ", "B", "1231223123131", "Ha Noi")]
        [DataRow("1230", "Nguyen Van ", "B", "12312231233", "Ha Noi")]

        public void UpdateDataeTest(string id, string fname, string lname, string address, string email)
        {
            Class_Customer customer = new Class_Customer(id, fname, lname, address, email);
            Assert.IsTrue(database_Customer.UpdateData(customer));
        }
    }
}