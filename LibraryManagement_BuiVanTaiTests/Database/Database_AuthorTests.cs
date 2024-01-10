using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement_BuiVanTai.Class;
using System.Net;

namespace LibraryManagement_BuiVanTai.Database.Tests
{
    [TestClass()]
    public class Database_AuthorTests
    {
        Database_Author database_author = new Database_Author(ClassDefineName.servername, ClassDefineName.database_test);
        

        [TestMethod()]
        [DataRow("123", "Nguyen Van A", "2022/12/12", "Ha Noi", "abc@gmail.com")]
        [DataRow("123456789123456abcdefgh", "Nguyen Van A", "2022/12/12", "Ha Noi", "abc@gmail.com")]
        [DataRow("123", "Nguyen Van A", "12/12/2022", "Ha Noi", "abc@gmail.com")]
        [DataRow("1233", "Nguyen Van A", "123", "Ha Noi", "abc@gmail.com")]
        public void InsertDataTest(string id, string name, string dob, string address, string email)
        {
            Class_Author author = new Class_Author(id, name, dob, address, email);
            Assert.IsTrue(database_author.InsertData(author));
        }

        [TestMethod()]
        [DataRow("123")]
        [DataRow("1233")]
        [DataRow("123a")]
        public void DeleteDataTest(string id)
        {
            Class_Author author = new Class_Author(id);
            Assert.IsTrue(database_author.DeleteData(author));
        }

        [TestMethod()]
        [DataRow("123", "Nguyen Van B", "123", "Ha Noi", "abc@gmail.com")]
        [DataRow("123456789123456abcdefgh", "Nguyen Van B", "2023/12/12", "Ha Noi", "abc@gmail.com")]
        [DataRow("1230", "Nguyen Van B", "123", "Ha Noi", "abc@gmail.com")]

        public void UpdateDataTest(string id, string name, string dob, string address, string email)
        {
            Class_Author author = new Class_Author(id, name, dob, address, email);
            Assert.IsTrue(database_author.UpdateData(author));
        }
    }
}