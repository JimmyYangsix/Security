using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sniffer
{
    public class GetNetBIOS
    {
        public static List<string> NetBIOSinfo = new List<string>();
        public static SharpPcap.LibPcap.LibPcapLiveDeviceList allDevice = SharpPcap.LibPcap.LibPcapLiveDeviceList.Instance;
        public static void GetallNet()
        {
            if (allDevice.Count < 1)
            {
                NetBIOSinfo.Add("未找到网卡");
            }
            else
            {
                foreach (SharpPcap.LibPcap.LibPcapLiveDevice Device in allDevice)
                {
                    NetBIOSinfo.Add(Device.ToString());
                }
            }
        }
    }
}
