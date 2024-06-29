using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class UnderlinePen : IProduct
    {
        private char _ulchar;
        public UnderlinePen(char ulchar)
        {
            _ulchar = ulchar;
        }

        public UnderlinePen(UnderlinePen prototype)
        {
            this._ulchar = prototype._ulchar;
        }

        public void Use(string s)
        {
            int ulen = s.Length;
            Console.WriteLine(s);
            for (var i = 0; i < ulen; i++)
            {
                Console.Write(_ulchar);
            }
            Console.WriteLine();
        }

        public IProduct CreateCopy()
        {
            return new UnderlinePen(this);
        }
    }
}
