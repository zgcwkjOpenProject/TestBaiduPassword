using System;
using System.Threading;
using System.Windows.Forms;

namespace zgcwkj
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // 在此方法返回时，如果创建了局部互斥体（即，如果 name 为 null 或空字符串）或指定的命名系统互斥体，则包含布尔值 true
            // 如果指定的命名系统互斥体已存在，则为false
            using (Mutex mutex = new Mutex(true, Application.ProductName, out bool Uniquely_Identifies_TestPassword))
            {
                if (Uniquely_Identifies_TestPassword)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //if (ServiceVerificat()) Application.Run(new Main());
                    new HttpProxy().SwitchOff();
                    Application.Run(new Main());
                }
                else//程序已经运行的情况，则弹出消息提示并终止此次运行
                {
                    MessageBox.Show("应用程序已经启动了");
                    System.Threading.Thread.Sleep(1000);
                    // 终止此进程并为基础操作系统提供指定的退出代码。
                    System.Environment.Exit(1);
                }
            }
        }

        /// <summary>
        /// 程序服务验证
        /// </summary>
        /// <returns></returns>
        private static bool ServiceVerificat()
        {
            //返回的状态
            bool status = false;

            try
            {
                new HttpProxy().SwitchOff();
                string Serve = HttpHelp.HttpGet("http://www.zgcwkj.top/TestPassword/Serve.txt");
                string[] Serves = Serve.Replace("\r", "").Split('\n');

                #region 更新模块

                if (Serves.Length >= 1)
                {
                    if (Serves[0] != "")
                    {
                        string[] Update = Serves[0].Split('|');
                        //是否强制更新
                        if (Convert.ToBoolean(Update[0]))
                        {
                            //匹配版本号进行判断
                            int versions = Convert.ToInt32(Application.ProductVersion.Replace(".", ""));
                            if (versions < Convert.ToInt32(Update[1]))
                            {
                                //提示更新内容
                                MessageBox.Show(Update[2]);
                                //通过浏览器跳转
                                try { System.Diagnostics.Process.Start(Update[3]); } catch { }
                                //直接终止程序运行
                                return false;
                            }
                        }
                    }
                }

                #endregion 更新模块

                #region 程序状态

                if (Serves.Length >= 2)
                {
                    if (Serves[1] != "")
                    {
                        //程序状态
                        if (Convert.ToBoolean(Serves[1])) { status = true; }
                    }
                }

                #endregion 程序状态

                #region 提示内容

                if (Serves.Length >= 3)
                {
                    if (Serves[2] != "")
                    {
                        //提示消息内容
                        MessageBox.Show(Serves[2]);
                    }
                }

                #endregion 提示内容

                #region 浏览器跳转

                if (Serves.Length >= 4)
                {
                    if (Serves[3] != "")
                    {
                        //通过浏览器跳转
                        try { System.Diagnostics.Process.Start(Serves[3]); } catch { }
                    }
                }

                #endregion 浏览器跳转
            }
            catch (Exception e)
            {
                string str = e.Message;
                MessageBox.Show("请检查网络状态");
                status = false;
            }
            return status;
        }
    }
}