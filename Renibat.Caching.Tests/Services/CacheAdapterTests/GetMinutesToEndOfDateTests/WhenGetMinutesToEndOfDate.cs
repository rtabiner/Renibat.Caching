using System;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests.GetMinutesToEndOfDateTests
{
    public abstract class WhenGetMinutesToEndOfDate : WhenTestingTheCacheAdapter
    {
        protected int ReturnedMinutes { get; set; }
        protected DateTime FromDate { get; set; }
    }
}
