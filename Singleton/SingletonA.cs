using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonA
    {
        private static SingletonA _singleton = new SingletonA();

        private SingletonA()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static SingletonA GetInstance()
        {
            return _singleton;
        }
    }
}
