using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class SizeVisitor : Visitor
    {
        private int _size = 0;
        public override void Visit(FFile file)
        {
            _size += file.GetSize();
        }

        public override void Visit(DDirectory directory)
        {
            foreach (var entry in directory)
            {
                entry.Accept(this);
            }
        }

        public int GetSize()
        {
            return _size;
        }
    }
}
