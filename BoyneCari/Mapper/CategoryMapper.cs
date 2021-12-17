using BoyneCari.Models.Entities;
using BoyneCari.Models.Requests.Category;
using BoyneCari.Models.Responses.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoyneCari.Mapper
{
    public static class CategoryMapper
    {
        public static ResponseGetCategory ToModelGetCategory(this Category entity)
        {
            return new ResponseGetCategory()
            {
               Id=entity.Id,
               Name=entity.Name,
               Description=entity.Description,
            };
        }
        public static List<ResponseGetCategory> ToModelGetCategories(this List<Category> entities)
        {
            return entities.Select(x => new ResponseGetCategory()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToList();
        }

        public static Category ToEntityInsertCategory(this RequestCategoryInsert model)
        {
            return new Category()
            {
                Name=model.Name,
               Description=model.Description,  
            };
        }
    }
}
