using StationeryPlus.Shared;
using System.Net.Http.Json;

namespace StationeryPlus.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<ProductCategory> Categories { get; set; } = new List<ProductCategory>();

        public async Task<ServiceResponse<ProductCategory>> GetCategory(int categoryId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<ProductCategory>>($"api/Category/{categoryId}");
            
            return result;


        }

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<ProductCategory>>>("api/Category");
            if(response != null && response.Data != null)
                Categories = response.Data;

        }
    }
}
