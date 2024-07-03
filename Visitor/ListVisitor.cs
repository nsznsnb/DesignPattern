using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ListVisitor : Visitor
    {
        private string _currentDir = "";
        public override void Visit(FFile file)
        {
            Console.WriteLine(_currentDir + "/" + file);
        }

        public override void Visit(DDirectory directory)
        {
            Console.WriteLine(_currentDir + "/" + directory);
            string saveDir = _currentDir;
            _currentDir = _currentDir + "/" + directory.GetName();
            foreach (Entry entry in directory)
            {
                entry.Accept(this);
            }
            _currentDir = saveDir;
        }
    }
}
