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
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            string info = $"{ProjectId}.{Title}";
            return info;
        }
     

        public Project()
        {
            string dTitle = "NewProject" + $"{ProjectId}";
            Title = dTitle;
        }


        //smth to commit

    }
}
