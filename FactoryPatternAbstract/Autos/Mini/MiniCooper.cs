using System;

namespace FactoryPatternAbstract
{
    public class MiniCooper : IAutomobile
    {
        private string name;

        public MiniCooper()
        {
            name = "Mini Cooper";
        }

        public void AddSportPackage()
        {
            name += "S ";
        }

        public void AddLuxuryPackage()
        {
            name += "with leather upholstery";
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + name + " is on!");
        }

        public void TurnOn()
        {
            Console.WriteLine("The Mini Cooper is has turned off.");
        }
    }
}
