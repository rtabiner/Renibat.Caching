using NUnit.Framework;

namespace Renibat.Caching.Tests.Core
{
    [TestFixture]
    public abstract class SpecBase
    {
        [TestFixtureSetUp]
        public void SetUp()
        {
            this.Given();
            this.When();
        }

        protected virtual void Given()
        {
        }

        protected abstract void When();
    }
}
