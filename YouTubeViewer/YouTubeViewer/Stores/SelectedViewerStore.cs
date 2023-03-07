using System;
using System.Windows;
using YouTubeViewer.Models;
namespace YouTubeViewer.Stores
{
    public class SelectedViewerStore
    {
        private Models.YouTubeViewer _selectedYouTubeViewer;

        public Models.YouTubeViewer SelectedYouTubeViewer
        {
            get
            {
                return _selectedYouTubeViewer;
            }
            set
            {
                _selectedYouTubeViewer = value;
                SelectedYouTubeViewerChanged?.Invoke();
            }
        }

        public event Action SelectedYouTubeViewerChanged;
    }
}
