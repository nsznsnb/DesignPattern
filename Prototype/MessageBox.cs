using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MessageBox : IProduct
    {
        private char _decochar;

        public MessageBox(char decochar)
        {
            _decochar = decochar;
        }

        public MessageBox(MessageBox prototype)
        {
            _decochar = prototype._decochar;
        }

        public void Use(string s)
        {
            int decolen = 1 + s.Length + 1;
            for (var i = 0; i < decolen; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine();
            Console.WriteLine(_decochar + s + _decochar);

            for (var i = 0; i < decolen; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine();

        }

        public IProduct CreateCopy()
        {
            return new MessageBox(this);    
        }


    }
}
