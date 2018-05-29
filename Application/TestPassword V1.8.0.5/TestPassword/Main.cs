using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace zgcwkj
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 解决方案
        /// </summary>
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (fBD.ShowDialog() == DialogResult.OK)
            {
                #region 防止选择非空文件夹

                //赋值给静态变量
                StaticClass.file = fBD.SelectedPath;
                //获取路径下所有文件
                string[] files = Directory.GetFiles(StaticClass.file);
                //拒绝选择有文件的文件夹
                if (files.Length > 0) { MessageBox.Show("请务必选择空的文件夹"); return; }

                #endregion 防止选择非空文件夹

                #region 防止空文本也执行

                if (text_url.Text.Trim() == "" || !text_url.Text.Contains("pan.baidu")) { MessageBox.Show("请输入百度云盘链接"); return; }
                if (text_xczs.Text == "") { MessageBox.Show("线程总数错误"); return; }
                if (text_zxsd.Text == "") { MessageBox.Show("线程执行速度错误"); return; }
                if (text_ksd.Text.Length != 4) { MessageBox.Show("密码开始点错误"); return; }
                if (text_jsd.Text.Length != 4) { MessageBox.Show("密码结束点错误"); return; }

                #endregion 防止空文本也执行

                #region 生成配置文件

                string Configuration;
                try
                {
                    Configuration = File.ReadAllText(StaticClass.file + "/Configuration.ini");
                    string[] str = Configuration.Split('∆');
                    text_url.Text = str[0];
                    text_xczs.Text = str[1];
                    text_zxsd.Text = str[2];
                }
                catch
                {
                    Configuration = text_url.Text + "∆" + text_xczs.Text + "∆" + text_zxsd.Text;
                    File.Delete(StaticClass.file + "/Configuration.ini");
                    File.AppendAllText(StaticClass.file + "/Configuration.ini", Configuration);
                }
                StaticClass.url = text_url.Text;
                StaticClass.status = false;

                #endregion 生成配置文件

                btn_status.Enabled = true;
            }
        }

        /// <summary>
        /// 启动或停止
        /// </summary>
        private void btn_status_Click(object sender, EventArgs e)
        {
            if (btn_status.Text == "停止")
            {
                btn_status.Text = "启动";
                btn_status.Enabled = false;
                StaticClass.status = true;
            }
            else
            {
                #region 基本的线程

                int xczs = Convert.ToInt32(text_xczs.Text);//线程总数
                int zxsd = Convert.ToInt32(text_zxsd.Text);//线程速度
                int start = Hash.StrTo4Hash(text_ksd.Text);//起始值
                int end = Hash.StrTo4Hash(text_jsd.Text);//结束值
                int total = end - start + 1;//尝试的总数
                int section = total / xczs;//线程的次数

                #endregion 基本的线程

                #region 预防(防止)线程的总数大于尝试的总数

                if (xczs > total)
                {
                    MessageBox.Show("小伙子又想让程序出BUG吗？");
                    MessageBox.Show("检测到线程的总数大于尝试的总数");
                    return;
                }

                #endregion 预防(防止)线程的总数大于尝试的总数

                #region 标识程序已经启动

                btn_status.Text = "停止";

                #endregion 标识程序已经启动

                #region 创建线程

                for (int i = 1; i <= xczs; i++)
                {
                    int _start = start + section * (i - 1);//一条线程的开始值
                    int _end = start + section * i;//一条线程的结束值

                    new HttpThread(this, i.ToString(), _start, _end, zxsd).Start();
                }

                #endregion 创建线程
            }
        }

        /// <summary>
        /// 联网查密(用到互联网搜索功能)
        /// </summary>
        private void btn_net_Click(object sender, EventArgs e)
        {
            if (text_url.Text.Trim() == "" || !text_url.Text.Contains("pan.baidu")) { MessageBox.Show("请输入百度云盘链接"); return; }

            MessageBox.Show("本服务由 云盘万能钥匙(www.ypsuperkey.com)提供，本人仅是使用提供的接口");

            string info = text_url.Text.Replace("https", "").Replace("http", "").Replace("://pan.baidu.com/", "").Replace("share/init?surl=", "").Replace("s/1", "");
            string url = "https://www.ypsuperkey.com/api/items/BDY-" + info + "?access_key=4fxNbkKKJX2pAm3b8AEu2zT5d2MbqGbD&client_version=zg";
            string data = StaticClass.HttpGet(url);//请求并获得返回数据
            data = "密码为" + Regex.Match(data, "\"access_code\":\".+?\"").Value.ToString().Replace("\"", "").Replace("access_code:", "");
            if (data == "密码为") data = "还是老老实实暴密码吧";
            MessageBox.Show(data, "提示");
        }

        #region 委托进行显示数据

        private delegate void Modifystr(string str1, string str2);

        public void ModifyStr(string str1, string str2)
        {
            if (InvokeRequired)
            {
                Modifystr stcb = new Modifystr(ModifyStr);
                Invoke(stcb, new object[] { str1, str2 });
            }
            else
            {
                txt_ts.Text = str1 + "》正在尝试：" + str2;//显示点啥
                File.AppendAllText(StaticClass.file + "/logs.ini", txt_ts.Text + "\r\n");//输出日志
                if (str1.Contains("\"errno\":0"))//密码正常
                {
                    StaticClass.status = true;
                    MessageBox.Show("密码是：" + str2);
                }
                else if (str1.Contains("\"errno\":-9"))//密码错误
                {
                }
                else if (str1.Contains("\"errno\":-62"))//要输入验证码
                {
                }
                else if (str1.Contains("404"))//拒绝访问
                {
                    StaticClass.status = true;
                    MessageBox.Show("你的IP被拒绝访问，请稍后重试");
                }
                else { }//未知错误
            }
        }

        #endregion 委托进行显示数据

        #region 移动版本

        /// <summary>
        /// 安卓APK
        /// </summary>
        private void btn_apk_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://github.com/zgcwkj/TestBaiduPassword/tree/master/Application"); } catch { }
        }

        /// <summary>
        /// 苹果APP
        /// </summary>
        private void btn_app_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者无能为力，我也很无耐啊");
        }

        #endregion 移动版本

        #region 一些跳转

        /// <summary>
        /// 跳转到博客页
        /// </summary>
        private void btn_blog_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://blog.zgcwkj.top"); } catch { }
        }

        /// <summary>
        /// 跳转到开源页
        /// </summary>
        private void txt_ts_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://github.com/zgcwkj/TestBaiduPassword"); } catch { }
        }

        #endregion 一些跳转

        #region 限制键盘输入

        /// <summary>
        /// 限制输入
        /// </summary>
        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 || (Keys)e.KeyChar == Keys.Back) { } else e.Handled = true;
        }

        #endregion 限制键盘输入
    }
}