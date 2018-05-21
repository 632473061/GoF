using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    public class Orange: Food
    {
       public override void Print()
       {
           Console.WriteLine("我是橘子");
       }
    }
}
