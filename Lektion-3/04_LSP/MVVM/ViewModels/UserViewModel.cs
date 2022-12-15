using _04_LSP.Helpers;
using _04_LSP.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LSP.MVVM.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private readonly NavigationStore _navStore;
        public UserViewModel(NavigationStore navStore)
        {
            Users = new ObservableCollection<UserModel>();
            _navStore = navStore;
        }

        private ObservableCollection<UserModel> users;
        public ObservableCollection<UserModel> Users
        {
            get { return users; }
            set 
            { 
                users = value;
                OnPropertyChanged();
            }
        }

    }
}
