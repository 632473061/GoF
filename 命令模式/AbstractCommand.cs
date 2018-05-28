using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
   public abstract class AbstractCommand
    {
        protected Receiver receiver;
        public AbstractCommand(Receiver r)
        {
            this.receiver = r;
        }

        abstract public void Executed();
        
    }
}
