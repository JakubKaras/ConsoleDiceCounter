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
        private Random random;

        public Dice(int numberOfSides, int numberOfDice)
        {
            this.numberOfSides = numberOfSides;
            this.numberOfDice = numberOfDice;
            random = new Random();
        }

        public int roll()
        {
            int roll = 0;
            for (int i = 0; i < numberOfDice; i++)
                roll += random.Next(1, numberOfSides + 1);
            return roll;
        }
    }
}
