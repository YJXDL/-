using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//里氏代替原则(Liskov Substitution Principle):指的是子类必须替换掉它们的父类型。也就是说，在软件开发过程中，子类替换父类后，程序的行为是一样的。只有当子类替换掉父类后，此时软件的功能不受影响时，父类才能真正地被复用，而子类也可以在父类的基础上添加新的行为。为了就来看看违反了LSP原则的例子，具体代码如下所示：

namespace Liskov_Substitution_Principle1
{
    // 四边形
    public abstract class Quadrangle
    {
        public virtual long Width { get; set; }
        public virtual long Height { get; set; }
    }
    // 矩形
    public class Rectangle : Quadrangle
    {
        public override long Height { get; set; }

        public override long Width { get; set; }

    }
    // 正方形
    public class Square : Quadrangle
    {
        public long _side;

        public Square(long side)
        {
            _side = side;
        }
    }

    class Test
    {
        public void Resize(Quadrangle r)
        {
            while (r.Height >= r.Width)
            {
                r.Width += 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Square(10);
            new Test().Resize(s);
        }
    }
}
