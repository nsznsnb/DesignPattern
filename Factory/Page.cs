using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Page
    {
        protected string _title;
        protected string _author;
        protected List<Item> _content = new List<Item>();

        public Page(string title, string author)
        {
            this._title = title;
            this._author = author;
        }

        public void Add(Item item)
        {
            _content.Add(item);
        }

        public void Output(string fileName)
        {
            File.WriteAllText(fileName, MakeHTML());
            Console.WriteLine(fileName + " を作成しました。");
        }

        public abstract string MakeHTML();
          
    }
}
