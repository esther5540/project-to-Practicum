using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{enum eDays { sunday, monday, tuesday, wendsday, thurthday, friday }
    internal class TaskFrequency
    {
        public int FrequencyId { get; set; }//מפתח רץ
        public int TaskId { get; set; }
        public eDays Day_of_week { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeFinish { get; set; }
        public Task Task { get; set; }
        
    }
}
