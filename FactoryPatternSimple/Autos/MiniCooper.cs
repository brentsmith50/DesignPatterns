using System;


namespace FactoryPatternSimple
{
    public class MiniCooper : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Mini Cooper OFF.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Mini Cooper ON.");
        }
    }
}
