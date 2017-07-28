using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            // The string in this list will need to match the Class name exactly
            //  when using this reflection Method
            List<string> cars = new List<string>
            {
                "MiniCooper",
                "BMW335"
            };

            AutoFactory factory = new AutoFactory();
            
            foreach (string car in cars)
            {
                IAuto auto = factory.CreateInstance(car);
                auto.TurnOn();
                auto.TurnOff();
            }
            Console.ReadLine();
        }
    }
}
