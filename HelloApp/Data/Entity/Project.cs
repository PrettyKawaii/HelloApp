using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HelloApp.Data.Entity
{
    public class Project
    {
        ICollection<UsersProjects> UsersProjects { get; set; }

        [Key]
        //TODO Rename to Id
        public int Id { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            string info = $"{Id}.{Title}";
            return info;
        }
     

        public Project()
        {
            string dTitle = "NewProject" + $"{Id}";
            Title = dTitle;
        }




    }
}
