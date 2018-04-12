using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;

namespace zgcwkj
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Configuration.ini")) File.AppendAllText("Configuration.ini", "|100|200|0000|zzzz");
            string[] Configuration = File.ReadAllText("Configuration.ini").Split('|');
            text_url.Text = Configuration[0];
            text_xczs.Text = Configuration[1];
            text_zxsd.Text = Configuration[2];
            text_ksd.Text = Configuration[3];
            text_jsd.Text = Configuration[4];
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("Configuration.ini");
            File.AppendAllText("Configuration.ini", text_url.Text + "|" + text_xczs.Text + "|" + text_zxsd.Text + "|" + text_ksd.Text + "|" + text_jsd.Text);
        }
        private void btn_Click(object sender, EventArgs e)//启动按钮
        {
            if (text_url.Text == "") { MessageBox.Show("啥也没输入呢！"); return; }//防止空文本也执行

            StaticClass.Folder = DateTime.Now.ToString("yyyyMMddHHmmss");//用时间达到随机名称功能
            if (!File.Exists(StaticClass.Folder + ".ini")) File.AppendAllText(StaticClass.Folder + ".ini", "时间：" + StaticClass.Folder + "，目标连接：" + text_url.Text + "\r\n");

            int start = Hash.Str2Hash(text_ksd.Text);
            int end = Hash.Str2Hash(text_jsd.Text);
            int total = end - start + 1;//尝试的总数
            int section = total / Convert.ToInt32(text_xczs.Text);//线程的次数

            gb_1.Text = "一共要尝试" + total + "次密码";
            enabled(false);
            StaticClass.status = false;
            StaticClass.url = text_url.Text.Trim();

            for (int i = 1; i <= Convert.ToInt32(text_xczs.Text); i++)
            {
                new GoFind(this, start + section * (i - 1), start + section * i, Convert.ToInt32(text_zxsd.Text));
            }
            text_ksd.Text = text_jsd.Text;
        }
        delegate void Modifystr(string str1, string str2);//委托进行显示数据
        public void ModifyStr(string str1, string str2)//委托进行显示数据
        {
            if (InvokeRequired)
            {
                Modifystr stcb = new Modifystr(ModifyStr);
                Invoke(stcb, new object[] { str1, str2 });
            }
            else
            {
                txt_ts.Text = str1 + "》正在尝试：" + str2;
                File.AppendAllText(StaticClass.Folder + ".ini", txt_ts.Text + "\r\n");
                if (str1.Contains("\"errno\":-9"))//密码错误
                {

                }
                else if (str1.Contains("\"errno\":0"))//密码正常
                {
                    enabled(true);
                    StaticClass.status = true;
                    MessageBox.Show("密码是：" + str2);
                }
                else if (str1.Contains("\"errno\":-62"))//要输入验证码
                {

                }
                else if (str1.Contains("404"))//拒绝访问
                {
                    enabled(true);
                    StaticClass.status = true;
                    MessageBox.Show("你的IP被拒绝访问，请稍后重试");
                }
                else { }//未知错误
            }
        }
        private void _KeyPress(object sender, KeyPressEventArgs e)//限制输入
        {
            if ((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 || (Keys)e.KeyChar == Keys.Back) { } else e.Handled = true;
        }
        public void enabled(bool b)//启用或禁用控件
        {
            gb_1.Enabled = btn.Enabled = b;
        }
    }
}