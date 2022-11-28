using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{
    internal class Performance
    {
        public int PerformanceId { get; set; }//מפתח רץ
        public int TaskUserID { get; set; }
        public TaskToUser TaskOfUser { get; set; }
        public DateOnly PerformanceDate { get; set; }
        public TimeOnly PerformanceTime { get; set; }
        public int Mark { get; set; }
        public string Note { get; set; }//איך אומרים הערה?
    }
}
