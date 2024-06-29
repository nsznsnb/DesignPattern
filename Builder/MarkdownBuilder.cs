using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MarkdownBuilder : Builder
    {
        private StringBuilder _sb = new StringBuilder();
        private string _fileName = "untitled.md";

        public void MakeTitle(string title)
        {
            _fileName = $"{title}.md";
            _sb.Append($"# {title}");
        }
        public void MakeString(string str)
        {
            _sb.AppendLine(str);
            _sb.AppendLine();
        }

        public void MakeItems(string[] items)
        {
            foreach (string item in items)
            {
                _sb.AppendLine($"   - {item}");
            }
            _sb.AppendLine();
        }


        public void Close()
        {
            _sb.AppendLine("");
            try
            {
                File.WriteAllText(_fileName, _sb.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public string GetMarkdownResult()
        {
            return _fileName;
        }
    }
}
