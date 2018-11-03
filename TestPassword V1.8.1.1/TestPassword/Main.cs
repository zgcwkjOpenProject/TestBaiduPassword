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
        /// 程序加载完成
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("zgcwkj"))
            {
                DialogResult DR = MessageBox.Show("您是第一次使用吗？", "提示", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    File.WriteAllText("zgcwkj", "zgcwkj");
                    try { System.Diagnostics.Process.Start("https://blog.zgcwkj.top/index.php/archives/367"); } catch { }
                }
            }
        }

        /// <summary>
        /// 解决方案
        /// </summary>
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (fBD.ShowDialog() == DialogResult.OK)
            {
                #region 防止选择非空文件夹或者不是项目的文件

                //把选择的路径赋值给静态变量
                StaticClass.file = fBD.SelectedPath;
                //把配置文件的路径赋值给静态变量
                StaticClass.config = fBD.SelectedPath + "\\Configuration.ini";
                //把代理文件的路径赋值给静态变量
                StaticClass.proxy = fBD.SelectedPath + "\\proxy.ini";
                //获取路径下所有文件
                string[] files = Directory.GetFiles(StaticClass.file);
                //拒绝选择有文件的文件夹
                if (files.Length > 0)
                {
                    if (File.Exists(StaticClass.config))
                    {
                        try
                        {
                            string[] str = File.ReadAllText(StaticClass.config).Split('∆');
                            text_url.Text = str[0];
                            text_xczs.Text = str[1];
                            text_zxsd.Text = str[2];
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message;

                            MessageBox.Show("所选择的文件夹，不是本程序的项目，请重新选择");
                            text_url.Text = "";
                            text_xczs.Text = "";
                            text_zxsd.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("请务必选择空的文件夹");
                        return;
                    }
                }

                #endregion 防止选择非空文件夹或者不是项目的文件

                #region 防止空文本也执行

                if (text_url.Text.Trim() == "" || !text_url.Text.Contains("pan.baidu")) { MessageBox.Show("请输入百度云盘链接"); return; }
                if (text_xczs.Text == "") { MessageBox.Show("线程总数错误"); return; }
                if (text_zxsd.Text == "") { MessageBox.Show("线程执行速度错误"); return; }
                if (text_ksd.Text.Length != 4) { MessageBox.Show("密码开始点错误"); return; }
                if (text_jsd.Text.Length != 4) { MessageBox.Show("密码结束点错误"); return; }

                #endregion 防止空文本也执行

                #region 生成配置文件

                if (!File.Exists(StaticClass.config))
                {
                    string Configuration;
                    try
                    {
                        Configuration = File.ReadAllText(StaticClass.config);
                        string[] str = Configuration.Split('∆');
                        text_url.Text = str[0];
                        text_xczs.Text = str[1];
                        text_zxsd.Text = str[2];
                    }
                    catch
                    {
                        Configuration = text_url.Text + "∆" + text_xczs.Text + "∆" + text_zxsd.Text;
                        File.WriteAllText(StaticClass.config, Configuration);
                    }
                }

                #endregion 生成配置文件

                //打开启动按钮
                btn_status.Enabled = true;
                //关闭参数调整
                gb_1.Enabled = false;
            }
        }

        /// <summary>
        /// 启动或停止
        /// </summary>
        private void btn_status_Click(object sender, EventArgs e)
        {
            if (!cB_mxwxz.Checked) { MessageBox.Show("请使用 MXWXZ 提供的方案"); return; }
            if (btn_status.Text == "停止")
            {
                btn_status.Text = "启动";
                btn_status.Enabled = true;
                btn_start.Enabled = true;
                btn_net.Enabled = true;
                cB_mxwxz.Enabled = true;
                cB_proxy.Enabled = true;
                cB_ypsuperkey.Enabled = true;
                StaticClass.status = true;
            }
            else
            {
                #region 验证文本输入是否正确

                bool verificationText = false;
                if (text_url.Text == "") { MessageBox.Show("请不要删除 目标地址"); verificationText = true; }
                if (text_xczs.Text == "") { MessageBox.Show("请不要删除 线程总数"); verificationText = true; }
                if (text_zxsd.Text == "") { MessageBox.Show("请不要删除 线程速度"); verificationText = true; }
                if (text_ksd.Text == "") { MessageBox.Show("请不要删除 起始值"); verificationText = true; }
                if (text_jsd.Text == "") { MessageBox.Show("请不要删除 结束值"); verificationText = true; }
                if (verificationText) { btn_status.Enabled = false; return; }

                #endregion 验证文本输入是否正确

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

                #region 标识程序启动

                //把分享地址赋值给静态变量
                StaticClass.url = text_url.Text;
                //设置线程默认状态给静态变量
                StaticClass.status = false;

                btn_status.Text = "停止";
                btn_start.Enabled = false;
                btn_net.Enabled = false;
                cB_mxwxz.Enabled = false;
                cB_proxy.Enabled = false;
                cB_ypsuperkey.Enabled = false;

                #endregion 标识程序启动

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
            if (!cB_ypsuperkey.Checked) { MessageBox.Show("请使用 云盘万能钥匙 提供的方案"); return; }
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

        private delegate void Modifystr(string html, string password);

        public void ModifyStr(string html, string password)
        {
            if (InvokeRequired)
            {
                Modifystr stcb = new Modifystr(ModifyStr);
                Invoke(stcb, new object[] { html, password });
            }
            else
            {
                txt_ts.Text = html + "》正在尝试：" + password;//显示点啥
                File.AppendAllText(StaticClass.file + "/logs.ini", txt_ts.Text + "\r\n");//输出日志
                if (html.Contains("\"errno\":0"))//密码正常
                {
                    StaticClass.status = true;
                    btn_status.Text = "启动";

                    MessageBox.Show("密码是：" + password);
                }
                else if (html.Contains("\"errno\":-9"))//密码错误
                {
                }
                else if (html.Contains("\"errno\":-62"))//要输入验证码
                {
                }
                else//拒绝访问、未知错误
                {
                    if (!StaticClass.status && !cB_proxy.Checked)
                    {
                        btn_status.PerformClick();

                        MessageBox.Show("你的IP被拒绝访问，请稍后重试");
                    }
                }
            }
        }

        #endregion 委托进行显示数据

        #region 浏览器预览网页

        /// <summary>
        /// 跳转到开源页
        /// </summary>
        private void txt_ts_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://github.com/zgcwkj/TestBaiduPassword"); } catch { }
        }

        #endregion 浏览器预览网页

        #region 检验常规数据

        /// <summary>
        /// 限制输入
        /// </summary>
        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 || (Keys)e.KeyChar == Keys.Back) { } else e.Handled = true;
        }

        /// <summary>
        /// 验证代理IP的文件是否正常
        /// </summary>
        private void cB_proxy_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_proxy.Checked)
            {
                if (StaticClass.proxy == null)
                {
                    MessageBox.Show("请先 选择解决方案");
                    cB_proxy.Checked = false;
                    return;
                }
                if (!File.Exists(StaticClass.proxy))
                {
                    string text = "";
                    text += "使用代理方案说明：\r\n";
                    text += "1：请确保代理的 IP 必须支持 SSL(即Https)\r\n";
                    text += "2：使用代理方案后，程序将不会检测代理 IP 是否有效,也意味着程序不会自动停止\r\n";
                    text += "3：作者 zgcwkj 编写日期 20181103\r\n";
                    text += "\r\n";
                    text += "\r\n";
                    text += "把文本的内容清空\r\n";
                    text += "填入内容格式为 IP:端号 回车，以此类推\r\n";
                    text += "注意最后一个不要加回车\r\n";
                    text += "\r\n";
                    text += "记得保存文本！不然白写\r\n";
                    text += "";

                    File.WriteAllText(StaticClass.proxy, text);
                    System.Diagnostics.Process.Start("notepad.exe", StaticClass.proxy);
                    cB_proxy.Checked = false;
                    return;
                }
            }
        }

        #endregion 检验常规数据

        #region 退出程序

        /// <summary>
        /// 退出程序
        /// </summary>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticClass.status = false;
            Application.Exit();
        }

        #endregion 退出程序
    }
}