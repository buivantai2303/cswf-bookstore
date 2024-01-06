using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_Book
    {
        public string BookId { get; set; }
        public string BookTitle { get; set; }
        public string Remaining { get; set; }
        public string BookType { get; set; }
        public string PublisherId { get; set; }
        public string AuthorId { get; set; }
        public string Price { get; set; }

        public Class_Book(string bookId) 
        {
            BookId = bookId;
        }

        public Class_Book(string bookId, string bookTitle, string remaining, string bookType, string publisherId, string authorId, string price)
        {
            BookId = bookId;
            BookTitle = bookTitle;
            Remaining = remaining;
            BookType = bookType;
            PublisherId = publisherId;
            AuthorId = authorId;
            Price = price;
        }
    }
}
