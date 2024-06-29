using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder _sb = new StringBuilder();
        public  void MakeTitle(string title)
        {
            _sb.AppendLine("=============================");
            _sb.AppendLine($"『{title}』");

        }

        public  void MakeString(string str)
        {
            _sb.Append($"■{str}\n\n");
        }
        public  void MakeItems(string[] items)
        {
            foreach (string item in items)
            {
                _sb.AppendLine($"   ・{item}");
            }
            _sb.AppendLine();
        }


        public  void Close()
        {
            _sb.AppendLine("=============================");
        }

        public string GetTextResult()
        {
            return _sb.ToString();
        }
    }
}
