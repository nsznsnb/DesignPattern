using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Entry : Element
    {

        public abstract string GetName();
        public abstract int GetSize();

        public override string ToString()
        {
            return GetName() + " (" + GetSize() + ")";
        }

        public abstract void Accept(Visitor v);

    }
}
