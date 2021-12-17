using BoyneCari.Data;
using BoyneCari.Data.Repositories.Categories;
using BoyneCari.Data.Repositories.Products;
using Microsoft.Extensions.DependencyInjection;

namespace BoyneCari.Extensions
{
    public static class RepositoryRegisterExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
        }
    }
}
