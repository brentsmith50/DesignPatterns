using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityV2.PokerModels
{
    public class Hand
    {
        #region Fields
        private readonly List<Card> cards = new List<Card>();
        private HandRanking rank = HandRanking.Unknown;

        public IEnumerable<Card> Cards
        {
            get { return cards; }
        }

        public HandRanking Rank
        {
            get { return rank; }
        }

        public Card HighCard
        {
            get
            {
                if (cards.Count == 0)
                {
                    throw new InvalidOperationException();
                }
                return cards[cards.Count - 1];
            }
        }
        #endregion

        #region Methods

        public void Add(Card card)
        {
            // THIS LOGIC seems flawed to me that is why I have commented this out
            //if (cards.Count == 5)
            //{
            //    throw new InvalidOperationException("There is a five card limit.");
            //}
            cards.Add(card);

            if (cards.Count == 5)
            {
                rank = HandCategorizeModels.HandCatagorizerChain.GetRank(this);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Card card in cards)
            {
                sb.AppendFormat("{0} ", card);
            }
            return sb.ToString();
        }
        #endregion
    }
}
