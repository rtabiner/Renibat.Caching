using System;
using NUnit.Framework;

namespace ReSystems.Caching.Tests.Services.CacheAdapterTests.GetMinutesToEndOfDayTests
{
    public class AndTheCorrectMinutesAreReturnedForNormalCases : WhenGetMinutesToEndOfDay
    {
        protected override void Given()
        {
            base.Given();

            FromDate = new DateTime(2014, 11, 8, 12, 0, 0);
        }

        protected override void When()
        {
            ReturnedMinutes = _CacheAdapter.GetMinutesToEndOfDay(FromDate);
        }

        [Test]
        public void TheExpectedMinutesShouldBeReturned()
        {
            Assert.AreEqual(ReturnedMinutes, 720);
        }
    }
}