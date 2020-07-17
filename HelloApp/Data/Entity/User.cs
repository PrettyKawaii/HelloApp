using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelloApp.Data.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string info = $"{Id}.{Name}-{Age} ({Position})";
            return info;
        }

                
        public string Position { get; set; }

        public User(string name, int age) : this(name, age, "User")         
        {                     
        }

        public User(string name, int age, string position) //2
        {
            Name = name;
            Age = age;
            Position = GetPosition(position);
        }

        public string GetPosition(string Position)
        {
            if (String.IsNullOrEmpty(Position))
                return "User";
            return Position;
        }

        public ICollection<UsersProjects> UsersProjects { get; set; }
            


        // вызвать конструктор 2 строке.
        //перегрузіть метод стровкового представленія 
        //добавіть проверку в 2 на position is null empty


    }
}
