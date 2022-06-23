using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton1
{
    //sealed应用于某个类时，sealed修饰符可阻止其他类继承自该类
    public sealed class Singleton
    {
        int a = 1;

        private static Singleton instance = null;

        private Singleton()
        {

        }
        public void Test1() { a++; }
        public static Singleton GetInstance( )
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
    class Program
    {
        void test(ref int a)
        {
            a++;
        }
        static void Main(string[] args)
        {
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();
            //  Singleton.
            instance1.Test1();
            instance2.Test1();
            if (instance1 == instance2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");

            }
            else
            {
                Console.WriteLine("ingleton failed, variables contain different instances.");
            }
            Console.ReadKey();
        }

    }
}
