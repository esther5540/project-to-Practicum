using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{
    internal class Groups
    {
        public int GroupID { get; set; }//מפתח רץ
        public string GroupName { get; set; }
        public int ManagerID { get; set; }
        public Managers Manager { get; set; }

    }
}
