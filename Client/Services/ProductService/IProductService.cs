using StationeryPlus.Shared;

namespace StationeryPlus.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;

        // for indivudial products
        List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);

        //for from url
        Task<ServiceResponse<Product>> GetProduct(int productId);

        //When we switch the categories it won't know the change happened and product won't get refresged due to lifecycle method oninitaalized
        //so we switch to onparameterset and fire an event



    }
}
