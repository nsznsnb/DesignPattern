using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class UpDownBorder : Border
    {
        private char _ch;
        public UpDownBorder(Display display, char ch):base(display)
        {
            _ch = ch;
        }

        public override int GetColumns()
        {
            return _display.GetColumns();
        }

        public override int GetRows()
        {
            return 1 + _display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return new string(_ch,_display.GetColumns());
            }
            else if (row == _display.GetRows()+1)
            {
                return new string(_ch, _display.GetColumns());
            }
            else
            {
                return _display.GetRowText(row-1); 
            }
        }
    }
}
