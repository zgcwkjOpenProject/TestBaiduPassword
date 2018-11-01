using System;
using System.IO;
using System.Net;
using System.Text;

namespace zgcwkj
{
    /// <summary>
    /// Http测试类(百度网盘分享连接密码测试)
    /// </summary>
    public class HttpTest
    {
        private string info = "";//唯一识别文件的值

        /// <summary>
        /// 实例测试类
        /// </summary>
        /// <param name="url">访问的链接</param>
        public HttpTest(string url)
        {
            info = "surl=" + url.Replace("https", "").Replace("http", "").Replace("://pan.baidu.com/", "").Replace("share/init?surl=", "").Replace("s/1", "");
        }

        /// <summary>
        /// 访问网页
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return HttpGet("https://pan.baidu.com/share/init?" + info);
        }

        /// <summary>
        /// 提交密码
        /// </summary>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public string Post(string pwd)
        {
            DateTime time = DateTime.Now;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            string ts = ((time.Ticks - startTime.Ticks) / 10000).ToString();

            string url = "https://pan.baidu.com/share/verify?" + info + "&t=" + ts.ToString() + "&bdstoken=null&channel=chunlei&clienttype=0&web=1&app_id=123456&logid=MTUwMTEyNDM2OTY5MzAuOTE5NTU5NjQwMTk0NDM0OA==";
            string data = "pwd=" + pwd + "&vcode=&vcode_str=";

            return HttpPost(url, data);
        }

        #region 网络请求

        private CookieContainer cookie = new CookieContainer();

        #region Get请求

        /// <summary>
        /// 请求路径
        /// </summary>
        /// <param name="Url">请求的路径</param>
        /// <returns>返回请求的网页数据</returns>
        private string HttpGet(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.CookieContainer = cookie;

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

        #endregion Get请求

        #region Post请求

        /// <summary>
        /// 提交数据
        /// </summary>
        /// <param name="Url">提交的路径</param>
        /// <param name="Data">提交的数据</param>
        /// <returns>返回结果</returns>
        private string HttpPost(string Url, string Data)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
                request.Referer = "https://pan.baidu.com/share/init?" + info;
                request.ContentLength = Encoding.UTF8.GetByteCount(Data);
                request.CookieContainer = cookie;
                request.Method = "POST";

                Stream myRequestStream = request.GetRequestStream();
                byte[] postBytes = Encoding.UTF8.GetBytes(Data);
                myRequestStream.Write(postBytes, 0, postBytes.Length);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Cookies = cookie.GetCookies(response.ResponseUri);

                StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();

                return retString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion Post请求

        #endregion 网络请求
    }
}