using NUnit.Framework;
using Renibat.Caching.Tests.Models;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests.CacheAndRetrieveTests
{
    public class WhenCallingCache : WhenStoringAndRetrieving
    {
        protected override void Given()
        {
            base.Given();

            Key = "TestCache123";
            MinutesToCache = 60;
            TestObject = new TestCacheObject("RE Systems", 45);
        }

        protected override void When()
        {
            _CacheAdapter.Cache(Key, TestObject, MinutesToCache);
            TestRetrievedObject = _CacheAdapter.Retrieve<TestCacheObject>(Key);
        }

        [Test]
        public void ThenRetrievedObjectMatchesStoredObject()
        {
            Assert.That(TestRetrievedObject, Is.EqualTo(TestObject));
        }
    }
}
