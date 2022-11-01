using StationeryPlus.Shared;

namespace StationeryPlus.Client.Services.ProductService
{
    public interface IProductService
    {
        // for indivudial products
        List<Product> Products { get; set; }

        Task GetProducts();

        //for from url
        Task<ServiceResponse<Product>> GetProduct(int productId);

    }
}
