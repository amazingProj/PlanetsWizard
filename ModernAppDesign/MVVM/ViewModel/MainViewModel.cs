using ModernAppDesign.Core;

namespace ModernAppDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private BL.IBL bL = new BL.BL();
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand SearchViewCommand { get; set; }

        public RelayCommand MediaViewCommand { get; set; }

        public RelayCommand SolarSystemViewCommand { get; set; }

        public RelayCommand TodayPictureViewCommand { get; set; }

        public RelayCommand MyGalleryViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public SearchViewModel SearchVM { get; set; }

        public MediaViewModel MediaVM { get; set; }

        public SolarSystemViewModel SolarSystemVM;

        public TodayPictureViewModel TodayPictureVM;

        public GalleryViewModel MyGalleryVM;

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SearchVM = new SearchViewModel();
            MediaVM = new MediaViewModel();
            SolarSystemVM = new SolarSystemViewModel();
            TodayPictureVM = new TodayPictureViewModel();
            MyGalleryVM = new GalleryViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(s =>
            {
                CurrentView = HomeVM;
            });

            SearchViewCommand = new RelayCommand(s =>
            {
                CurrentView = SearchVM;
            });

            MediaViewCommand = new RelayCommand(s =>
            {
                CurrentView = MediaVM;
            });

            SolarSystemViewCommand = new RelayCommand(s =>
            {
                CurrentView = SolarSystemVM;
            });

            TodayPictureViewCommand = new RelayCommand(s =>
            {
                CurrentView = TodayPictureVM;
            });

            MyGalleryViewCommand = new RelayCommand(s =>
            {
                CurrentView = MyGalleryVM;
            });
        }

        public BL.IBL GetBL()
        {
            return bL;
        }
    }
}
