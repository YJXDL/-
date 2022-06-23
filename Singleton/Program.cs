using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Bad code! Do not use!
    public  class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {

        }
        public void Test01()
        {

        }

        public int Test02()
        {
            return 1;
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Singleton.Instance.Test01();
            int b = Singleton.Instance.Test02();
        }
    }
}
