using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003单一职责原则实例
{
    class Animal
    {
        public void Breathe(string name)
        {
            if("鱼".Equals(name))
            {
                Console.WriteLine(name + "呼吸水");
            }
            else
            {
                Console.WriteLine(name + "呼吸空气");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Breathe("鱼");
            animal.Breathe("牛");
            Console.ReadKey();
        }
    }
}
