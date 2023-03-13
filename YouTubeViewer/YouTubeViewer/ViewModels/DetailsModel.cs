using YouTubeViewer.Stores;

namespace YouTubeViewer.ViewModels
{
    public class DetailsModel: ViewModelBase
    {
        private readonly SelectedViewerStore _selectedViewerStore;

        public bool HasSelectedViewer => _selectedViewerStore.SelectedYouTubeViewer != null;
        public string? Username => _selectedViewerStore.SelectedYouTubeViewer?.Username ?? "Unknown";
        public string IsSubscribedDisplay => _selectedViewerStore.SelectedYouTubeViewer.IsSubscribed ? "Yes" : "No";

        public string IsMemberedDisplay => _selectedViewerStore.SelectedYouTubeViewer.IsMembered ? "Yes" : "No";

        public DetailsModel(SelectedViewerStore selectedViewerStore)
        {
            _selectedViewerStore = selectedViewerStore;
        }
    }
}
