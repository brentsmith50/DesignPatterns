using System.Collections.Generic;

namespace BuilderPattern
{
    public class ClubSandwich : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Turkey;
            sandwich.CheeseType = CheeseType.Swiss;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.French;
        }
    }
}
