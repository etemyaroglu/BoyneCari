
using BoyneCari.Models.Entities;

namespace BoyneCari.Data.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        #region .ctor
        public CategoryRepository(IMongoDataContext context) : base(context)
        {

        }
        #endregion
    }
}
