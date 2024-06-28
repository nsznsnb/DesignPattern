using Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileProperties : IFileIO
    {
        private NameValueCollection _collection = new NameValueCollection();
        public string GetValue(string key)
        {
            throw new NotImplementedException();
        }

        public void ReadFromFile(string filename)
        {
            _collection = Properties.Properties.Load(filename);
        }

        public void SetValue(string key, string value)
        {
            _collection[key] = value;
        }

        public void WriteToFile(string filename)
        {
            Properties.Properties.Store(_collection, filename);
        }
    }
}
