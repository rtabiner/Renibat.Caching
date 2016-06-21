using System;
using NUnit.Framework;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests.GetMinutesToEndOfDateTests
{
    public class AndTheCorrectMinutesAreReturnedForMidnightCases : WhenGetMinutesToEndOfDate
    {
        protected override void Given()
        {
            base.Given();

            FromDate = new DateTime(2014, 11, 8);
        }

        protected override void When()
        {
            ReturnedMinutes = _CacheAdapter.GetMinutesToEndOfDay(FromDate);
        }

        [Test]
        public void TheExpectedMinutesShouldBeReturned()
        {
            Assert.AreEqual(ReturnedMinutes, 1440);
        }
    }
}
