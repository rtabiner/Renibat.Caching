using Renibat.Caching.Services;
using Renibat.Caching.Tests.Core;

namespace Renibat.Caching.Tests.Services.CacheAdapterTests
{
    public abstract class WhenTestingTheCacheAdapter : SpecBase
    {
        protected CacheAdapter _CacheAdapter { get; set; }
        protected override void Given()
        {
            base.Given();

            _CacheAdapter = new CacheAdapter();
        }
    }
}
