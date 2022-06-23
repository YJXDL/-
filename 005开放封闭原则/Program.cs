using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005开放封闭原则
{
    public interface Fruit
    {
        void Plant();
        void Blossom();
        void Outcome();
    }
    class Apple : Fruit
    {
        public Apple()
        {
            this.Plant();
            this.Blossom();
            this.Outcome();
        }
        public void Plant()
        {
            Console.WriteLine("种树A");
        }
        public void Blossom()
        {
            Console.WriteLine("开花A");

        }
        public void Outcome()
        {
            Console.WriteLine("收获A");
        }
    }

    public class Pear : Fruit
    {
       public Pear()
        { 
            this.Plant();
            this.Blossom();
            this.Outcome();
        }
        public void Plant()
        {
            Console.WriteLine("种树P");
        }
        public void Blossom()
        {
            Console.WriteLine("开花P");

        }
        public void Outcome()
        {
            Console.WriteLine("收获P");
        }
    }
    public interface GardenerBase
    {
        Fruit GetFruit();
    }

    public class AppleGardener : GardenerBase
    {
        private static AppleGardener appleGardenerSingleton;
        private AppleGardener()
        {

        }
        public static AppleGardener GetGardener()
        {
            if (appleGardenerSingleton == null)
            {
                appleGardenerSingleton = new AppleGardener();
            }
            return appleGardenerSingleton;
        }
        public Fruit GetFruit()
        {
            return new Apple();
        }
    }

    public class PearGardener : GardenerBase
    {
        public static PearGardener pearGardenerSingleton;
        private PearGardener() { }
        public static PearGardener GetPearGardener()
        {
            if (pearGardenerSingleton == null)
            {
                pearGardenerSingleton = new PearGardener();
            }
            return pearGardenerSingleton;
        }
        public Fruit GetFruit()
        {
            return new Pear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit tempApple;
            GardenerBase appleGarden = AppleGardener.GetGardener();
            tempApple = appleGarden.GetFruit();

            Fruit tempPear;
            GardenerBase pearGarden = PearGardener.GetPearGardener();
            tempPear = pearGarden.GetFruit();
            Console.ReadKey();
        }
    }
}
