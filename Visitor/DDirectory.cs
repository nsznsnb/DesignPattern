using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class DDirectory : Entry, IEnumerable<Entry>
    {
        private string _name;
        private List<Entry> _directories = new List<Entry>();

        public DDirectory(string name)
        {
            this._name = name;
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }

        public IEnumerator<Entry> GetEnumerator()
        {
            return new CustomEnumerator(_directories);
        }

        public Entry Add(Entry entry)
        {
            _directories.Add(entry);
            return this;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            var v = new SizeVisitor();
            Accept(v);
            return v.GetSize();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class CustomEnumerator : IEnumerator<Entry>
        {
            private List<Entry> _list;
            private int _position = -1;

            public CustomEnumerator(List<Entry> list)
            {
                _list = list;
            }

            public Entry Current
            {
                get
                {
                    try
                    {
                        return _list[_position];
                    }
                    catch (Exception)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                _position++;
                return (_position < _list.Count);
            }

            public void Reset()
            {
                _position = -1;
            }
        }

    }
}
