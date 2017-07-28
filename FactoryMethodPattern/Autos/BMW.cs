using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class BMW : IAuto
    {
        public BMW(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void SetName(string name)
        {
            if (name == null) return;
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
