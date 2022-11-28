using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entites
{
    internal class TaskToUser
    {
        public int TaskUserId { get; set; }//מפתח רץ
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int FrequencyId { get; set; }
        public Task Task { get; set; }
        public Users Users { get; set; }
        public TaskFrequency TaskFrequency { get; set; }
    }
}
