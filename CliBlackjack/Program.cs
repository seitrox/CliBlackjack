using System;

namespace CliBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (game.moreGames)
            {
                game.PlayGame();
            }
            
        }
    }
}