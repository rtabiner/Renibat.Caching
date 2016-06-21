using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ReSystems.Caching.Tests.Services.CacheAdapterTests.GetMinutesToEndOfDayTests
{
    public class AndTheCorrectMinutesAreReturnedForMidnightCases : WhenGetMinutesToEndOfDay
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
