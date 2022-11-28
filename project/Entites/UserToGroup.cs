using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{
    internal class UserToGroup
    {
        public int UserToGroupID { get; set; }//מפתח רץ
        public int UserID { get; set; }
        public Users User { get; set; }
        public int GroupID { get; set; }
        public Groups Group { get; set; }
        public DateOnly JoinDate { get; set; }
        public DateOnly LeftDate { get; set; }
    }
}
