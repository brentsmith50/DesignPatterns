using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonPattern.Interfaces;
using SingletonPatternTests;
using System.IO;

namespace SingletonPattern.Models.Factories.Tests
{
    [TestClass()]
    public class MultipleThreadsFileLoggerTests
    {

        #region Init
        private IUnityContainer container;
        private INumbersToTextFile numbersToTextFile;

        [TestInitialize]
        public void Setup()
        {
            File.Delete("logfile.txt");
            container = new UnityContainer();
            container.RegisterType<INumbersToTextFile, NumbersToTextFile>();
            container.RegisterType<IDelayConfig, TestDelayConfig>();
            IoC.Initialize(container);
        }

        private void LogNumbers()
        {
            numbersToTextFile = container.Resolve<INumbersToTextFile>();
            numbersToTextFile.MaxIntegerToWrite = 1000;
            numbersToTextFile.WriteNumbersToFile();
        }
        #endregion

        [TestMethod()]
        public void LogNumbersWithInstanceFileLogger()
        {
            container.RegisterType<IFileLoggerFactory, InstanceFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod()]
        public void LogNumbersWithSingletonFileLogger()
        {
            container.RegisterType<IFileLoggerFactory, SingletonFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithLockedSingletonFileLogger()
        {
            container.RegisterType<IFileLoggerFactory, LockedSingletonFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithDoubleCheckLockedSingletonFileLogger()
        {
            container.RegisterType<IFileLoggerFactory, DoubleCheckLockedSingletonFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithLazySingletonFileLogger()
        {
            container.RegisterType<IFileLoggerFactory, LazySingletonFileLoggerFactory>();
            LogNumbers();
        }
    }
}