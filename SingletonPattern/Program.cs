using Microsoft.Practices.Unity;
using SingletonPattern.Interfaces;
using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        #region Fields
        private const bool useParallel = true;
        private static UnityDependencyResolver dependencyResolver;
        private static INumbersToTextFile numbersToTextFile;
        #endregion

        private static void RegisterTypes()
        {
            dependencyResolver = new UnityDependencyResolver();
            dependencyResolver.EnsureDependenciesRegistered();
            if (useParallel)
            {
                dependencyResolver.Container.RegisterType<INumbersToTextFile, NumbersToTextFileAsync>();
            }
            else
            {
                dependencyResolver.Container.RegisterType(typeof(INumbersToTextFile), typeof(NumbersToTextFile));
            }
        }

        static void Main(string[] args)
        {
            RegisterTypes();
            File.Delete("logfile.txt");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            numbersToTextFile = dependencyResolver.Container.Resolve<INumbersToTextFile>();
            numbersToTextFile.MaxIntegerToWrite = 100;
            numbersToTextFile.WriteNumbersToFile();

            stopwatch.Stop();
            Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
            Console.ReadLine();

        }
    }
}
