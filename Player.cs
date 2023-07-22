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
        public string Name { get { return _name; } }
        public int Score { get { return _score; } }
        public int ConsecutiveZeros { get { return _consecutiveZeros; } }

        public Player(string name)
        {
            _name = name;
            _throws = new List<int>();
            _score = 0;
            _consecutiveZeros = 0;
        }

        public void ResetScore()
        { 
            _score = 0;
            _consecutiveZeros = 0;
        }

        public void IncreaseScore(int addend)
        {
            _throws.Add(addend);
            if (addend == 0)
            { 
                _consecutiveZeros++;
            }
            _score += addend;
        }
        public override string ToString()
        {
            return $"{_name}: {_score} ({_throws[_throws.Count() - 1]})";
        }
    }
}
