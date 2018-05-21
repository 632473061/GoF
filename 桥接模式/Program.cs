using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            color c1 = new Orange();
            color c2 = new Red();


            shape s1 = new Rectangle();
            s1.show(c1);
            s1.show(c2);

            shape s2 = new Circle();
            s2.show(c1);
            s2.show(c2);
        }
    }
}
