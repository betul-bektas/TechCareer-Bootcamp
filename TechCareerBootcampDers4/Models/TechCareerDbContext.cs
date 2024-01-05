using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TechCareerBootcampDers4.Models
{
    public class TechCareerDbContext:DbContext
    {
        public DbSet<Order>? Orders { get; set; }
        public DbSet<WebUser>? WebUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
             optionsBuilder.UseSqlServer("Server=BETUL-BEKTAS\\MSSQLSERVER05; Database=TechCareerDb; Trusted_Connection =true");
        } 
    }
}