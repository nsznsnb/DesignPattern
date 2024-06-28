using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface Iterable<E>
    {
        public abstract Iterator<E> Iterator();
    }
}
