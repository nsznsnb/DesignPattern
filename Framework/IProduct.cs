using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface IProduct
    {
        public void Use(string s);

        public IProduct CreateCopy();
    }
}
