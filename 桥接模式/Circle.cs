﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
   public class Circle:shape
    {
        public override void show(color c)
        {
            Console.Write("我是圆形，");
            c.print();
        }
    }
}
