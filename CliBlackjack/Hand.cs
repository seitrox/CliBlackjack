using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliBlackjack
{
    class Hand
    {
        Random rnd = new Random();
        public int handTotal=0;

        List<Card> deck;
        List<Card> hand;

        public Hand(List<Card> Deck)
        {
            deck = Deck;
        }

        public void DrawCard()
        {
            int cardIndex = rnd.Next(deck.Count - 1);
            hand.Add(deck[cardIndex]);
            _CalcHandTotal(hand);

            deck.RemoveAt(cardIndex);
        }

        private void _CalcHandTotal(List<Card> Hand)
        {
            int aceCount=0;
            foreach (var card in Hand)
            {
                if (card.rank == 0)
                {
                    aceCount++;
                }
                else if ((int)card.rank < 10)
                {
                    handTotal += (int)card.rank;
                }
                else
                {
                    handTotal += 10;
                }

            }

            if (aceCount > 0)
            {
                if (handTotal <= (11 - aceCount))
                {
                    handTotal += (aceCount - 1) + 11;
                }
                else
                {
                    handTotal += aceCount;
                }
            }

        }
    }
}
