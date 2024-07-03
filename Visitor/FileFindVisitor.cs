using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class FileFindVisitor : Visitor
    {
        private List<FFile> _files = new List<FFile>();
        private string _extension;

        public FileFindVisitor(string extension)
        {
            _extension = extension;
        }
        public override void Visit(FFile file)
        {
            if (file.GetName().EndsWith(_extension))
            {
                _files.Add(file);
            }
        }

        public override void Visit(DDirectory directory)
        {
            foreach (Entry entry in directory)
            {
                entry.Accept(this);
            }
        }

        public List<FFile> GetFoundFiles()
        {
            return _files;
        }
    }
}
