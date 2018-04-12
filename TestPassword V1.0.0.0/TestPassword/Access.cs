using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace zgcwkj
{
    /// <summary>
    /// 测试访问类
    /// </summary>
    public class Access
    {
        string info = "";//唯一识别文件的值吧
        CookieContainer cookie = new CookieContainer();
        /// <summary>
        /// 实例测试类
        /// </summary>
        /// <param name="url">访问的链接</param>
        public Access(string url)
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

            return  HttpPost(url, data);
        }
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
                StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                return retString;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
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

                StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();

                return retString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}