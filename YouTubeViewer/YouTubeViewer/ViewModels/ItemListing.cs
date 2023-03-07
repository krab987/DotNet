using System.Windows.Input;

namespace YouTubeViewer.ViewModels
{
    public class ItemListing: ViewModelBase
    {
        public readonly Models.YouTubeViewer youTubeViewer;
        public string Username => youTubeViewer.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        
        public ItemListing(Models.YouTubeViewer youTubeViewer)
        {
            this.youTubeViewer = youTubeViewer;
        }
    }
}
