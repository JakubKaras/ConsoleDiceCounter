using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiceCounter
{
    internal class Dice
    {
        private int numberOfSides;
        private int numberOfDice;

        public Dice(int numberOfSides, int numberOfDice)
        {
            this.numberOfSides = numberOfSides;
            this.numberOfDice = numberOfDice;
        }

        public int roll()
        {
            Random rnd = new Random();
            int roll = 0;
            for (int i = 0; i < numberOfDice; i++)
                roll += rnd.Next(1, numberOfSides + 1);
            return roll;
        }
    }
}
