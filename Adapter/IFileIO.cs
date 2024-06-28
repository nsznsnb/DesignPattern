using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IFileIO
    {
        public void ReadFromFile(string filename);
        public void WriteToFile(string filename);
        public void SetValue(string key, string value);
        public string GetValue(string key);
    }
}
