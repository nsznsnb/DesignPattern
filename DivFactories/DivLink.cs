using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivFactories
{
    public class DivLink : Link
    {
        public DivLink(string caption, string url) : base(caption, url) { }
        public override string MakeHTML()
        {
            return "<div class=\"Link\"><a href=\"" + _url + "\">" + _caption + "</a></div>\n";
        }
    }
}
