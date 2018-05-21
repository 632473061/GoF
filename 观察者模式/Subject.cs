using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 具体被观察者
    /// </summary>
    public class Subject : AbstractSubject
    {
        /// <summary>
        /// 被观察者状态
        /// </summary>
       public string state { get; set; }
    }
}
