using AutoMapper;
using FreeCourse.Services.Catalog.Config;
using FreeCourse.Services.Catalog.DTO;
using FreeCourse.Services.Catalog.Interfaces;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.DTO;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryConnection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _categoryConnection = database.GetCollection<Category>(databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }


        public async Task<Response<List<CategoryDTO>>> GetAllAsync()
        {
            var categories = await _categoryConnection.Find(cat => true).ToListAsync();
            return Response<List<CategoryDTO>>.Success(_mapper.Map<List<CategoryDTO >> (categories), 200);
        }

        public async Task<Response<CategoryDTO>> CreateAsync(Category category)
        {
            await _categoryConnection.InsertOneAsync(category);
            return Response<CategoryDTO>.Success(_mapper.Map<CategoryDTO> (category), 200);
        }

        public async Task<Response<CategoryDTO>> GetCategoryByIdAsync(string id)
        {
            var category = await _categoryConnection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if(category == null)
            {
                return Response<CategoryDTO>.Fail("Category not found", 400);
            }
            return Response<CategoryDTO>.Success(_mapper.Map<CategoryDTO>(category), 200);
        }
    }
}
