using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibilityV2.PokerModels
{
    public class Deck
    {
        #region Init
        public Deck()
        {
            Cards = new Queue<Card>();

            const int suitMin = (int)Suit.Diamond;
            const int suitMax = (int)Suit.Spade;

            const int cardMin = (int)Value.Two;
            const int cardMax = (int)Value.Ace;


            for (int suit = suitMin; suit <= suitMax; suit++)
            {
                for (int value = cardMin; value <= cardMax; value++)
                {
                    Cards.Enqueue(new Card((Suit)suit, (Value)value));
                }
            }
        }

        public Queue<Card> Cards { get; set; }
        #endregion

        #region Methods

        public Card Deal()
        {
            return Cards.Dequeue();
        }

        public void Shuffle()
        {
            Shuffle(7);
        }

        public void Shuffle(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Queue<Card> newDeck = new Queue<Card>(Cards.OrderBy(g => Guid.NewGuid()));
                Cards = newDeck;
            }
        }

        #endregion

    }
}
