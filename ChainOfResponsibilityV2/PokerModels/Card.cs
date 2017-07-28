using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityV2.PokerModels
{
    public class Card
    {
        #region Init

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public Suit Suit { get; private set; }
        public Value Value { get; private set; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return ValueToString() + SuitToString();
        }

        private string SuitToString()
        {
            switch (Suit)
            {
                case Suit.Diamond:
                    return "Diamond";
                case Suit.Club:
                    return "Club";
                case Suit.Heart:
                    return "Heart";
                case Suit.Spade:
                    return "Spade";
                default:
                    return "Suit not found.";
            }
        }

        private string ValueToString()
        {
            switch (Value)
            {
                case Value.Two:
                    return "2";
                case Value.Three:
                    return "3";
                case Value.Four:
                    return "4";
                case Value.Five:
                    return "5";
                case Value.Six:
                    return "6";
                case Value.Seven:
                    return "7";
                case Value.Eight:
                    return "8";
                case Value.Nine:
                    return "9";
                case Value.Ten:
                    return "10";
                case Value.Jack:
                    return "J";
                case Value.Queen:
                    return "Q";
                case Value.King:
                    return "K";
                case Value.Ace:
                    return "A";
                default:
                    return "Couldn't find a card.";
            }
        }
        #endregion
    }
}
