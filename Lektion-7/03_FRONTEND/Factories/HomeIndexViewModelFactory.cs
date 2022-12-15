namespace _03_FRONTEND.Factories
{
    public interface IHomeIndexViewModelFactory
    {
        HomeIndexViewModelFactory Create();
    }

    public class HomeIndexViewModelFactory : IHomeIndexViewModelFactory
    {
        public HomeIndexViewModelFactory Create()
        {
            return new HomeIndexViewModelFactory();
        }
    }
}
