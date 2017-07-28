using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class HighCardCategorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            return HandRanking.HighCard;
        }
    }
}
