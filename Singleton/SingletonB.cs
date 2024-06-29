using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SingletonB
    {
        private static SingletonB? _singleton;
        private static readonly object _lockObject = new object();
        private SingletonB()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static SingletonB GetInstance()
        {
            lock(_lockObject)
            {
                if (_singleton == null)
                {
                    _singleton = new SingletonB();
                }
                return _singleton;
            }

        }

        private void slowdown()
        {
            Thread.Sleep(1000);
        }
    }
}
