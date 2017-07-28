using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonPattern;
using SingletonPattern.Interfaces;
using SingletonPattern.Models;
using SingletonPattern.Models.FIleLoggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Tests
{
    [TestClass()]
    public class UnityDependencyResolverTests
    {
        #region Initialize
        private UnityContainer container;

        [TestInitialize]
        public void Setup()
        {
            container = new UnityContainer();
            IoC.Initialize(container);
            container.RegisterType<IDelayConfig, DefaultDelayConfig>();
        }
        #endregion


        [TestMethod()]
        [ExpectedException(typeof(ResolutionFailedException))]
        public void ReturnNeInstanceByDefault()
        {
            container.RegisterType<IFileLogger, FileLogger>();

            var firstInstance = container.Resolve<IFileLogger>();
            var secondInstance = container.Resolve<IFileLogger>();

            Assert.AreNotSame(firstInstance, secondInstance);
        }

        [TestMethod()]
        public void ReturnSameInstanceWhenConfigured()
        {
            container.RegisterType<IFileLogger, FileLogger>(new ContainerControlledLifetimeManager());

            var firstInstance = container.Resolve<IFileLogger>();
            var secondInstance = container.Resolve<IFileLogger>();

            Assert.AreSame(firstInstance, secondInstance);
        }
    }
}