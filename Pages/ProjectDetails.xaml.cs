using CollegeProjectManager.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollegeProjectManager.Pages
{
    /// <summary>
    /// Interaction logic for ProjectDetails.xaml
    /// </summary>
    public partial class ProjectDetails : Page
    {
        private int _projectId;

        public ProjectDetails(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Fetch project details
            DatabaseHandler handler = new DatabaseHandler();
            Project project = (Project)handler.FetchProjectById(_projectId);
            List<Task> projectTasks = handler.FetchTasks(_projectId);

            // Display project details
            for (int i = 0; i < projectTasks.Count; i++)
            {
                MessageBox.Show(projectTasks[i].Name);
            }
        }
    }
}
