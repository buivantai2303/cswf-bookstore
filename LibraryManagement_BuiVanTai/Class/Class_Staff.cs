using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement_BuiVanTai.Class
{
    public class Class_Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffDOB { get; set; }
        public string StaffAddress { get; set; }
        public string StaffTel { get; set; }
        public Class_Staff(int staffId, string staffName, string staffDOB, string staffAddress, string staffTel)
        {
            StaffId = staffId;
            StaffName = staffName;
            StaffDOB = staffDOB;
            StaffAddress = staffAddress;
            StaffTel = staffTel;
        }
    }
}
