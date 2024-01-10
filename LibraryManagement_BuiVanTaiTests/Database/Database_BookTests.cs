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
    public class Database_BookTests
    {
        Database_Book database_Book = new Database_Book(ClassDefineName.servername, ClassDefineName.database_test);

        [TestMethod()]
        [DataRow("123", "GoodBook", "123", "Novel", "LondonPH", "JKRowling", "26")]
        [DataRow("1234", "GoodBook", "123", "Novel", "LondonPH", "JKRowling", "26")]
        [DataRow("12345", "GoodBook", "123", "Novel", "absPub", "JKRowling", "26")]
        [DataRow("123", "GoodBook", "123", "Sci-Fi", "LondonPH", "JKRowling", "26")]
        public void InsertDataTest(string id, string name, string remaining, string bookType, string publisherID, string authorID, string price)
        {
            Class_Book book = new Class_Book(id, name, remaining, bookType, publisherID, authorID, price);
            Assert.IsTrue(database_Book.InsertData(book));
        }

        [TestMethod()]
        [DataRow("123", "GoodBook", "123", "Detective", "LondonPH", "JKRowling", "26")]
        [DataRow("1234", "GoodBook", "123", "Detective", "NoPublisher", "JKRowling", "26")]
        [DataRow("123", "GoodBook", "123123", "Detective", "LondonPH", "JJK", "26")]
        public void UpdateDataTest(string id, string name, string remaining, string bookType, string publisherID, string authorID, string price)
        {
            Class_Book book = new Class_Book(id, name, remaining, bookType, publisherID, authorID, price);
            Assert.IsTrue(database_Book.UpdateData(book));
        }

        [TestMethod()]
        [DataRow("123")]
        [DataRow("1233")]
        [DataRow("12312")]
        public void DeleteDataTest(string id)
        {
            Class_Book book = new Class_Book(id);
            Assert.IsTrue(database_Book.DeleteData(book));
        }
    }
}