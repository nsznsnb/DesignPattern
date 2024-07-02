using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MultiStringDisplay : Display
    {
        private readonly List<string> _strs = new List<string>();
        public MultiStringDisplay() : base() { }

        public void Add(string str)
        {
            _strs.Add(str); 
        }
        public override int GetColumns()
        {
            return _strs.Max(x => x.Length);
        }

        public override int GetRows()
        {
            return _strs.Count();
        }

        public override string GetRowText(int row)
        {
            return _strs[row].PadRight(GetColumns(), ' ');
        }
    }
}
