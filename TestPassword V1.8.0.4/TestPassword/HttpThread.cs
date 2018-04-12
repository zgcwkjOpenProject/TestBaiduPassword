using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;

namespace zgcwkj
{
    public class HttpThread
    {
        Main myMain;//主窗体
        int StartValue = 0;//基值
        int NumberValue = 0;//剩余次数
        Timer timer;//线程
        string ThreadID;//线程ID

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
            #endregion
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
                    File.Delete(ThreadID + ".ini");
                    File.AppendAllText(ThreadID + ".ini", StartValue.ToString());
                }
                catch { }
                #endregion
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