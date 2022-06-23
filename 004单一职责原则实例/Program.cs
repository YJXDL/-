using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004单一职责原则实例
{
    class Animal
    {
        public void Breathe1(string name)
        {
            Console.WriteLine(name + "呼吸空气");
        }
        public void Breathe2(string name)
        {
            Console.WriteLine(name + "呼吸水");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myanimal = new Animal();
            myanimal.Breathe1("牛");
            myanimal.Breathe2("鱼");
            Console.ReadKey();
        }
    }
}
