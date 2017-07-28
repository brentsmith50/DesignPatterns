using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class RoyalFlushCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasStraight(hand) && HasFlush(hand) && hand.HighCard.Value == Value.Ace)
            {
                return HandRanking.RoyalFlush;
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
