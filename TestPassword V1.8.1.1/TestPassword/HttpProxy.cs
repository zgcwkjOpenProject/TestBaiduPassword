using Microsoft.Win32;
using System;
using System.IO;

namespace zgcwkj
{
    public class HttpProxy
    {
        #region 启动IP代理服务

        /// <summary>
        /// 启动IP代理服务
        /// </summary>
        /// <param name="bout">次/回</param>
        /// <returns></returns>
        public bool startUp(int bout)
        {
            StaticClass.proxys = File.ReadAllText(StaticClass.proxy).Replace("\r", "").Split('\n');

            //关闭代理服务
            if (GetSwitchState()) SwitchOff();

            //获取电脑之前记录的代理IP
            string ip = GetProxyIp();
            //通过API获取代理数据
            try
            {
                ip = StaticClass.proxys[bout];
            }
            catch (Exception e)
            {
                string str = e.Message;
            }
            //设置代理IP
            SwitchOn(ip);

            //验证代理IP能否使用
            try
            {
                HttpHelp.HttpGet("https://blog.zgcwkj.top");
                return true;
            }
            catch (Exception e)
            {
                string str = e.Message;
                SwitchOff();
                if (StaticClass.proxys.Length - 1 >= bout + 1)
                {
                    startUp(bout + 1);
                }
            }
            return false;
        }

        #endregion 启动IP代理服务

        #region 通过注册表修改代理服务

        //注册表位置
        private string reg_path = @"Microsoft\Windows\CurrentVersion\Internet Settings";

        //Key名称
        private string key_name = "ProxyServer";

        //switch名称
        private string switch_name = "ProxyEnable";

        //启动代理
        public void SwitchOn(string ip_port)
        {
            SetRegValue(reg_path, key_name, ip_port);
            SetRegValue(reg_path, switch_name, 1);
        }

        //停止代理
        public void SwitchOff()
        {
            SetRegValue(reg_path, switch_name, 0);
        }

        //获取代理状态
        public bool GetSwitchState()
        {
            return GetRegValue(reg_path, switch_name) == "1";
        }

        //获取代理IP
        public string GetProxyIp()
        {
            return GetRegValue(reg_path, key_name);
        }

        private void SetRegValue<T>(string path, string name, T value)
        {
            RegistryKey expr_05 = Registry.CurrentUser;
            RegistryKey expr_17 = expr_05.OpenSubKey(@"Software\" + path, true);
            expr_17.SetValue(name, value);
            expr_17.Close();
            expr_05.Close();
        }

        private string GetRegValue(string path, string name)
        {
            string result = string.Empty;
            RegistryKey currentUser = Registry.CurrentUser;
            RegistryKey registryKey = currentUser.OpenSubKey("Software\\" + path);
            if (registryKey == null)
            {
                return null;
            }
            object value = registryKey.GetValue(name);
            if (value != null)
            {
                result = value.ToString();
            }
            registryKey.Close();
            currentUser.Close();
            return result;
        }

        #endregion 通过注册表修改代理服务
    }
}