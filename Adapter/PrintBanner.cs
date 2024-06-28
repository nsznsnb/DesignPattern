using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PrintBanner: IPrint
    {
        private Banner _banner;
        public PrintBanner(string str)  
        {
            _banner = new Banner(str);
        }
        public void PrintStrong()
        {
            _banner.ShowWithParen();
        }

        public void PrintWeak()
        {
            _banner.ShowWithAster();
        }
    }
}
