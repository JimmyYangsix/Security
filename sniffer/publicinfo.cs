using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sniffer
{
    public class publicinfo
    {
        public static string[] typename = new string[] {"arp","icmp","ipv4","tcp","udp" };//用于协议筛选filter
        public static int selectid;//选择的网卡序号 
        public static bool reload = false;//数据重加载判断
        public static SharpPcap.LibPcap.PcapDevice usedevice = GetNetBIOS.allDevice[selectid];//获取指定网卡
        public static List<Data> alldatapacket = new List<Data>();
        public static int useid = 0;//id起始值设定
        public static int type = -1;//类型设定
        public static string Tohex(byte[] usebyte)//byte【】转16进制
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in usebyte)
            {
                //{0:X2} 大写
                sb.AppendFormat("{0:X2}", b);
                sb.AppendFormat("  "); 
            }
            string Finastr = sb.ToString();
            return Finastr;
        }
    }
}
