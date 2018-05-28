using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
   public class InvokerList
    {
        private List<AbstractCommand> abstractCommand=new List<AbstractCommand>();
        public void setCommand(AbstractCommand c)
        {
            Console.WriteLine("设置命令");
            abstractCommand.Add(c);
        }
        public void unSetCommand(AbstractCommand c)
        {
            Console.WriteLine("撤回命令");
            if (abstractCommand.Contains(c))
            {
                abstractCommand.Remove(c);
            }
           
        }
        public void ExcutedCommand()
        {
            if (abstractCommand!=null&&abstractCommand.Count>0)
            {
                foreach (var item in abstractCommand)
                {
                    Console.WriteLine("执行命令");
                    item.Executed();
                    Console.WriteLine("命令执行完成");
                }
            }
            else
            {
                Console.WriteLine("当前无命令");
            }
        }


    }
}
