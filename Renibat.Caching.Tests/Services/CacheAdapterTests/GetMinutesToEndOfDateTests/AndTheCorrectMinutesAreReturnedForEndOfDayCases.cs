using System;
using NUnit.Framework;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests.GetMinutesToEndOfDateTests
{
    public class AndTheCorrectMinutesAreReturnedForEndOfDayCases : WhenGetMinutesToEndOfDate
    {
        protected override void Given()
        {
            base.Given();

            FromDate = new DateTime(2014, 11, 8, 23, 59, 10);
        }

        protected override void When()
        {
            ReturnedMinutes = _CacheAdapter.GetMinutesToEndOfDay(FromDate);
        }

        [Test]
        public void TheExpectedMinutesShouldBeReturned()
        {
            Assert.AreEqual(ReturnedMinutes, 0);
        }
    }
}