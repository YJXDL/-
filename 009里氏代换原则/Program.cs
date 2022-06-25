using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009里氏代换原则
{
    public class A
    {
        public virtual int Func(int x,int y)
        {
            return x + y;
        }
    }
    public class B:A
    {
        public override int Func(int x, int y)
        {
            return x - y;//违反了里氏替换原则，直接重写了父类的Func虚拟方法，引用父类的地方并不能透明使用子类的对象。
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            Console.WriteLine("10 + 5 = "+a.Func(10, 5));
            Console.ReadKey();
        }
    }
}
