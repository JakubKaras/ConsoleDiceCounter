using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiceCounter
{
    internal class Game
    {
        private List<Player> _players;
        private int _throwsToReset;
        private Dice _dice;
        public List<Player> Players { get { return _players; } }
        public Dice Dice { get { return _dice; } }
        public Game(List<Player> players, int throwsToReset, Dice dice)
        {
            _players = players;
            _throwsToReset = throwsToReset;
            _dice = dice;
        }
        public Game(List<Player> players, int throwsToReset)
        {
            _players = players;
            _throwsToReset = throwsToReset;
            _dice = null;
        }
        public Game(List<Player> players)
        {
            _players = players;
            _throwsToReset = 3;
            _dice = null;
        }

        public void PlayTurn()
        {
            foreach (var player in _players)
            {
                if (_dice != null)
                {
                    player.IncreaseScore(_dice.Roll());
                }
                else
                {
                    player.IncreaseScore(GetRoll());
                }
                if (player.ConsecutiveZeros == _throwsToReset)
                    player.ResetScore();
            }
        }
        public static int GetRoll()
        {
            int roll;
            do
            {
                Console.Write("Input roll value: ");
            } while (!int.TryParse(Console.ReadLine(), out roll));
            return roll;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in _players)
                sb.Append($"{player}   ");
            return sb.ToString();
        }
    }
}
