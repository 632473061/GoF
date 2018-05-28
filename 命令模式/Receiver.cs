using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    //接收者：具体命令执行者 可继承抽象类或实现接口方法
    public class Receiver
    {
        public void Run()
        {
            Console.WriteLine("真实执行者：做事情1");
        }
        public void Run1()
        {
            Console.WriteLine("真实执行者：做事情2");
        }

    }
}
