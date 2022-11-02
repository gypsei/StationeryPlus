using StationeryPlus.Shared;

namespace StationeryPlus.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        // for indivudial products
        List<ProductCategory> Categories { get; set; }

        Task GetCategories();

        //for from url
        Task<ServiceResponse<ProductCategory>> GetCategory(int categoryId);
    }
}
