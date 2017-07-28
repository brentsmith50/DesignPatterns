using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Sandwich
    {
        #region Properties
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }
        #endregion

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", BreadType);
            if (IsToasted)
            {
                Console.WriteLine("Toasted");
            }
            if (HasMayo)
            {
                Console.WriteLine("With mayo");
            }
            if (HasMustard)
            {
                Console.WriteLine("and/or mustard");
            }
            Console.WriteLine("Meat: {0}", MeatType);
            Console.WriteLine("Cheese: {0}", CheeseType);
            Console.WriteLine("Veggies:");
            foreach (string veggie in Vegetables)
            {
                Console.WriteLine("   {0}", veggie);
            }
        }
    }
}
