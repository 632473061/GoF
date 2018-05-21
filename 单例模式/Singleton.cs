using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class Singleton
    {
        private static Singleton _s = null;

        private static object locker = new object();
        /// <summary>
        /// 私有构造函数保证不能外部不能通过new关键词实例化对象 单例模式核心
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// 公共静态方法暴露出对象
        /// </summary>
        /// <returns></returns>
        public static Singleton CreateInstance()
        {
            //两次判空提高性能 
            if (_s == null)
            {
                //通过加锁 保证多线程下单例模式仍然有效
                lock (locker)
                {
                    if (_s == null)
                    {
                        _s = new Singleton();
                    }
                }
            }
            return _s;
        }
    }
}
