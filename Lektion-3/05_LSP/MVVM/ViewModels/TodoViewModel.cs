using _05_LSP.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LSP.MVVM.ViewModels
{
    public partial class TodoViewModel : ObservableObject
    {
        public TodoViewModel()
        {
            todos = new ObservableCollection<TodoModel>();
        }

        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private ObservableCollection<TodoModel> todos;

        [RelayCommand]
        private void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Todos.Add(new TodoModel { Text = text });
            Text = string.Empty;
        }
    }
}
