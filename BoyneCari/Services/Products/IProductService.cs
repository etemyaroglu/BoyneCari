using BoyneCari.Models.Requests.Product;
using BoyneCari.Models.Responses.Product;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoyneCari.Services.Products
{
    public interface IProductService
    {
        Task<ResponseGetProduct> GetProductByIdAsync(string id);
        List<ResponseGetProduct> GetProducts();
        List<ResponseGetProduct> GetProductsFilter(RequestProductFilter model);
        string InsertProduct(RequestProductInsert model);
        string UpdateProduct(string id,RequestProductUpdate model);
        void DeleteProductById(string id);
    }
}
