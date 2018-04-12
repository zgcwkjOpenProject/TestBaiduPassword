using System.IO;
using System.Timers;

namespace zgcwkj
{
    public class GoFind
    {
        Main myMain;//主窗体
        int StartValue = 0;//基值
        int NumberValue = 0;//剩余次数

        public GoFind(Main main, int start, int number, int interval)
        {
            myMain = main;
            StartValue = start;
            NumberValue = number;
            Timer timer = new Timer(interval);
            timer.Elapsed += new ElapsedEventHandler(_Timer);
            timer.Start();
        }
        private void _Timer(object sender, ElapsedEventArgs e)
        {
            Timer timer = sender as Timer;
            if (NumberValue < StartValue || StaticClass.status)
            {
                timer.Stop();
            }
            else
            {
                string password = Hash.Hash2Str(StartValue);
                Access access = new Access(StaticClass.url);
                myMain.ModifyStr(access.Post(password), password);
                StartValue = StartValue + 1;
            }
        }
    }
}