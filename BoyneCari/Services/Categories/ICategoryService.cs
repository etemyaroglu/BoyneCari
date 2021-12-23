using BoyneCari.Models.Requests.Category;
using BoyneCari.Models.Responses.Category;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoyneCari.Services.Categories
{
    public interface ICategoryService
    {
        Task<ResponseGetCategory> GetCategoryByIdAsync(string id);
        List<ResponseGetCategory> GetCategories();
        List<ResponseGetCategory> GetCategoryFilter(RequestCategoryFilter model);
        string InsertCategory(RequestCategoryInsert model);
        string UpdateCategory(string id, RequestCategoryUpdate model);
        void DeleteCategoryById(string id);
    }
}
