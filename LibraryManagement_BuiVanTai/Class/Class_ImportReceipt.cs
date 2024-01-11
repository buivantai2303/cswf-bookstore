using System;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_ImportReceipt
    {
        public string ImportID { get; set; }
        public DateTime ImportDate { get; set; }
        public string PublisherID { get; set; }
        public string StaffID { get; set; }

        public Class_ImportReceipt() { }

        public Class_ImportReceipt(string importID, DateTime importDate) 
        {
            ImportID = importID;
            ImportDate = importDate;
        }

        public Class_ImportReceipt(string importID)
        {
            ImportID = importID;
        }

        public Class_ImportReceipt(string importID, DateTime importDate, string publisherID, string staffID)
        {
            ImportID = importID;
            ImportDate = importDate;
            PublisherID = publisherID;
            StaffID = staffID;
        }
    }
}
