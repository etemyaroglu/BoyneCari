using BoyneCari.Models.Responses.Product;
using System.Collections.Generic;

namespace BoyneCari.Services.RedisCache
{
    public interface IRedisCache
    {
        T GetData<T>(string key) where T : class;
        void SetData(string key, int minute, object model);
        T GetOrSetData<T>(string key, int minute, object model) where T : class;
    }
}
