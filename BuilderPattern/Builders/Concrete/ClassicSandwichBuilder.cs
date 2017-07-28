using System.Collections.Generic;

namespace BuilderPattern
{
    public class ClassicSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Ham;
            sandwich.CheeseType = CheeseType.American;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce" };
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
        }
    }
}
