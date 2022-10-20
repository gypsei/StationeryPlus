using StationeryPlus.Shared;

namespace StationeryPlus.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

    }
}
