using System;

namespace FactoryPatternAbstract
{
    public class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateEconomyCar()
        {
            return new BMW328i();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public IAutomobile CreateSportsCar()
        {
            return new BMWM3();
        }
    }
}
