using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002单一职责原则实例
{
    public class Terrestrial//陆地生物
    {
        public void Breath(string animalName)
        {
            Console.WriteLine(animalName + "呼吸空气");
        }
    }
    public class Aquatic//水里生物
    {
        public void Breath(string animalName)
        {
            Console.WriteLine(animalName + "呼吸水");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Terrestrial terrestrial = new Terrestrial();
            terrestrial.Breath("牛");
            Aquatic aquatic = new Aquatic();
            aquatic.Breath("鱼  ");
            Console.ReadKey();
        }
    }
}
