using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonPattern.Models.ExampleSingletons.Tests
{
    [TestClass()]
    public class LazySingletonTests
    {
        [TestMethod()]
        public void LazySingletonTest()
        {
            LazySingleton firstInstance = LazySingleton.Instance;
            LazySingleton secondInstance = LazySingleton.Instance;

            Assert.AreSame(firstInstance, secondInstance);
        }
    }
}