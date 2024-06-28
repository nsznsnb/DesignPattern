using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class CharDisplay : IDisplay
    {
        private readonly char _ch;
        public CharDisplay(char ch) {
            this._ch = ch;
        }

        public void Open()
        {
            Console.Write("<<");
        }

        public void Print()
        {
            Console.Write(_ch);
        }

        public void Close()
        {
            Console.WriteLine(">>");
        }

    }
}
