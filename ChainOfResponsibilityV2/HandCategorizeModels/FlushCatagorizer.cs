using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class FlushCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            if (HasFlush(hand))
            {
                return HandRanking.Flush;
            }
            return ToNextHandCategory.Categorize(hand); ;
        }
    }
}
