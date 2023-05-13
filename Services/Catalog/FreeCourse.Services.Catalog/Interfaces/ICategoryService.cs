using FreeCourse.Services.Catalog.DTO;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Interfaces
{
    internal interface ICategoryService
    {
        Task<Response<List<CategoryDTO>>> GetAllAsync();
        Task<Response<CategoryDTO>> CreateAsync(Category category);
        Task<Response<CategoryDTO>> GetCategoryByIdAsync(string id);
    }
}
