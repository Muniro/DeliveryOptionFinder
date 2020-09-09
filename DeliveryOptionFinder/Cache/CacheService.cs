using System;
using System.Runtime.Caching;

namespace DeliveryOptionFinder.Cache
{
    public class CacheService:ICacheService
    {

        private ICacheService cachingProvider;
        private readonly CacheOptions options;
      
        private CacheOptions cOptions = new CacheOptions();

        public T GetOrSet<T>(string cacheKey, Func<T> getItemCallback) where T : class
        {
            T item = MemoryCache.Default.Get(cacheKey) as T;
            if (item == null)
            {
                item = getItemCallback();
                MemoryCache.Default.Add(cacheKey, item, DateTime.Now.AddMinutes(10));
            }
            return item;
        }
    }
}
