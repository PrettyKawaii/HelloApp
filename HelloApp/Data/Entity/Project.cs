using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp.Data.Entity
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        ICollection<UsersProjects> UsersProjects { get; set; }
    }
}
