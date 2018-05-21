using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
   public class Apple:Food
    {
        public override void Print()
        {
            Console.WriteLine("我是苹果");
        }
    }
}
