using System;
using Renibat.Caching.Services.Interfaces;
using System.Web.Helpers;

namespace Renibat.Caching.Services
{
    public class CacheAdapter : ICacheAdapter
    {
        public void Cache(string key, object item, int minutesToCache)
        {
            if (item == null)
            {
                throw new InvalidOperationException("Object to be cached cannot be null");
            }

            WebCache.Set(key, item, minutesToCache, false);
        }

        public void CacheToEndOfDate(string key, object item, DateTime date)
        {
            if (item == null)
            {
                throw new InvalidOperationException("Object to be cached cannot be null");
            }

            WebCache.Set(key, item, GetMinutesToEndOfDay(date), false);
        }

        public T Retrieve<T>(string key)
        {
            return (T)WebCache.Get(key);
        }

        public int GetMinutesToEndOfDay(DateTime date)
        {
            var endOfDay = date.Date.AddDays(1);
            var minutesDiff = (endOfDay - date).TotalMinutes;

            return (int)minutesDiff;
        }

        public void Clear(string key)
        {
            WebCache.Remove(key);
        }
    }
}
