using project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    internal interface IContext
    {List<Constraits> constraits { get; set; }//לשנות לDbContext
        List<Groups> groups { get; set; }
        List<Managers> managers { get; set; }
        List<Performance> performances { get; set; }
        List<TaskFrequency> taskFrequency { get; set; }
        

    }
}
