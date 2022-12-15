using _04_MVVM.Models;

namespace _04_MVVM.ViewModels
{
    public class ProductDetailsViewModel
    {
        public UserModel User { get; set; } = null!;
        public ProductModel Product { get; set; } = null!;
    }
}
