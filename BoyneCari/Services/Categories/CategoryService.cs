using BoyneCari.Data.Repositories.Categories;
using BoyneCari.Mapper;
using BoyneCari.Models.Requests.Category;
using BoyneCari.Models.Responses.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoyneCari.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        #region .ctor
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        public async Task<ResponseGetCategory> GetCategoryByIdAsync(Guid id)
        {
            var category = await _categoryRepository.GetAsync(id);
            if (category == null)
                return null;
            return category.ToModelGetCategory();
        }

        public List<ResponseGetCategory> GetCategories()
        {
            return _categoryRepository.GetAll().ToList().ToModelGetCategories();
        }

        public List<ResponseGetCategory> GetCategoryFilter(RequestCategoryFilter model)
        {
            var query = _categoryRepository.GetQueryable();
            if (!string.IsNullOrEmpty(model.Name))
                query = query.Where(x => x.Name.ToLower().Contains(model.Name.ToLower()));
           
            return query.ToList().ToModelGetCategories();

        }

        public Guid InsertCategory(RequestCategoryInsert model)
        {
            var category = _categoryRepository.Insert(model.ToEntityInsertCategory());
            return category.Id;
        }

        public Guid UpdateCategory(Guid id, RequestCategoryUpdate model)
        {
            var category = _categoryRepository.Get(id);
            category.Name = model.Name;
            category.Description = model.Description;

            _categoryRepository.Update(category);
            return category.Id;
        }
        public void DeleteCategoryById(Guid id)
        {
            _categoryRepository.Delete(id);
        }


    }
}
