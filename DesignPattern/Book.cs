using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Book
    {
        private string _name;

        public string Name { get { return _name; } }

        public Book(string name) { 
            this._name = name;
        }
    }
}
