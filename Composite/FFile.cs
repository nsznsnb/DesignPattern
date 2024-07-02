﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class FFile : Entry
    {
        private string _name;
        private int _size;

        public FFile(string name, int size)
        {
            this._name = name;
            this._size = size;
        }
        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
        }
    }
}