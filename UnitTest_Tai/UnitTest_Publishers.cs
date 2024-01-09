using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement_BuiVanTai.Class;
using LibraryManagement_BuiVanTai.Database;
using System;
using System.Data;
using System.Windows.Forms;
using LibraryManagement_BuiVanTai.Tab;

namespace UnitTest_Tai
{
    [TestClass]
    public class UnitTest_Tab_Publisher
    {
        Tab_Publisher tabPublisher;

        [TestInitialize]
        public void TestInitialize()
        {
            // Khởi tạo đối tượng Tab_Publisher trước mỗi phương thức kiểm thử
            tabPublisher = new Tab_Publisher();
        }

        
    }
}
