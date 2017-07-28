using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class ThreeOfAKindCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasNumberOfKind(3, hand))
            {
                return HandRanking.ThreeOfAKind;
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
