using System;

namespace FactoryPatternSimple
{
    public class BMW335 : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("The BMW was turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The BMW was turned and is running.")
;        }
    }
}
