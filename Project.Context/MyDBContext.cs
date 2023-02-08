using Microsoft.EntityFrameworkCore;
using Project.Interfaces;
using Project.Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Context
{
    public class MyDBContext : DbContext, IContext
    {
        
        public DbSet<Users> AllUsers { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=MyProjectUsersDB2;Trusted_Connection=True;");
        }
   
    }
}
