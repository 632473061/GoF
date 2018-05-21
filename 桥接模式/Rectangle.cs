using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public class Rectangle : shape
    {
        public override void show(color c)
        {
            Console.Write("我是矩形，");
            c.print();
        }
    }
}
