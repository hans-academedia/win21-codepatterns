namespace _03_FRONTEND.Models
{
    public class HomeIndexViewModel
    {
        private readonly HttpClient _client;

        public HomeIndexViewModel(HttpClient client)
        {
            GetData().ConfigureAwait(false);
            _client = client;
        }

        public IEnumerable<Product> Products { get; set; }
        public User User { get; set; }


        public async Task GetData()
        {
            Products = await _client.GetFromJsonAsync<IEnumerable<Product>>("https://localhost/api/products");
            User = await _client.GetFromJsonAsync<User>("https://localhost/api/user/1");
        }
    }
}
