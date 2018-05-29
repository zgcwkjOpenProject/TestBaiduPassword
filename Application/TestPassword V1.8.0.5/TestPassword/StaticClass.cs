using System;
using System.IO;
using System.Net;
using System.Text;

namespace zgcwkj
{
    /// <summary>
    /// 静态类
    /// </summary>
    public static class StaticClass
    {
        #region 静态字符串

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

        #endregion 静态字符串

        #region 静态方法

        /// <summary>
        /// Get请求
        /// </summary>
        public static string HttpGet(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                return retString;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        #endregion 静态方法
    }
}