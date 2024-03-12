using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CollegeProjectManager.Utilities
{
    public class DatabaseHandler
    {
        ProjectDBEntities db = new ProjectDBEntities();

        #region Project table methods
        public List<Project> FetchProjects()
        {
            var query = from project in db.Projects
                        select project;

            return query.ToList();
        }

        public void RemoveProject(int ProjectId)
        {

        }

        public void CreateProject(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
        }
        #endregion

        #region Task table methods
        public List<Task> FetchTasks(int projectId)
        {
            var query = from task in db.Tasks
                        select task;

            return query.ToList();
        }

        public void RemoveTask(int taskId)
        {

        }

        public void CreateTask(Task newTask)
        {
            db.Tasks.Add(newTask);
            db.SaveChanges();
        }
        #endregion
    }
}
