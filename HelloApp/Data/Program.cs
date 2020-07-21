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
        static void Main(string[] args)
        {
            SelectEnvironment();
        }

        public static void SelectEnvironment()
        {
            var userService = new UserService();
            var projectService = new ProjectService();
            var userProjectService = new UserProjectService();
            var asyncing = new Async();
            Console.WriteLine("1.UserGI; 2.ProjectGI; 3.UserProjectGI 4. Exit 5. Async");
            Console.Write(">");
            string selection = Console.ReadLine();
            
            switch(selection)
            {
                case "1":
                    userService.GI();
                    break;

                case "2":
                    projectService.GI();
                    break;

                case "3":
                    userProjectService.GI();
                    break;

                case "4":
                    userService.Exit();
                    break;

                case "5":
                    asyncing.Method1();
                    asyncing.Method2();
                    Console.WriteLine("End");
                    Console.ReadLine();
                    break;
                    

                default:
                    UnknownS();
                    break;
            }
        }

        public static void UnknownS()
        {
            Console.WriteLine("Unknown selection, please try again.");
            Console.ReadLine();

            SelectEnvironment();
        }
    }        
}
    
    
 


