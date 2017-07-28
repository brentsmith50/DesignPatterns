using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class HandCatagorizerChain
    {
        private static readonly HandCatagorizerChain instance = new HandCatagorizerChain();

        private HandCatagorizerChain()
        {
            Base = new RoyalFlushCatagorizer();
            Base.RegisterNextHandCategory(new StraightFlushCatagorizer())
                 .RegisterNextHandCategory(new FourOfAKindCatagorizer())
                 .RegisterNextHandCategory(new FullHouseCatagorizer())
                 .RegisterNextHandCategory(new FlushCatagorizer())
                 .RegisterNextHandCategory(new StraightCatagorizer())
                 .RegisterNextHandCategory(new ThreeOfAKindCatagorizer())
                 .RegisterNextHandCategory(new TwoPairCategorizer())
                 .RegisterNextHandCategory(new PairCategorizer())
                 .RegisterNextHandCategory(new HighCardCategorizer());
        }
        
        private HandCategorizer Base { get; set; }

        public static HandRanking GetRank(Hand hand)
        {
            return instance.Base.Categorize(hand);
        }
    }
}
