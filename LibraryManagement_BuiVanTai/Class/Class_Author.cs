using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_Author
    {
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDOB { get; set; }
        public string AuthorAddress { get; set; }
        public string AuthorEmail { get; set; }

        public Class_Author(string authorId, string authorName, string authorDOB, string authorAddress, string authorEmail)
        {
            AuthorId = authorId;
            AuthorName = authorName;
            AuthorDOB = authorDOB;
            AuthorAddress = authorAddress;
            AuthorEmail = authorEmail;
        }
    }
}
