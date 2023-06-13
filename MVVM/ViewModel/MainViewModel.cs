using CWMM2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWMM2.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel HomeVM { get; private set; }
        public ModsViewModel ModsVM { get; private set; }

        public RelayCommand HomeViewCommand { get; private set; }
        public RelayCommand ModsViewCommand { get; private set; }

        public MainViewModel() {
            HomeVM = new HomeViewModel();
            ModsVM = new ModsViewModel();

            HomeViewCommand = new RelayCommand(o => CurrentView = HomeVM);
            ModsViewCommand = new RelayCommand(o => CurrentView = ModsVM);

            CurrentView = HomeVM;
        }
    }
}
