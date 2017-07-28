using System;
using ChainOfResponsibilityV2.PokerModels;
using System.Collections.Generic;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public class FullHouseCatagorizer : HandCategorizer
    {
        public override HandRanking Categorize(Hand hand)
        {
            Dictionary<Value, int> cardViewed = new Dictionary<Value, int>();

            foreach (Card c in hand.Cards)
            {
                if (cardViewed.ContainsKey(c.Value))
                {
                    cardViewed[c.Value]++;
                }
                else
                {
                    cardViewed[c.Value] = 1;
                }
            }

            if (cardViewed.Count == 2)
            {
                if (cardViewed.ContainsValue(3) && cardViewed.ContainsValue(2))
                {
                    return HandRanking.FullHouse;
                }
            }
            return ToNextHandCategory.Categorize(hand);
        }
    }
}
