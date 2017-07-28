namespace FactoryPatternAbstract
{
    public class NullAuto : IAutomobile
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOff()
        {
            
        }

        public void TurnOn()
        {
            
        }
    }
}
