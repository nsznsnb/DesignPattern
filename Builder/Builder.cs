using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface Builder
    {
        public void MakeTitle(string title);
        public void MakeString(string str);
        public void MakeItems(string[] items);
        public void Close();
    }
}
