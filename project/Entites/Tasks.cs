using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{
    internal class Tasks
    {
        public int TaskId { get; set; }//מפתח רץ
        public string TaskName { get; set; }
        public int Difficulty { get; set; }
        public int GroupId { get; set; }
        public Groups Groups { get; set; }
    }
}
