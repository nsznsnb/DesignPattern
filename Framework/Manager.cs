using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Manager
    {
        private Dictionary<string, IProduct> _showCase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct prototype)
        {
            _showCase[name] = prototype;
        }

        public IProduct Create(string prototypeName)
        {
            IProduct p = _showCase[prototypeName];
            return p.CreateCopy();
        }
    }
}
