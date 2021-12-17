using BoyneCari.Models.Entities;

namespace BoyneCari.Data.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        #region .ctor
        public ProductRepository(IMongoDataContext context) : base(context)
        {

        }
        #endregion
    }
}
