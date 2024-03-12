using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectManager.Utilities
{
    public class DatabaseHandler
    {
        ProjectDBEntities db = new ProjectDBEntities();

        public List<Project> FetchProjects()
        {
            var query = from project in db.Projects
                        select project;

            return query.ToList();
        }

        public List<Task> FetchTasks(int projectId)
        {
            var query = from task in db.Tasks
                        select task;

            return query.ToList();
        }
    }
}
