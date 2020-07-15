using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HelloApp;
using HelloApp.Services;
using Microsoft.EntityFrameworkCore;

namespace HelloApp
{
    class Program
    {
        //static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            var service = new UserService();

            service.GI();
        }


    }

    // public class User
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Position { get; set; }
    //}






    //public class AplicationContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }

    //    public AplicationContext()
    //    {
    //        Database.EnsureCreated();
    //    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
    //    }

    //}
        
}
    
    
 


