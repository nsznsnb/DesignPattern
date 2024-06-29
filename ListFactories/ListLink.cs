using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactories
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url) 
        {
        }

        public override string MakeHTML()
        {
            return "  <li><a href=\"" + _url + "\">" + _caption + "</a></li>\n";
        }
    }
}
