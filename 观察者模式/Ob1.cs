using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public class Ob1 : IObserver
    {
        private Subject _subject;
        public Ob1(Subject s)
        {
            this._subject = s;
        }
        public void Execute()
        {
            string a = $"我是观察者[{typeof(Ob1).Name}],我收到通知了,被观察者状态{_subject.state}";
          
            Console.WriteLine(a);

            Console.WriteLine("我可以根据被观察者的状态做一些其它事……");
        }
    }
}
