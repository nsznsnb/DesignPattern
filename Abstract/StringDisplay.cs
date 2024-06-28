using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class StringDisplay : IDisplay
    {
        private readonly string _str;

        public StringDisplay(string str)
        {
            this._str = str;
        }

        public void Open()
        {
            printLine();
        }


        public void Print()
        {
            Console.WriteLine($"|{this._str}|");
        } 

        public void Close()
        {
            printLine();
        }

        private void printLine()
        {
            Console.WriteLine($"+{string.Join("",Enumerable.Repeat("-",_str.Length))}+");
        }
    }
}
