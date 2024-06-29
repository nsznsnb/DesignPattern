using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Entry
    {
        private Entry? _parent;
        public abstract string GetName();
        public abstract int GetSize();

        public void SetParent(Entry parent)
        {
            this._parent = parent;
        }

        public void PrintList()
        {
            PrintList("");
        }

        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return GetName() + " (" + GetSize() + ")";
        }

        public string GetFullPath()
        {
            var fullNameHierarchy = new List<string>();
            Entry entry = this;
            do
            {
                fullNameHierarchy.Insert(0,entry.GetName());
                entry = entry._parent;
            } while(entry != null);
            return string.Join("/",fullNameHierarchy);
        }
    }
}
