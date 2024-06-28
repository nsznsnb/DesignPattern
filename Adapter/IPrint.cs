using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IPrint
    {
        public abstract void PrintWeak();
        public abstract void PrintStrong();
    }
}
