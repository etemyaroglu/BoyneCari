using BoyneCari.Data;
using BoyneCari.Data.Repositories.Products;
using BoyneCari.Models.Entities;
using BoyneCari.Models.Requests.Product;
using BoyneCari.Models.Responses.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoyneCari.Mapper;

namespace BoyneCari.Services.Products
{
    public class ProductService : IProductService
    {
        #region .ctor
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        public async Task<ResponseGetProduct> GetProductByIdAsync(Guid id)
        {
            var product = await _productRepository.GetAsync(id);
            if (product == null)
                return null;
            return product.ToModelGetProduct();
        }

        public List<ResponseGetProduct> GetProducts()
        {
            return _productRepository.GetAll().ToList().ToModelGetProducts();
        }

        public List<ResponseGetProduct> GetProductsFilter(RequestProductFilter model)
        {
            var query = _productRepository.GetQueryable();
            if (!string.IsNullOrEmpty(model.Name))
                query = query.Where(x => x.Name.ToLower().Contains(model.Name.ToLower()));
            if (!string.IsNullOrEmpty(model.Description))
                query = query.Where(x => x.Description.ToLower().Contains(model.Description.ToLower()));
            return query.ToList().ToModelGetProducts();

        }

        public Guid InsertProduct(RequestProductInsert model)
        {
            //TODO: IsExist product Category validation
            //TODO: Currency validation
            
            var product = _productRepository.Insert(model.ToEntityInsertProduct());
            return product.Id;
        }

        public Guid UpdateProduct(Guid id, RequestProductUpdate model)
        {
            var product = _productRepository.Get(id);
            product.Name = model.Name;
            product.Description = model.Description;
            product.CategoryId = model.CategoryId;
            product.Price = model.Price;
            product.Currency = model.Currency;
            _productRepository.Update(product);
            return product.Id;
        }
        public void DeleteProductById(Guid id)
        {
            _productRepository.Delete(id);
        }


    }
}
