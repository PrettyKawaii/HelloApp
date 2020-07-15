using HelloApp.Data.Context;
using HelloApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloApp.Services
{
    public class UserService
    {
        AplicationContext dbContext { get; } = new AplicationContext();


        public UserService()
        {
            dbContext = new AplicationContext();
        }

        public void GI()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to User GI.");
            Console.WriteLine("1.Output all users; 2.Exit; 3.ManageUsers");
            Console.Write("=:>");

            string selection = Console.ReadLine();
            Selections(selection);
        }

        public void GetUsers()
        {
            var users = dbContext.Users;
            //Console.WriteLine("Got users:");
            foreach (User u in users)
            {
                string info = u.ToString(); 
                Console.WriteLine(info);
                //Console.WriteLine("{0}.{1} - {2} ({3})", u.Id, u.Name, u.Age, u.Position);
            }
                     
        }

        public void GetUser(User user)
        {
           string x = user.ToString();
            Console.WriteLine(x);
        }


        public void Selections(string selection)
        {
            switch(selection)
            {
                case "1":
                    GetUsers();
                    GI();
                    break;

                case "2":
                    Exit();
                    break;

                case "3":
                    ManageUsers();
                    break;

                default:
                    UnknownS();
                    break;
            }
        }

        public void UnknownS()
        {
            Console.WriteLine("Unknown selection, please try again.");
            GI();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void ManageUsers()
        {
            Console.WriteLine("1.Add; 2.Delete; 3.Celebrate Birthday 4.Return");
            Console.Write("=:>");
            string managing = Console.ReadLine();

            switch(managing)
            {
                case "1":
                    AddUser();
                    break;

                case "2":
                    DeleteUser();
                    break;

                case "3":
                    BirthdayC();
                    break;

                case "4":
                    GI();
                    break;

                default:
                    UnknownS();
                    break;
            }
        }

        public void AddUser()
        {           
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Position: ");
            string position = Console.ReadLine();

            User user = new User(name, age, position);

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
           
            GI();
        }

        public User SelectUser()
        {
            GetUsers();
            Console.WriteLine("Select user id.");
            Console.Write("=:>");
            int sId = int.Parse(Console.ReadLine());
            User user = dbContext.Users.Single(x => x.Id == sId);
            return user;
        }

        public void DeleteUser()
        {
            User user = SelectUser();  //get user

            dbContext.Users.Remove(user);//deleting user
            bool choice = SubmittingD();
            if (choice)
            {
                Console.WriteLine($"User {user.Name} was successfuly deleted.");
                dbContext.SaveChanges();//submitting del 
                GI();
            }
            else
            {
                Console.WriteLine("Deleting was canceled.");
                GI();
            }
        }

        public bool SubmittingD()
        {
            Console.WriteLine("Submit deletion. (y/n)");
            Console.Write("=:>");
            string selection = Console.ReadLine();
            
            switch (selection)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    UnknownS();
                    return false;
            }
        }

        public void BirthdayC()
        {
            User user = SelectUser();
            user.Age += 1;
            dbContext.SaveChanges();
            Console.WriteLine($"Happy Birthday to you, {user.Name}!");

            GI();
        }

    }
}
