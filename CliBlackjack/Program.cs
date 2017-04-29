using System;

namespace CliBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Deck gameDeck = new Deck();

            gameDeck.CreateDeck(5);
            gameDeck.Shuffle(rnd.Next(2, 5));

            Console.ReadLine();
        }
    }
}