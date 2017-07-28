using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class PairCategorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasNumberOfKind(2, hand))
            {
                return HandRanking.Pair;
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
