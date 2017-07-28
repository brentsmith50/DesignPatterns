using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class FourOfAKindCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasNumberOfKind(4, hand))
            {
                return HandRanking.FourOfAKind;
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
