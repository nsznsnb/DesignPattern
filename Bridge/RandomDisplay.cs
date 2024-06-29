using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RandomDisplay : CountDisplay
    {
        public RandomDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void RRandomDisplay(int times)
        {
            base.MultiDisplay(new Random().Next(times));
        }
    }
}
