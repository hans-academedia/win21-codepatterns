using _04_LSP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LSP.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore _navStore;

        public MainViewModel(NavigationStore navStore)
        {
            _navStore = navStore;
            _navStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public BaseViewModel CurrentViewModel => _navStore.CurrentViewModel;


    }
}
