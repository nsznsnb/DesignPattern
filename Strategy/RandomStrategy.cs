using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RandomStrategy : IStrategy
    {
        private readonly Random _random;

        public RandomStrategy(int seed)
        {
            _random = new Random(seed);
        }
        public Hand NextHand()
        {
            return Hand.GetInstance(_random.Next(3));
        }

        public void Study(bool win)
        {
        }
    }
}
