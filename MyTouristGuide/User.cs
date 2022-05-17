using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTouristGuide
{
    public class User
    {
        public int UserId { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string EMail { set; get; }
        public DateTime CreatedOn { set; get; }
        public string Description {set;get; }
        public bool Status {set;get;}
    }
}
