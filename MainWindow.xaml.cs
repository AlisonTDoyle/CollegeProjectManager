﻿using CollegeProjectManager.Pages;
using CollegeProjectManager.Windows;
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

namespace CollegeProjectManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main.Content = new ProjectDashboard();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.Show();
        }

        private void btnDisplayProjectDashboard_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ProjectDashboard();
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {
            if (Main.Content is Page)
            {
                // If the content is any page (including ProjectDashboard),
                // set the button visibility based on whether it's ProjectDashboard or not.
                if (Main.Content is ProjectDashboard)
                {
                    btnDisplayProjectDashboard.Visibility = Visibility.Hidden;
                }
                else
                {
                    btnDisplayProjectDashboard.Visibility = Visibility.Visible;
                }
            }
            else
            {
                // If the content is not a page, hide the button.
                btnDisplayProjectDashboard.Visibility = Visibility.Hidden;
            }
        }
    }
}
