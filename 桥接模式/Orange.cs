using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public class Orange : color
    {
        public override void print()
        {
            Console.WriteLine("我的颜色是橘色");
        }
    }

    public class Red : color
    {
        public override void print()
        {
            Console.WriteLine("我的颜色是红色");
        }
    }
}
