using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string _str;
        private int _width;

        public StringDisplayImpl(string str)
        {
            this._str = str;
            this._width = str.Length;
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("|" + _str + "|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (var i = 0; i < _width; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("+");

        }

    }
}
