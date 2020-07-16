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
            Console.WriteLine("1.UserGI; 2.ProjectGI; 3. Exit");
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
                    userService.Exit();
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
    
    
 


