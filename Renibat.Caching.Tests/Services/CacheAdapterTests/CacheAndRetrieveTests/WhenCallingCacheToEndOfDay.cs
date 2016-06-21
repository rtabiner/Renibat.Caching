using System;
using NUnit.Framework;
using Renibat.Caching.Tests.Models;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests.CacheAndRetrieveTests
{
    public class WhenCallingCacheToEndOfDay : WhenStoringAndRetrieving
    {
        protected override void Given()
        {
            base.Given();

            Key = "TestCache123";
            Date = new DateTime(2015, 11, 8, 12, 0, 0);
            TestObject = new TestCacheObject("RE Systems", 45);
        }

        protected override void When()
        {
            _CacheAdapter.CacheToEndOfDate(Key, TestObject, Date);
            TestRetrievedObject = _CacheAdapter.Retrieve<TestCacheObject>(Key);
        }

        [Test]
        public void ThenRetrievedObjectMatchesStoredObject()
        {
            Assert.That(TestRetrievedObject, Is.EqualTo(TestObject));
        }
    }
}
