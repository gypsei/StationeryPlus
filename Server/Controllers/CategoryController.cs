using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StationeryPlus.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        //Web Service Call

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductCategory>>>> GetCategories()
        {
            var result = await _categoryService.GetCategories();
            return Ok(result);
        }
    }
}
