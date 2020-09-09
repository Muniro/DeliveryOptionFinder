using System;
using System.Threading.Tasks;

namespace DeliveryOptionFinder.Cache
{
    public interface ICacheService
    {
        T GetOrSet<T>(string cacheKey, Func<T> getItemCallback) where T : class;
    }
}
