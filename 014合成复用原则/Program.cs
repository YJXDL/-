using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014合成复用原则
{
    public class Mouth
    {

    }
    public class Head
    {
        private Mouth mouth;
        public Head()
        {
            mouth = new Mouth();
        }
    }
    public class Car
    {
        private Engine engine;
        public Car(Engine engine)
        {
            this.engine = engine;
        }
        public void SetEngine(Engine engine)
        {
            this.engine = engine;
        }
    }
    public class IOS
    {
        public IOS()
        {

        }
    }
    public class iPhone5
    {
        private IOS ios;
        public iPhone5(IOS ios)
        {
            this.ios = ios;
        }
        public void CreateiPhone5()
        {
            Console.WriteLine("我有一台iPhone5搭载IOS操作系统");
        }
    }
    public class Engine
    {

    }

    public class Fish
    {
        public Fish CreateFish()
        {
            Console.WriteLine("这里有水，水里有鱼");
            return new Fish();
        }
    }

    class Water
    {
        private Fish fish;
        public Water(Fish myfish)
        {
            this.fish = myfish;
        }
        public void CreateWater()
        {
            fish.CreateFish();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Water myWater = new Water(new Fish());
            myWater.CreateWater();

            iPhone5 myiPhone5 = new iPhone5(new IOS());
            myiPhone5.CreateiPhone5();
            Console.ReadKey();
        }
    }
}
