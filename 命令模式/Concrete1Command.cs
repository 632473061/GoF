using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    public class Concrete1Command : AbstractCommand
    {
        public Concrete1Command(Receiver r) : base(r)
        { }
        public override void Executed()
        {
            Console.WriteLine("这里是命令2");
            receiver.Run1();
        }
    }
}
