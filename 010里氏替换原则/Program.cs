using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010里氏替换原则
{
    public class A
    {
        public int Func(int x, int y)
        {
            return x + y;
        }
    }
    public class B : A
    {
        public int Func1(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine("10 - 5 = " + b.Func1(10, 5));
            Console.WriteLine("10 + 5 = " + b.Func(10, 5));

            // A b = new B();
            //   Console.WriteLine("10 + 5 = " + b.Func(10, 5));
            Console.ReadKey();
        }
    }
}
