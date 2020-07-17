using HelloApp.Data.Context;
using HelloApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloApp.Services
{
    public class ProjectService
    {
        AplicationContext dbContext { get; } = new AplicationContext();

        public void GI()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to Project GI");
            Console.WriteLine("1.Display projects; 2.Exit; 3.Manage projects");
            Console.Write("->");

            string selection = Console.ReadLine();
            Selection(selection);
        }

        public void Selection(string selection)
        {
            switch(selection)
            {
                case "1":
                    DisplayProjects();
                    GI();
                    break;

                case "2":
                    Exit();
                    break;

                case "3":
                    ManageProjects();
                    break;

                default:
                    UnknownS();
                    break;
            }
               
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void DisplayProjects()
        {
            var projects = dbContext.Projects;

            foreach(Project p in projects)
            {
                string project = p.ToString();
                Console.WriteLine(project);
            }
        }

        public void UnknownS()
        {
            Console.WriteLine("Unknown choice, please try again.");
            Console.ReadLine();
            GI();
        }

        public void ManageProjects()
        {
            Console.WriteLine("1.Add; 2.Delete; 3.Exit; 4.Return");
            Console.Write("->");
            string selection = Console.ReadLine();

            switch(selection)
            {
                case "1":
                    Add();
                    break;

                case "2":
                    Delete();
                    break;

                case "3":
                    Exit();
                    break;

                case "4":
                    Program.SelectEnvironment();
                    break;

                default:
                    UnknownS();
                    break;
            }
        }

        public void Add()
        {
            Project project = new Project();

            Console.Write("Title: ");
            project.Title = Console.ReadLine();           

            dbContext.Projects.Add(project);
            dbContext.SaveChanges();

            Console.WriteLine($"Project '{project.Title}' was successfuly added.");
            GI();
        }

        public void Delete()
        {
            Project project = Select();
            
            dbContext.Projects.Remove(project);
            Console.WriteLine($"Project {project.Title} was deleted.");
            dbContext.SaveChanges();

            GI();
        }

        public Project Select()
        {
            DisplayProjects();
            Console.WriteLine("Select project id.");
            Console.Write("->");
            int id = int.Parse(Console.ReadLine());
            Project project = dbContext.Projects.Single(x => x.Id == id);
            return project;
        }
    }
}
