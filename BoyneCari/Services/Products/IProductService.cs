using BoyneCari.Models.Requests.Product;
using BoyneCari.Models.Responses.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoyneCari.Services.Products
{
    public interface IProductService
    {
        Task<ResponseGetProduct> GetProductByIdAsync(Guid id);
        List<ResponseGetProduct> GetProducts();
        List<ResponseGetProduct> GetProductsFilter(RequestProductFilter model);
        Guid InsertProduct(RequestProductInsert model);
        Guid UpdateProduct(Guid id,RequestProductUpdate model);
        void DeleteProductById(Guid id);
    }
}
