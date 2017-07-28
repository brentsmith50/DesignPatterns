using Microsoft.Practices.Unity;
using SingletonPattern.Interfaces;
using SingletonPattern.Models;
using SingletonPattern.Models.Factories;

namespace SingletonPattern
{
    public class UnityDependencyResolver
    {
        private static readonly IUnityContainer container;

        static UnityDependencyResolver()
        {
            container = new UnityContainer();
            IoC.Initialize(container);
        }

        public IUnityContainer Container
        {
            get { return container; }
        }

        public void EnsureDependenciesRegistered()
        {
            // Change the factory types to test or get different results
            container.RegisterType<IFileLoggerFactory, LazySingletonFileLoggerFactory>();
            container.RegisterType<IDelayConfig, DefaultDelayConfig>();
        }

    }
}
