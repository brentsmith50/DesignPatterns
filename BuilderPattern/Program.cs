using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker(new ClassicSandwichBuilder());
            sandwichMaker.BuildSandwich();
            var classicSandwich = sandwichMaker.GetSandwich();

            classicSandwich.Display();

            var sandwichMakerB = new SandwichMaker(new ClubSandwich());
            sandwichMakerB.BuildSandwich();
            var clubSandwich = sandwichMakerB.GetSandwich();

            clubSandwich.Display();

            Console.ReadKey();
        }
    }
}
