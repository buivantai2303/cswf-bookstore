using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_Publisher
    {
        public string PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public string PublisherTel { get; set; }
        public string PublisherState { get; set; }

        public Class_Publisher(string publisherId) 
        {
            PublisherId = publisherId;
        }
        public Class_Publisher(string publisherId, string publisherName, string publisherAddress, string publisherTel)
        {
            PublisherId = publisherId;
            PublisherName = publisherName;
            PublisherAddress = publisherAddress;
            PublisherTel = publisherTel;
        }
    }
}
