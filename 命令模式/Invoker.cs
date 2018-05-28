using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
   public class Invoker
    {
        private AbstractCommand abstractCommand;
        public void setCommand(AbstractCommand c)
        {
            Console.WriteLine("设置命令");
            abstractCommand = c;
        }
        public void ExcutedCommand()
        {
            if (abstractCommand != null)
            {
                Console.WriteLine("执行命令");
                abstractCommand.Executed();
            }
            else
            {
                Console.WriteLine("当前无命令");
            }
        }


    }
}
