using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiceCounter
{
    internal class Dice
    {
        private int _numberOfSides;
        private int _numberOfDice;
        private Random _random;
        public int NumberOfSides { get { return _numberOfSides; } }
        public int NumberOfDice { get { return _numberOfDice; } }

        public Dice(int numberOfSides, int numberOfDice)
        {
            _numberOfSides = numberOfSides;
            _numberOfDice = numberOfDice;
            _random = new Random();
        }

        public int Roll()
        {
            int roll = 0;
            for (int i = 0; i < _numberOfDice; i++)
                roll += _random.Next(1, _numberOfSides + 1);
            return roll;
        }
    }
}
