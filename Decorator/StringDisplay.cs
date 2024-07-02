using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StringDisplay : Display
    {
        private string _str;

        public StringDisplay(string str)
        {
            this._str = str;
        }

        public override int GetColumns()
        {
            return _str.Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            if (row != 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _str;
        }
    }
}
