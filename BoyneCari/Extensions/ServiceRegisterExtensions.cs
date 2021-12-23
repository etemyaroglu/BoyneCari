using BoyneCari.Services.Categories;
using BoyneCari.Services.Products;
using BoyneCari.Services.RedisCache;
using Microsoft.Extensions.DependencyInjection;

namespace BoyneCari.Extensions
{
    public static class ServiceRegisterExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();          
            services.AddTransient<IRedisCache, RedisCache>();          
        }
    }
}
