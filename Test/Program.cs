using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        //子类可以替换掉父类，软件的功能不受影响，父类才能真正地被复用
        static void Main(string[] args)
        {
            Animal animal1 = new Cat();
            Animal animal2 = new Calf();
            animal1.Eat();
            animal2.Eat();
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract void Eat();
    }
    public class Cat:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("小猫在吃东西！");
        }
    }
    public class Calf : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("小牛在吃东西！");
        }
    }
}
