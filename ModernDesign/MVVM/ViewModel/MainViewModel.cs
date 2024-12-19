using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel: ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        private HomeViewModel homeVm { get; set; }
        private DiscoveryViewModel discoveryVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public MainViewModel()
        {
            homeVm = new HomeViewModel();
            discoveryVm = new DiscoveryViewModel();
            CurrentView = homeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = homeVm;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = discoveryVm;
            });
        }
    }
}
