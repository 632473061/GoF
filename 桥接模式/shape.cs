using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 形状抽象类
    /// </summary>
    public abstract class shape
    {
        public abstract void show(color c);
       

    }

    /// <summary>
    /// 颜色抽象类
    /// </summary>
    public abstract class color
    {
        public abstract void print();
        
    }
}
