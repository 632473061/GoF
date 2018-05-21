using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class Ob2 : IObserver
    {
        void IObserver.Execute()
        {
            string a = $"我是被通知者[{typeof(Ob2).Name}],我收到通知了，我不需要知道被观察者状态";
            Console.WriteLine(a);
        }
    }
}
