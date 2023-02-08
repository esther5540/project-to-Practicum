using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Entites
{
  
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Tz { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string healthFund { get; set; }
        public int Children { get; set; }
        [AllowNull]
        public string FatherTz { get; set; }
        [AllowNull]
        public string MotherTz { get; set; }

    }
}
