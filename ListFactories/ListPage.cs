using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactories
{
    public class ListPage : Page
    {
        public ListPage(string title, string author): base(title, author) { }
        public override string MakeHTML()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine($"<html><head><title>{_title}</title></head>");
            sb.AppendLine("<body>");
            sb.AppendLine($"<h1>{_title}</h1>");
            sb.AppendLine("<ul>");
            foreach (var item in _content)
            {
                sb.Append(item.MakeHTML());
            }
            sb.AppendLine("</ul>");
            sb.AppendLine($"<hr><address>{_author}</author></address>");
            sb.AppendLine("</body></html>");
            return sb.ToString();
        }
    }
}
