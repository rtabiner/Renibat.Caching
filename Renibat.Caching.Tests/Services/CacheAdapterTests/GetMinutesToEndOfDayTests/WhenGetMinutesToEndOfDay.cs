using System;

namespace ReSystems.Caching.Tests.Services.CacheAdapterTests.GetMinutesToEndOfDayTests
{
    public abstract class WhenGetMinutesToEndOfDay : WhenTestingTheCacheAdapter
    {
        protected int ReturnedMinutes { get; set; }
        protected DateTime FromDate { get; set; }
    }
}
