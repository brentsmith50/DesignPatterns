using System;

namespace FactoryMethodPattern
{
    public class MiniCooper : IAuto
    {
        public string Name { get; private set; }


        public void SetName(string name)
        {
            this.Name = name;
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is up and running.");
        }
    }
}
