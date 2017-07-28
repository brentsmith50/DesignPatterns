using System.Collections.Generic;
using ChainOfResponsibilityV2.PokerModels;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class TwoPairCategorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            Dictionary<Value, int> cardViewed = new Dictionary<Value, int>();

            foreach (Card card in hand.Cards)
            {
                if (cardViewed.ContainsKey(card.Value))
                {
                    cardViewed[card.Value]++;
                }
                else
                {
                    cardViewed[card.Value] = 1;
                }
            }

            if (cardViewed.Count == 3)
            {
                int twoViewed = 0;
                int oneViewed = 0;

                foreach (var value in cardViewed.Values)
                {
                    switch (value)
                    {
                        case 1:
                            oneViewed++;
                            break;
                        case 2:
                            twoViewed++;
                            break;
                        default:
                            break;
                    }
                }
                if (oneViewed == 1 && twoViewed == 2)
                {
                    return HandRanking.TwoPair;
                }
            }

            return ToNextHandCategory.Categorize(hand);
        }
    }
}
