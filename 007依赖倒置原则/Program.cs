using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007依赖倒置原则
{
    public interface Reader
    {
        string GetContent();
    }

    public class Book: Reader
    {
        public string GetContent()
        {
            return "很久很久以前有一个寺庙";
        }
    }
    public class Newspaper: Reader
    {
        public string GetContent()
        {
            return "春节到了，中国人民欢度新年";
        }
    }
    public class Mother
    {
        public void Narrate(Reader reader)
        {
            Console.WriteLine("妈妈讲故事");
            Console.WriteLine(reader.GetContent());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mother mother = new Mother();
            mother.Narrate(new Book());
            mother.Narrate(new Newspaper());
            Console.ReadKey();
        }
    }
}
