using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface Iterator<E>
    {
        public abstract Boolean HasNext();
        public abstract E Next();
    }
}
