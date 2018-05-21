using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{

    /// <summary>
    /// 抽象被观察者
    /// 提供对抽象观察者的新增删除和执行
    /// </summary>
   public abstract class  AbstractSubject
    {
        public List<IObserver> observers;

        public AbstractSubject()
        {
            observers = new List<IObserver>();
        }
        public virtual void AddObserver(IObserver ob)
        {
            if (!observers.Contains(ob))
            {
                observers.Add(ob);
            }
        }
          

        public virtual void RemoveObserver(IObserver ob)
        {
            observers.Remove(ob);
        }
        public virtual void Update()
        {
            if (observers != null)
            {
                foreach (var item in observers)
                {
                    item.Execute();
                }
            }
        }


    }
}
