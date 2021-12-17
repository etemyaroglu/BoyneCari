using BoyneCari.Models.Entities;
using BoyneCari.Models.Requests.Product;
using BoyneCari.Models.Responses.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoyneCari.Mapper
{
    public static class ProductMapper
    {
        public static ResponseGetProduct ToModelGetProduct(this Product product)
        {
            return new ResponseGetProduct()
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Name = product.Name,
                Description = product.Description,
                Currency = product.Currency,
                Price=product.Price,
            };
        }
        public static List<ResponseGetProduct> ToModelGetProducts(this List<Product> product)
        {
            return product.Select(x=> new ResponseGetProduct()
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                Name = x.Name,
                Description = x.Description,
                Currency = x.Currency,
                Price = x.Price,
            }).ToList();
        }

        public static Product ToEntityInsertProduct(this RequestProductInsert model)
        {
            return new Product()
            {
                CategoryId = model.CategoryId,
                Name = model.Name,
                Description = model.Description,
                Currency = model.Currency,
                Price = model.Price,
            };
        }
    }
}
