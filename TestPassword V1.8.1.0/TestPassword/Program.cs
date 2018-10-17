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
    }
}
