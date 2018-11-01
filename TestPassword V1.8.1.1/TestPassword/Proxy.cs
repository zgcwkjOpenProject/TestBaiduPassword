using Microsoft.Win32;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace zgcwkj
{
    public partial class Proxy : Form
    {
        HttpProxy httpProxy = new HttpProxy();

        public Proxy()
        {
            InitializeComponent();
            //记录Goto的次数
            int i = 0;
            //Goto 重新获取IP启动代理服务
            Retry:
            //关闭代理服务
            if (httpProxy.GetSwitchState()) { httpProxy.SwitchOff(); }

            i++;
            if (i > 10)
            {
                MessageBox.Show("很抱歉程序暂时无法使用");
                Application.Exit();
            }

            string ip = httpProxy.GetProxyIp();

            //通过API获取代理数据
            try
            {
                if (!File.Exists(StaticClass.proxy)) { ObtainIP(); }
                if (File.ReadAllText(StaticClass.proxy) == "") { ObtainIP(); }
                if (File.ReadAllText(StaticClass.proxy) == "\r\n") { ObtainIP(); }

                string proxy = File.ReadAllText(StaticClass.proxy);
                string[] proxys = proxy.Replace("\r", "").Split('\n');
                ip = proxys[0];

                File.Delete(StaticClass.proxy);
                File.AppendAllText(StaticClass.proxy, proxy.Replace(ip + "\r\n", ""));
            }
            catch (Exception e)
            {
                string str = e.Message;
            }

            httpProxy.SwitchOn(ip);

            try
            {
                txt_1.Text = ip;
                HttpHelp.HttpGet("https://blog.zgcwkj.top");
                Close();
            }
            catch (Exception e)
            {
                string str = e.Message;
                httpProxy.SwitchOff();
                //Goto 重试
                goto Retry;
            }
        }

        /// <summary>
        /// 获取IP
        /// </summary>
        private void ObtainIP()
        {
            File.Delete(StaticClass.proxy);
            //国内普通代理
            CrawlIP("https://www.kuaidaili.com/free/intr/1");
            CrawlIP("https://www.kuaidaili.com/free/intr/2");
            CrawlIP("https://www.kuaidaili.com/free/intr/3");
            CrawlIP("https://www.kuaidaili.com/free/intr/4");
            CrawlIP("https://www.kuaidaili.com/free/intr/5");
            CrawlIP("https://www.kuaidaili.com/free/intr/6");
            CrawlIP("https://www.kuaidaili.com/free/intr/7");
            CrawlIP("https://www.kuaidaili.com/free/intr/8");
            CrawlIP("https://www.kuaidaili.com/free/intr/9");
            CrawlIP("https://www.kuaidaili.com/free/intr/10");
            CrawlIP("https://www.kuaidaili.com/free/intr/11");
            CrawlIP("https://www.kuaidaili.com/free/intr/12");
            CrawlIP("https://www.kuaidaili.com/free/intr/13");
            CrawlIP("https://www.kuaidaili.com/free/intr/14");
            CrawlIP("https://www.kuaidaili.com/free/intr/15");
            CrawlIP("https://www.kuaidaili.com/free/intr/16");
            CrawlIP("https://www.kuaidaili.com/free/intr/17");
            CrawlIP("https://www.kuaidaili.com/free/intr/18");
            CrawlIP("https://www.kuaidaili.com/free/intr/19");
            CrawlIP("https://www.kuaidaili.com/free/intr/20");
            //国内高匿代理
            CrawlIP("https://www.kuaidaili.com/free/inha/1");
            CrawlIP("https://www.kuaidaili.com/free/inha/2");
            CrawlIP("https://www.kuaidaili.com/free/inha/3");
            CrawlIP("https://www.kuaidaili.com/free/inha/4");
            CrawlIP("https://www.kuaidaili.com/free/inha/5");
            CrawlIP("https://www.kuaidaili.com/free/inha/6");
            CrawlIP("https://www.kuaidaili.com/free/inha/7");
            CrawlIP("https://www.kuaidaili.com/free/inha/8");
            CrawlIP("https://www.kuaidaili.com/free/inha/9");
            CrawlIP("https://www.kuaidaili.com/free/inha/10");
            CrawlIP("https://www.kuaidaili.com/free/inha/11");
            CrawlIP("https://www.kuaidaili.com/free/inha/12");
            CrawlIP("https://www.kuaidaili.com/free/inha/13");
            CrawlIP("https://www.kuaidaili.com/free/inha/14");
            CrawlIP("https://www.kuaidaili.com/free/inha/15");
            CrawlIP("https://www.kuaidaili.com/free/inha/16");
            CrawlIP("https://www.kuaidaili.com/free/inha/17");
            CrawlIP("https://www.kuaidaili.com/free/inha/18");
            CrawlIP("https://www.kuaidaili.com/free/inha/19");
            CrawlIP("https://www.kuaidaili.com/free/inha/20");
        }

        /// <summary>
        /// 抓取IP
        /// </summary>
        /// <param name="url">地址</param>
        private void CrawlIP(string url)
        {
            Thread.Sleep(50);
            //Goto 重新获取代理IP
            RetryUrl:
            string str = HttpHelp.HttpGet(url);
            if (str == "" || str.Contains("-10"))
            {
                httpProxy.SwitchOff();
                goto RetryUrl;
            }
            string tbody = Regex.Match(str.Replace(" ", "").Replace("\r", "").Replace("\n", ""), @"<tbody>.+</tbody>").ToString();
            //Goto 重新获取代理IP
            RetryIP:
            string proxya = Regex.Match(tbody, "<tddata-title=\"IP\">.+?</td>").ToString();
            string proxyb = Regex.Match(tbody, "<tddata-title=\"PORT\">.+?</td>").ToString();
            if (proxya == "" || proxyb == "") { return; }
            string _proxya = proxya.Replace("<tddata-title=\"IP\">", "").Replace("</td>", "");
            string _proxyb = proxyb.Replace("<tddata-title=\"PORT\">", "").Replace("</td>", "");
            File.AppendAllText(StaticClass.proxy, _proxya + ":" + _proxyb + "\r\n");
            tbody = tbody.Replace(proxya, "").Replace(proxyb, "");
            goto RetryIP;
        }
    }
}