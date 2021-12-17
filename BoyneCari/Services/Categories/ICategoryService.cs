using BoyneCari.Models.Requests.Category;
using BoyneCari.Models.Responses.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoyneCari.Services.Categories
{
    public interface ICategoryService
    {
        Task<ResponseGetCategory> GetCategoryByIdAsync(Guid id);
        List<ResponseGetCategory> GetCategories();
        List<ResponseGetCategory> GetCategoryFilter(RequestCategoryFilter model);
        Guid InsertCategory(RequestCategoryInsert model);
        Guid UpdateCategory(Guid id, RequestCategoryUpdate model);
        void DeleteCategoryById(Guid id);
    }
}
