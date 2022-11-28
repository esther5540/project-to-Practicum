using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{
    internal class Users
    {
        public int UserId { get; set; }//מפתח רץ
        public string UserName { get; set; }
        public string Mail { get; set; }
        public int Telephone { get; set; }
        public string Password { get; set; }

    }
}
