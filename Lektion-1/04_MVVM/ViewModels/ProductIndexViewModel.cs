using _04_MVVM.Models;

namespace _04_MVVM.ViewModels
{
    public class ProductIndexViewModel
    {
        public UserModel CurrentUser { get; set; } = null!;
        public List<ProductModel>? Latest { get; set; }
        public List<ProductModel>? BestSelling { get; set; }
        public List<ProductModel>? RecentlyWatched { get; set; }
    }
}
