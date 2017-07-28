
namespace FactoryMethodPattern
{
    public class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW("BMW M5 Cabriolet");
        }
    }
}
