using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013接口隔离原则
{
    public interface I1
    {
        void Method1();
    }
    public interface I2
    {
        void Method2();
        void Method3();
    }
    public interface I3
    {
        void Method4();
        void Method5();
    }
    class B:I1,I2
    {
        public void Method1()
        {
            Console.WriteLine("B实现I1的方法1");
        }
        public void Method2()
        {
            Console.WriteLine("B实现I2的方法2");
        }
        public void Method3()
        {
            Console.WriteLine("B实现I2的方法3");
        }
    }

    class C : I1, I3
    {
        public void Method1()
        {
            Console.WriteLine("C实现I1的方法1");
        }
        public void Method4()
        {
            Console.WriteLine("C实现I3的方法4");
        }
        public void Method5()
        {
            Console.WriteLine("C实现I3的方法5");
        }
    }

    class D
    {
        public void Depend1(I1 i)
        {
            i.Method1();
        }
        public void Depend3(I3 i)
        {
            i.Method4();
        }
        public void Depend5(I3 i)
        {
            i.Method5();
        }
    }

    class A
    {
        public void Depend1(I1 i)
        {
            i.Method1();
        }
        public void Depend2(I2 i2)
        {
            i2.Method2();
        }
        public void Depend3(I2 i2)
        {
            i2.Method3();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A();
            a.Depend1(b);
            a.Depend2(b);
            C c = new C();
            D d = new D();
            d.Depend1(c);
            d.Depend3(c);
            d.Depend5(c);
            Console.ReadKey();
        }
    }
}
