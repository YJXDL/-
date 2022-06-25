using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011里氏代换原则
{
    class Rectangel
    {
        int height;
        int weight;
        public int GetWidth()
        {
            return weight;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetWidth(int width)
        {
            this.weight = width;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        
    }
    class Square:Rectangel
    {
        int size;
        public int GetWidth()
        {
            return size;
        }
        public void SetWidth(int width)
        {
            this.size = width;
        }
        public int GetHeight()
        {
            return size;
        }
        public void SetHeight(int height)
        {
            this.size = height;
        }
        public int GetSize()
        {
            return size;
        }
        public void SetSize(int size)
        {
            this.size = size;
        }
    }
    class Program
    {
        public static void TestRec(Square rec)
        {
            int i = 0;
            while(rec.GetWidth()<=rec.GetHeight())
            {
                rec.SetWidth(rec.GetWidth() + 1);
                Console.WriteLine("循环的次数" + i++);
            }
        }
        static void Main(string[] args)
        {
            Square square = new Square();
            square.SetWidth(5);
            square.SetHeight(10);
            TestRec(square);
            Console.ReadKey();
        }
    }
}
