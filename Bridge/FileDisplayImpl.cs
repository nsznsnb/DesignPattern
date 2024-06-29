using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class FileDisplayImpl : DisplayImpl
    {
        private string _filePath;

        public FileDisplayImpl(string filePath)
        {
            _filePath = filePath;
        }

        public override void RawOpen()
        {
            Console.WriteLine($"======={_filePath}=========");
        }

        public override void RawPrint()
        {
            var list = File.ReadAllLines(_filePath);
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public override void RawClose()
        {
            Console.WriteLine("=========================================");
        }
    }
}
