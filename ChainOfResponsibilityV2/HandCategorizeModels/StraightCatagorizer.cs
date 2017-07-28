using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class StraightCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasStraight(hand))
            {
                return HandRanking.Straight;
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
