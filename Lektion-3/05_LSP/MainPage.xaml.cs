using _05_LSP.MVVM.ViewModels;

namespace _05_LSP
{
    public partial class MainPage : ContentPage
    {

        public MainPage(TodoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

    }
}