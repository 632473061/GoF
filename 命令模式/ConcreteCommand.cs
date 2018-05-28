using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    public class ConcreteCommand : AbstractCommand
    {
        public ConcreteCommand(Receiver r) : base(r)
        {
        }
        public override void Executed()
        {
            Console.WriteLine("这里是具体命令1");
            receiver.Run();
        }
    }
}
