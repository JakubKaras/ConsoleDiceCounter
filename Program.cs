using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleDiceCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(6, 2);
            List<Player> players = new List<Player>
            {
                new Player("wheee"),
                new Player("blahblah")
            };
            Game gameWithoutDice = new Game(players, 2);
            Game gameWithDice = new Game(players, 2, dice);
            for (int i = 0; i < 4; i++)
            {
                gameWithoutDice.PlayTurn();
                Console.WriteLine(gameWithoutDice.ToString());
            }
            Console.ReadLine();
        }
    }
}
