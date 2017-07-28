using ChainOfResponsibilityV2.PokerModels;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibilityV2.HandCategorizeModels
{
    public abstract class HandCategorizer
    {
        protected HandCategorizer ToNextHandCategory { get; private set; }
        public abstract HandRanking Categorize(Hand hand);

        #region Methods
        public HandCategorizer RegisterNextHandCategory(HandCategorizer nextHandCategory)
        {
            this.ToNextHandCategory = nextHandCategory;
            return ToNextHandCategory;
        }

        protected static bool HasNumberOfKind(int numberOfCardsViewed, Hand hand)
        {
            Dictionary<Value, int> cardsViewed = new Dictionary<Value, int>();

            foreach (Card card in hand.Cards)
            {
                if (cardsViewed.ContainsKey(card.Value))
                {
                    cardsViewed[card.Value]++;
                }
                else
                {
                    cardsViewed[card.Value] = 1;
                }
            }

            foreach (int count in cardsViewed.Values)
            {
                if (count == numberOfCardsViewed)
                {
                    return true;
                }
            }
            return false;
        }

        protected static bool HasStraight(Hand hand)
        {
            List<Value> values = hand.Cards.Select(c => c.Value).ToList();
            values.Sort();

            int expectedValue = (int)values[0];

            foreach (Value value in values)
            {
                if ((int)value != expectedValue)
                {
                    return false;
                }
                expectedValue++;
            }
            return true;
        }

        protected static bool HasFlush(Hand hand)
        {
            List<Suit> suits = hand.Cards.Select(c => c.Suit).ToList();
            suits.Sort();

            Suit expected = suits[0];

            return suits.All(suit => suit == expected);
        }
        #endregion
    }
}
