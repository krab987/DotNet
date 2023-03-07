using System.Windows.Input;
using YouTubeViewer.Stores;

namespace YouTubeViewer.ViewModels
{
    public class ViewerViewModel: ViewModelBase
    {
        public ListingModel ListingModel { get; }
        public DetailsModel DetailsModel { get; }
        public ICommand AddViewersCommand   { get; }
        
        public ViewerViewModel(SelectedViewerStore selectedViewerStore)
        {
            ListingModel = new ListingModel(selectedViewerStore);
            DetailsModel = new DetailsModel(selectedViewerStore);
        }
    }
}
