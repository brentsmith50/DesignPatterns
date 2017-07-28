using ChainOfResponsibilityV2.PokerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityV2
{
    class Program
    {
        static readonly Dictionary<HandRanking, int> ranks = new Dictionary<HandRanking, int>();

        static void Main(string[] args)
        {
            Hand[] hands = new Hand[10];
            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < hands.Length; i++)
            {
                hands[i] = new Hand();
            }

            for (int cardCount = 0; cardCount < 5; cardCount++)
            {
                foreach (var hand in hands)
                {
                    hand.Add(deck.Deal());
                }
            }

            foreach (Hand hand in hands)
            {
                Console.WriteLine("{0} ({1})", hand.Rank, hand);
            }

            Console.ReadLine();
        }
    }
}
