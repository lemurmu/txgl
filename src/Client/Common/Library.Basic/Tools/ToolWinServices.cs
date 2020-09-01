using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Win32;
using System.ServiceProcess;

namespace Library.Basic
{
    public class ToolWinServices
    {
        public static bool StartServices(string serviceName)
        {
            try
            {
                ServiceController serviceConstrol = new ServiceController(Environment.MachineName);
                serviceConstrol.ServiceName = serviceName;//服务名称
                string servicePath = @"SYSTEM\CurrentControlSet\Services\" + serviceName;//服务名路径
                RegistryKey key = Registry.LocalMachine.OpenSubKey(servicePath, false);
                if (key == null)
                {
                    return false;
                }
                if (serviceConstrol.Status != ServiceControllerStatus.Running)//判断服务是否正在运行
                {
                    serviceConstrol.Start();
                }
                return true;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 暂停服务
        /// </summary>
        public static bool PauseServices(string serviceName)
        {
            try
            {
                ServiceController serviceConstrol = new ServiceController(Environment.MachineName);
                serviceConstrol.ServiceName = serviceName;//服务名称
                string servicePath = @"SYSTEM\CurrentControlSet\Services\" + serviceName;//服务名路径
                RegistryKey key = Registry.LocalMachine.OpenSubKey(servicePath, false);
                if (key == null)
                {
                    return false;
                }
                if (serviceConstrol.Status != ServiceControllerStatus.Paused)//判断服务是否已暂停
                {
                    serviceConstrol.Pause();
                }
                return true;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        public static bool StopServices(string serviceName)
        {
            try
            {
                ServiceController serviceConstrol = new ServiceController(Environment.MachineName);
                serviceConstrol.ServiceName = serviceName;//服务名称
                string servicePath = @"SYSTEM\CurrentControlSet\Services\" + serviceName;//服务名路径
                RegistryKey key = Registry.LocalMachine.OpenSubKey(servicePath, false);
                if (key == null)
                {
                    return false;
                }
                if (serviceConstrol.Status != ServiceControllerStatus.Stopped)//判断服务是否已停止
                {
                    serviceConstrol.Stop();
                }
                return true;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
        }
    }
}
