using System;
using System.Collections.Generic;
using System.Text;

namespace 责任链模式
{
    /// <summary>
    /// 处理请求抽象类 实现此抽象类的类都是责任链上的一员
    /// </summary>
    abstract public class AbstractManage
    {
        protected AbstractManage abstractManage;
      
        public void setNextManage(AbstractManage a)
        {
           this.abstractManage = a;
        }

        /// <summary>
        /// 处理方法
        /// </summary>
        /// <param name="requestInfo"></param>
        abstract public void Run(RequestInfo requestInfo);
      

    }
}
