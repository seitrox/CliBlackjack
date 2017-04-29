using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliBlackjack
{
    class Dealer
    {
        public int handTotal = 0;
        List<Card> hand = new List<Card>();

        public void GetCards(List<Card> Deck)
        {
            hand.Add(Deck[0]);
            Deck.RemoveAt(0);
            _CalcHandTotal();
        }

        private void _CalcHandTotal()
        {
            int aceCount = 0;
            foreach (var card in hand)
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