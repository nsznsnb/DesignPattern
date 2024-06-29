using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DDirectory : Entry
    {
        private string _name;
        private List<Entry> _directory = new List<Entry>();

        public DDirectory(string name)
        {
            this._name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (Entry entry in _directory)
            {
                size += entry.GetSize();
            }
            return size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);

            foreach (Entry entry in _directory)
            {
                entry.PrintList(prefix + "/" + _name);
            }
        }

        public Entry Add(Entry entry)
        {
            _directory.Add(entry);
            entry.SetParent(this);
            return this;
        }
    }
}
