using ModernAppDesign.Core;

namespace ModernAppDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand FeaturedViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

        public FeaturedViewModel FeaturedVM { get; set; }

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
            DiscoveryVM = new DiscoveryViewModel();
            FeaturedVM = new FeaturedViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(s =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(s =>
            {
                CurrentView = DiscoveryVM;
            });

            FeaturedViewCommand = new RelayCommand(s =>
            {
                CurrentView = FeaturedVM;
            });
        }
    }
}
