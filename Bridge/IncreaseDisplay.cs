using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class IncreaseDisplay : CountDisplay
    {
        private int _step;
        public IncreaseDisplay(DisplayImpl impl,int step) : base(impl)
        {
            _step = step;
        }

        public void IIncreaseDisplay(int level)
        {
            int count = 0;
            for (int i = 0; i < level; i++)
            {
                MultiDisplay(count);
                count += _step;
            }
        }
    }
}
