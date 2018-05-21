using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
   public class DelegateSubject
    {
        public ObserverDelegate Observer;

        public void Update()
        {
            Observer.Invoke();
        }

    }
    public delegate void ObserverDelegate();
}
