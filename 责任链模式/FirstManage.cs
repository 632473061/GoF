using System;
using System.Collections.Generic;
using System.Text;

namespace 责任链模式
{
    public class FirstManage : AbstractManage
    {
        public override void Run(RequestInfo requestInfo)
        {
            Console.WriteLine("我是处理者：FirstManage");
            Console.WriteLine("任务类型："+requestInfo.Type);
            if (requestInfo.Type == "任务类型1")
            {
                Console.WriteLine(string.Format("执行任务：给[{0}]某个属性加{1}", requestInfo.Name, requestInfo.Number));
            }
            else
            {
                Console.WriteLine("我是没有权限处理，转到下一个处理者");
                abstractManage.Run(requestInfo);
            }
        }
    }
}
