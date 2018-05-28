using System;
using System.Collections.Generic;
using System.Text;

namespace 责任链模式
{
    public class LastManage : AbstractManage
    {
     

        public override void Run(RequestInfo requestInfo)
        {
            Console.WriteLine("我是处理者：LastManage");
            Console.WriteLine("任务类型：" + requestInfo.Type);
            if (requestInfo.Type == "任务类型2")
            {
                Console.WriteLine(string.Format("执行任务：给[{0}]某个属性加{1}", requestInfo.Name, requestInfo.Number));
            }
            else
            {
                Console.WriteLine("我没有权限处理，此请求无法处理，设计不合理了");
                Console.WriteLine("一个请求一定要有处理者处理，如果没有可能导致处理无执行");
                Console.WriteLine("还要避免循环处理导致死循环");
                //abstractManage.Run(requestInfo);
            }
        }
    }
}
