using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactories
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption) { }
        public override string MakeHTML()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<li>");
            sb.AppendLine(_caption);
            sb.AppendLine("<ul>");
            foreach (var item in _tray)
            {
                sb.Append(item.MakeHTML());
            }
            sb.AppendLine("</ul>");
            sb.AppendLine("</li>");
            return sb.ToString();
        }
    }
}
