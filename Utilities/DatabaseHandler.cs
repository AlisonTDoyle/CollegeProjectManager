using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectManager.Utilities
{
    internal class DatabaseHandler
    {
        ProjectDBEntities db = new ProjectDBEntities();

        public List<Project> FetchProjects()
        {
            var query = from project in db.Projects
                        select project;

            return query.ToList();
        }
    }
}
