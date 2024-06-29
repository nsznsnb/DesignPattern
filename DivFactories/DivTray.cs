using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivFactories
{
    public class DivTray : Tray
    {
        public DivTray(string caption) : base(caption) { }
        public override string MakeHTML()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<p><b>{_caption}</b></p>");
            sb.Append("<div class=\"TRAY\">");
            foreach (var item in _tray)
            {
                sb.Append(item.MakeHTML());
            }
            sb.AppendLine("</div>\n");

            return sb.ToString();
        }
    }
}
