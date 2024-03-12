using CollegeProjectManager.Utilities;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ProjectDashboard.xaml
    /// </summary>
    public partial class ProjectDashboard : Page
    {
        public ProjectDashboard()
        {
            InitializeComponent();
        }

        private void dgProjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Main.Navigate(new ProjectDetails());
        }

        private void btnCreateNewProject_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Main.Navigate(new NewProjectCreator());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DatabaseHandler handler = new DatabaseHandler();
            List<Project> projects = handler.FetchProjects();

            dgProjects.ItemsSource = projects;
        }
    }
}
