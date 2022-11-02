namespace StationeryPlus.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        public Task<ServiceResponse<List<ProductCategory>>> GetCategories();
    }
}
