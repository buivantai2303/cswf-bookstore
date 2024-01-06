using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }

        public Class_Customer(string id) 
        {
            Id = id;
        }
        public Class_Customer(string id, string firstName, string lastName, string tel, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Tel = tel;
            Address = address;
        }
    }
}
