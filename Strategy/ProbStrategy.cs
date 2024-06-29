using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ProbStrategy : IStrategy
    {
        private Random _random;
        private int _prevHandValue = 0;
        private int _currentHandValue = 0;
        private int[][] _history = {
            [1,1,1],
            [1,1,1],
            [1,1,1]
        };

        public ProbStrategy(int seed)
        {
            _random = new Random(seed);
        }

        public Hand NextHand()
        {
            int bet = _random.Next(getSum(_currentHandValue));
            int handValue = 0;
            if (bet < _history[_currentHandValue][0])
            {
                handValue = 0;
            }
            else if (bet < _history[_currentHandValue][0] + _history[_currentHandValue][1])
            {
                handValue = 1;
            }
            else
            {
                handValue = 2;
            }
            _prevHandValue = _currentHandValue;
            _currentHandValue = handValue;
            return Hand.GetInstance(handValue);
        }

        private int getSum(int handValue)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += _history[handValue][i];
            }
            return sum;
        }

        public void Study(bool win)
        {
            if (win)
            {
                _history[_prevHandValue][_currentHandValue]++;
            }
            else
            {
                _history[_prevHandValue][(_currentHandValue + 1) % 3]++;
                _history[_prevHandValue][(_currentHandValue + 2) % 3]++;

            }
        }
    }
}
