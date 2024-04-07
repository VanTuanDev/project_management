using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class AccountEntity
    {
        public string username { get; set; }
        public string pwd { get; set; }
        public string fullname { get; set; }
        public int role { get; set; }
        public string rolename { get; set; }
        public string status { get; set; }
    }
}
