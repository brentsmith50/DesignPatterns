using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class StraightFlushCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasStraight(hand) && HasFlush(hand))
            {
                return HandRanking.StraightFlush;
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
