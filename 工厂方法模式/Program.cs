using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodFactory c = new OrangeFactory();
            Food f1 = c.CreareModel();
            f1.Print();
            FoodFactory c1 = new AppleFactory();
            Food f2 = c.CreareModel();
            f2.Print();
        }
    }
}
