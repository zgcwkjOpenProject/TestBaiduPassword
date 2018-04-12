using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zgcwkj
{
    /// <summary>
    /// 静态类
    /// </summary>
    public static class StaticClass
    {
        /// <summary>
        /// 线程状态
        /// </summary>
        public static bool status { get; set; }
        /// <summary>
        /// 目标连接
        /// </summary>
        public static string url { get; set; }
        /// <summary>
        /// 存放的路径
        /// </summary>
        public static string file { get; set; }
    }
}