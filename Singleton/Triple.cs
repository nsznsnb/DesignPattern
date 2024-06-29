using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Triple
    {
        private string _name;
        private static Dictionary<string, Triple> _triples = new Dictionary<string, Triple>()
        {
            {"ALPHA",  new Triple("ALPHA")},
            {"BETA",  new Triple("BETA")},
            {"GAMMA",  new Triple("GAMMA")},

        };


        private Triple(string name)
        {
            _name = name;
        }

        public static Triple GetInstance(string name)
        {
            return _triples[name];
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
