using CollegeProjectManager.Utilities;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            mainWindow.Main.Navigate(new ProjectDetails((int)dgProjects.SelectedValue));
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
