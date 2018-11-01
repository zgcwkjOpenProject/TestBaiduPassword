using System;
using System.IO;
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
                myMain.ModifyStr(httptest.Post(password), password);
                StartValue = StartValue + 1;
            }
        }
    }
}