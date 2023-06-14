using CWMM2.Core;
using System;
using System.Windows;
using System.Windows.Input;

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

        public RelayCommand QuitCommand { get; private set; }
        public RelayCommand DragCommand { get; private set; }

        public HomeViewModel HomeVM { get; private set; }
        public ModsViewModel ModsVM { get; private set; }

        public RelayCommand HomeViewCommand { get; private set; }
        public RelayCommand ModsViewCommand { get; private set; }

        public MainViewModel() {
            QuitCommand = new RelayCommand(o => Environment.Exit(0));
            DragCommand = new RelayCommand(o => MessageBox.Show(o.GetType().FullName));

            HomeVM = new HomeViewModel();
            ModsVM = new ModsViewModel();

            HomeViewCommand = new RelayCommand(o => CurrentView = HomeVM);
            ModsViewCommand = new RelayCommand(o => CurrentView = ModsVM);

            CurrentView = HomeVM;
        }
    }
}
