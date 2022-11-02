using System.Net.Http.Json;

namespace StationeryPlus.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;

        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            //var result = new ServiceResponse<Product>();
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
                return result;

        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") : await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;

            //Invoke our event so that every component that subscribed to the event will know sth has been changed let's do something
            ProductsChanged.Invoke();
        }

    }
}
