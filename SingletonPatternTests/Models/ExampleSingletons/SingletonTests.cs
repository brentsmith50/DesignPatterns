using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonPattern.Models.ExampleSingletons.Tests
{
    [TestClass()]
    public class SingletonTests
    {
        [TestMethod()]
        public void ReturnSameInstance()
        {
            Singleton firstInstance = Singleton.Instance;
            Singleton secondInstance = Singleton.Instance;

            Assert.AreSame(firstInstance, secondInstance);
        }
        
    }
}