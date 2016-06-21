
namespace Renibat.Caching.Tests.Models
{
    public class TestCacheObject
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public TestCacheObject(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
