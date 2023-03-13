using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using YouTubeViewer.Stores;
using YouTubeViewer.Models;

namespace YouTubeViewer.ViewModels
{
    public class ListingModel: ViewModelBase
    {
        private readonly SelectedViewerStore _selectedViewerStore;
        private readonly List<ItemListing> _itemsListing;
        public IEnumerable<ItemListing> ItemsListing => _itemsListing;

        private ItemListing _selectedListingItem;
        public ItemListing SelectedListingItem
        {
            get
            {
                return _selectedListingItem;
            }
            set
            {
                _selectedListingItem = value;
                OnPropertyChanged(nameof(_selectedListingItem));
                //_selectedViewerStore.SelectedYouTubeViewer = new Models.YouTubeViewer();
            }
        }

        public ListingModel(SelectedViewerStore selectedViewerStore)
        {
            _selectedViewerStore = selectedViewerStore;
            _itemsListing = new List<ItemListing>();
            _itemsListing.Add(new ItemListing(new ("Mary", true, false)));
            _itemsListing.Add(new ItemListing(new ("Bard", true, false)));
            _itemsListing.Add(new ItemListing(new ("Alan", true, false)));
        }
    }
}
