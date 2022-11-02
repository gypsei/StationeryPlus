using Microsoft.EntityFrameworkCore;
using StationeryPlus.Server.Data;

namespace StationeryPlus.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<ProductCategory>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();

            return new ServiceResponse<List<ProductCategory>>
            {
                Data = categories
            };
        }
    }
}
