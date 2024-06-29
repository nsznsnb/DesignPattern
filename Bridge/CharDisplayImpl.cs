using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class CharDisplayImpl : DisplayImpl
    {
        private readonly char _ch;
        private readonly char _startCh;
        private readonly char _endCh;

        public CharDisplayImpl(char startCh, char ch, char endCh)
        {
            _ch = ch;
            _startCh = startCh;
            _endCh = endCh;
        }

        public override void RawOpen()
        {
            Console.Write(_startCh);
        }
        public override void RawPrint()
        {
            Console.Write(_ch);
        }
        public override void RawClose()
        {
            Console.WriteLine(_endCh);
        }

    }
}
