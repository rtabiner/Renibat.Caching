using System;
using Renibat.Caching.Tests.Models;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests.CacheAndRetrieveTests
{
    public abstract class WhenStoringAndRetrieving : WhenTestingTheCacheAdapter
    {
        protected string Key { get; set; }
        protected int MinutesToCache { get; set; }
        protected DateTime Date { get; set; }
        protected TestCacheObject TestObject { get; set; }
        protected TestCacheObject TestRetrievedObject { get; set; }
    }
}
