using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    internal class Class_ImportReceipt
    {
        private string ImportID;
        private DateTime ImportDate;
        private string PublisherID;
        private string StaffID;

        public string ImportID1 { get => ImportID; set => ImportID = value; }
        public DateTime ImportDate1 { get => ImportDate; set => ImportDate = value; }
        public string PublisherID1 { get => PublisherID; set => PublisherID = value; }
        public string StaffID1 { get => StaffID; set => StaffID = value; }

        public Class_ImportReceipt() { }

        public Class_ImportReceipt(string importID, DateTime importDate, string publisherID, string staffID)
        {
            ImportID = importID;
            ImportDate = importDate;
            PublisherID = publisherID;
            StaffID = staffID;
        }
    }
}
