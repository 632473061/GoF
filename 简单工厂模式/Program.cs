﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Food m1 = ModelFactory.CreateModel("Apple");
            m1.Print();

            Food m2 = ModelFactory.CreateModel("Orange");
            m2.Print();
        }
    }
}
