using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivFactories
{
    public class DivPage : Page
    {
        public DivPage(string title, string author): base(title, author) { }
        public override string MakeHTML()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine($"<html><head><title>{_title}</title><style>");
            sb.AppendLine("div.TRAY { padding:0.5em; margin-left:5em; border:1px solid black; }");
            sb.AppendLine("div.LINK { padding:0.5em; background-color: lightgray; }");
            sb.AppendLine("</style></head></body>");
            sb.AppendLine($"<h1>{_title}</h1>");
            foreach (var item in _content)
            {
                sb.AppendLine(item.MakeHTML());
            }
            sb.AppendLine($"<hr><address>{_author}</address>");
            sb.AppendLine("</body></html>");
            return sb.ToString();
        }
    }
}
