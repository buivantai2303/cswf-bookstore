using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryManagement_BuiVanTaiTests.Database
{
    [TestClass]
    public class Database_StaffTest
    {
        Database_Staff database_Staff = new Database_Staff(ClassDefineName.servername, ClassDefineName.database_test);

        [TestMethod]
        [DataRow("00000001", "Staff 1", "2003-03-23", "Thai Binh", "0965422206")]
        [DataRow("00000002", "Staff 2", "2004-04-24", "Thai Binh", "0965422207")]
        [DataRow("00000003", "Staff 3", "2005-05-25", "Thai Binh", "0965422208")]
        [DataRow("00000004", "Staff 4", "2006-06-26", "Thai Binh", "0965422209")]
        [DataRow("00000005", "Staff 5", "2007-07-27", "Thai Binh", "0965422200")]
        [DataRow("00000006", "Staff 6", "2008-08-28", "Thai Binh", "0965422201")]
        public void InsertData(string ID, string Name, string DOB, string Address, string Tel)
        {
            Class_Staff staffs = new Class_Staff(ID, Name, DOB, Address, Tel);
            Assert.IsTrue(database_Staff.InsertData(staffs));
        }


        [TestMethod]
        [DataRow("00000011", "Staff 11", "2003-03-23", "Hung Yen", "0965422206")]
        [DataRow("00000012", "Staff 12", "2004-04-24", "Hung Yen", "0965422207")]
        [DataRow("00000013", "Staff 13", "2005-05-25", "Hung Yen", "0965422208")]
        [DataRow("00000014", "Staff 14", "2006-06-26", "Hung Yen", "0965422209")]
        [DataRow("00000015", "Staff 15", "2007-07-27", "Hung Yen", "0965422200")]
        [DataRow("00000016", "Staff 16", "2008-08-28", "Hung Yen", "0965422201")]
        public void UpdateData(string ID, string Name, string DOB, string Address, string Tel)
        {
            Class_Staff staffs = new Class_Staff(ID, Name, DOB, Address, Tel);
            Assert.IsTrue(database_Staff.UpdateData(staffs));
        }


        [DataRow("00000011")]
        [DataRow("00000012")]
        [DataRow("00000013")]
        public void Delete(string ID)
        {
            Class_Staff staffs = new Class_Staff(ID);
            Assert.IsTrue(database_Staff.UpdateData(staffs));
        }

    }
}
