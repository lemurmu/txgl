using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Management;

namespace Library.Basic
{
    public class ToolNetwork
    {
        public static string GetMacAddress()
        {
            string macAddress = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                    macAddress = mo["MacAddress"].ToString();
                mo.Dispose();
            }

            return macAddress;
        }

        public static string GetPhysicalAddress()
        {
            NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
            if (nis == null || nis.Length == 0)
                return null;

            return nis[0].GetPhysicalAddress().ToString();
        }
    }
}
