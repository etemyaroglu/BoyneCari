using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;

namespace BoyneCari.Services.RedisCache
{
    public class RedisCache : IRedisCache
    {
        private readonly IDistributedCache _distributedCache;
        public RedisCache(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public T GetData<T>(string key) where T : class
        {
            string data = _distributedCache.GetString(key);
            if (data == null)
                return null;

            return JsonConvert.DeserializeObject<T>(data);

        }
        public void SetData(string key, int minute, object model)
        {
            _distributedCache.SetString(key, JsonConvert.SerializeObject(model), new DistributedCacheEntryOptions() { AbsoluteExpiration = DateTime.Now.AddMinutes(minute) });
        }
        public T GetOrSetData<T>(string key ,int minute, object model) where T : class
        {
            var data =  this.GetData<T>(key);
            if (data==null)
            {
                this.SetData(key, minute, model);
                data = GetData<T>(key);
            }
            return data;
        }
    }
}
