using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012接口隔离原则
{
    class Program
    {
        public interface I
        {
            void Method1();
            void Method2();
            void Method3(); 
            void Method4(); 
            void Method5();
        }
        public class A 
        {
            public void Depend1(I i)
            {
                i.Method1();
            }
            public void Depend2(I i)
            {
                i.Method2();
            }
            public void Depend3(I i)
            {
                i.Method3();
            }

        }
        public class B:I
        {
            public void Method1()
            {
                Console.WriteLine("类B实现接口I的方法1");
            }
            public void Method2()
            {
                Console.WriteLine("类B实现接口I的方法2");
            }
            public void Method3()
            {
                Console.WriteLine("类B实现接口I的方法3");
            }
            public void Method4()
            {
            }
            public void Method5()
            {
            }
        }
        class C
        {
            public void Depend1(I i)
            {
                i.Method1();
            }
            public void Depend4(I i)
            {
                i.Method4();
            }
            public void Depend5(I i)
            {
                i.Method5();
            }
        }
        class D:I
        {
            public void Method1()
            {
                Console.WriteLine("类D实现接口I的方法1");
            }
            public void Method2()
            {
            }
            public void Method3()
            {
            }
            public void Method4()
            {
                Console.WriteLine("类D实现接口I的方法4");
            }
            public void Method5()
            {
                Console.WriteLine("类D实现接口I的方法5");
            }
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.Depend1(new B());
            a.Depend2(new B());
            a.Depend3(new B());
            C c = new C();
            c.Depend1(new D());
            c.Depend4(new D());
            c.Depend5(new D());
            Console.ReadKey();
        }
    }
}
