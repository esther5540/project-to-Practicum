using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum eDays{ sunday,monday,tuesday,wendsday,thurthday,friday}
namespace project.Entites
{
    internal class Constraits
    {
        public int ConstraitId { get; set; }//מפתח רץ
        public int UserId { get; set; }
        public Users User { get; set; }
        public string Constrait { get; set; }
        public eDays DayOfWeek { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public bool IsPermanent { get; set; }
    }
}
