using System;

namespace Renibat.Caching.Services.Interfaces
{
    public interface ICacheAdapter
    {
        void Cache(string key, object item, int minutesToCache);
        void CacheToEndOfDate(string key, object item, DateTime date);
        void Clear(string key);
        T Retrieve<T>(string key);
    }
}
