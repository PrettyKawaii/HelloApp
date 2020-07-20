using HelloApp.Data.Context;
using HelloApp.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace HelloApp.Services
{
    public class UserProjectService
    {
        AplicationContext dbContext { get; } = new AplicationContext();
        //var userService = new UserService();
        //var projectService = new ProjectService();

        public void GI()
        {
            Console.WriteLine("Welcome to UserProject GI.");
            Console.WriteLine("1.Display connections; 2.Connect user to project; 3.Exit; 4.Return");
            Console.Write(">");
            string selection = Console.ReadLine();
            Selection(selection);
        }

        public void Selection(string selection)
        {
            switch(selection)
            {
                case "1":
                    Display();
                    GI(); 
                    break;

                case "2":
                    Connect();
                    GI();
                    break;

                case "3":
                    Exit();
                    break;

                case "4":
                    Program.SelectEnvironment();
                    break;

                default:
                    Program.UnknownS();
                    break;
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void Connect()
        {
            var userService = new UserService();
            User user = userService.SelectUser();

            var projectService = new ProjectService();
            Project project = projectService.Select();

            UsersProjects usersProjects = new UsersProjects
            {
                ProjectId = project.Id,
                UserId = user.Id
            };

            dbContext.UsersProjects.Add(usersProjects);
            dbContext.SaveChanges();
        }

        public void Display()
        {
            var stuff = dbContext.UsersProjects
                .Include(x => x.Project).Include(x => x.User)
                .ToList();
                
            foreach(UsersProjects x in stuff)
            {
                string y = x.ToString();
                Console.WriteLine(y); 
            }
        }

    }
}
