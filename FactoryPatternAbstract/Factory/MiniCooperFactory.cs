using System;

namespace FactoryPatternAbstract
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAutomobile CreateEconomyCar()
        {
            return new MiniCooper();
        }

        public IAutomobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();
            mini.AddLuxuryPackage();
            return mini;
        }

        public IAutomobile CreateSportsCar()
        {
            var mini = new MiniCooper();

            mini.AddSportPackage();
            return mini;

        }
    }
}
