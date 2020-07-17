using Microsoft.EntityFrameworkCore;
using HelloApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp.Data.Context
{
   
        public class AplicationContext : DbContext
        {
            public DbSet<User> Users { get; set; }

            public DbSet<Project> Projects { get; set; }

            public DbSet<UsersProjects> UsersProjects { get; set; }

            //public DbSet<??> UsersProjects { get; set;}

            public AplicationContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
            }

         

            
        }

}
