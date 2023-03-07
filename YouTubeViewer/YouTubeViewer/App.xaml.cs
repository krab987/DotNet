using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewer.Stores;
using YouTubeViewer.ViewModels;

namespace YouTubeViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedViewerStore _selectedViewerStore;

        public App()
        {
            _selectedViewerStore = new SelectedViewerStore();
        }
        
        override protected void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ViewerViewModel(_selectedViewerStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
