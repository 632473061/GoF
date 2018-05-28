using System;
using System.Collections.Generic;
using System.Text;

namespace 责任链模式
{
    public  class RequestInfo
    {
        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 请求者名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
    }
}
