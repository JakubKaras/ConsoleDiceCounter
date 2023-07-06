using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiceCounter
{
    internal class Player
    {
        private string _name;
        private int _score;
        private int _consecutiveZeros;
        private List<int> _throws;
        private int _numOfThrowsToQuickDeath;
        public string Name { get { return _name; } }
        public int Score { get { return _score; } }

        public Player(string name, int numOfThrowsToQuickDeath)
        {
            _name = name;
            _numOfThrowsToQuickDeath = numOfThrowsToQuickDeath;
            _throws = new List<int>();
            _score = 0;
            _consecutiveZeros = 0;
        }

        private bool IsPlayerDead() { return _consecutiveZeros == _numOfThrowsToQuickDeath;}

        public void IncreaseScore(int addend)
        {
            _throws.Add(addend);
            if (addend == 0)
            { 
                _consecutiveZeros++;
            }
            if (this.IsPlayerDead())
            {
                _score = 0;
                _consecutiveZeros = 0;
                return;
            }
            _score += addend;
        }
        public override string ToString()
        {
            return $"{_name}: {_score} ({_throws[_throws.Count() - 1]})";
        }
    }
}
