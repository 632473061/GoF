using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Subject s = new Subject();



            Subject s = new Subject();
            IObserver ob1 = new Ob1(s);
            IObserver ob2 = new Ob2();
            s.state = "状态1";
            s.AddObserver(ob1);
            s.AddObserver(ob2);

            s.Update();
            s.state = "状态2";
            s.RemoveObserver(ob2);
            s.Update();

            //DelegateSubject ds = new DelegateSubject();
            //ds.Observer += ob1.Execute;
            //ds.Observer += ob2.Execute;
            //ds.Update();
            //ds.Observer -= ob1.Execute;
            //ds.Update();

            Console.Read();
        }
    }
}
