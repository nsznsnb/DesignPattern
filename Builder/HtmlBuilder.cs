using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HtmlBuilder : Builder
    {
        private string _fileName = "untitled.html";
        private StringBuilder _sb = new StringBuilder();

        public void MakeTitle(string title)
        {
            _fileName = $"{title}.html";
            _sb.AppendLine("<!DOCTYPE html>");
            _sb.AppendLine("<html>");
            _sb.AppendLine($"<head><title>{title}</title></head>");
            _sb.AppendLine("<body>");
            _sb.AppendLine($"<h1>{title}</h1>");

        }
        public void MakeString(string str)
        {
            _sb.AppendLine($"<p>{str}</p>");
        }
        public void MakeItems(string[] items)
        {
            _sb.Append($"<ul>");
            foreach (string item in items)
            {
                _sb.AppendLine($"<li>{item}</li>");   
            }
            _sb.AppendLine("</ul>");
            _sb.AppendLine("");

        }
        public void Close()
        {
            _sb.AppendLine("</body></html>");
            try
            {
                File.WriteAllText(_fileName, _sb.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public string GetHTMLResult()
        {
            return _fileName;
        }



    }
}
