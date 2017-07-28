using System;

namespace CompositePattern
{
    public class Person : IParty
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Statistics()
        {
            Console.WriteLine("{0} has {1} gold coins", Name, Gold);
        }
    }
}
