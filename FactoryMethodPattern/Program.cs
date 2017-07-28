using System;
using System.Reflection;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();
            IAuto car = autoFactory.CreateAutomobile();
            car.TurnOn();
            car.TurnOff();
            Console.ReadLine();
        }

        private static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.MiniFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
