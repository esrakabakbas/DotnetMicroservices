using FreeCourse.Services.Catalog.DTO;
using FreeCourse.Services.Catalog.Interfaces;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return CreateActionResultInstance(categories);
        }

        public async Task<IActionResult> CreateAsync(CategoryDTO categoryDTO)
        {
            var response = await _categoryService.CreateAsync(categoryDTO);
            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var categories = await _categoryService.GetCategoryByIdAsync(id);
            return CreateActionResultInstance(categories);
        }


    }
}
