using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpPcap;
using PacketDotNet;
namespace sniffer
{
    public class Slove
    {
        public static void Getinfo()
        {
            publicinfo.usedevice.OnPacketArrival += new SharpPcap.PacketArrivalEventHandler(device_OnPacketArrival);//分组到达事件
            int readTimeoutMilliseconds = 1000;
            publicinfo.usedevice.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);//打开捕获设备       
            if (publicinfo.type >= 0)
            {
                publicinfo.usedevice.Filter = publicinfo.typename[publicinfo.type];
            }
            publicinfo.usedevice.StartCapture();
        }
        private static void device_OnPacketArrival(object sender, CaptureEventArgs packet)//输出时间和收到数据包长度
        {

            Data nowPacket = new Data();
            DateTime time = packet.Packet.Timeval.Date;//时间
            nowPacket.alen = packet.Packet.Data.Length;//数据包长度     
            Packet usepacket;
            try
            {
                usepacket = PacketDotNet.Packet.ParsePacket(packet.Packet.LinkLayerType, packet.Packet.Data);//进行packet类型转换
            }
            catch
            {
                return;
            }
            var tcppacket = TcpPacket.GetEncapsulated(usepacket);
            var arppacket = PacketDotNet.ARPPacket.GetEncapsulated(usepacket);
            var Icmppacket = PacketDotNet.ICMPv4Packet.GetEncapsulated(usepacket);
            var udppacket = PacketDotNet.UdpPacket.GetEncapsulated(usepacket);
            var ippacket = PacketDotNet.IpPacket.GetEncapsulated(usepacket);
            var packettype = packet.Packet.LinkLayerType;//包类型获取
            nowPacket.info = packet.Packet.Data;//报文所有信息
            if (tcppacket != null)
            {
                nowPacket.type = "TCP";
                nowPacket.ahead = tcppacket.Header;//消息头
                var ippackete = (PacketDotNet.IpPacket)tcppacket.ParentPacket;//获取IP数据包
                nowPacket.mhead = ippackete.Header;//IP报文头
                nowPacket.sip = ippackete.SourceAddress;//源IP地址
                nowPacket.dip = ippackete.DestinationAddress;//目的IP地址
                nowPacket.sport = tcppacket.SourcePort;//源端口
                nowPacket.dport = tcppacket.DestinationPort;//目的端口
                nowPacket.slen = nowPacket.alen - tcppacket.Header.Length;//消息体长度
            }
            else if (arppacket != null)
            {
                nowPacket.type = "ARP";//ARP协议数据包类型赋值
                nowPacket.ahead = arppacket.Header;//消息头
                nowPacket.mhead = arppacket.Header;
                nowPacket.dport = -1;
                nowPacket.sport = -1;
                nowPacket.sip = arppacket.SenderProtocolAddress;
                nowPacket.dip = arppacket.TargetProtocolAddress;
                System.Net.NetworkInformation.PhysicalAddress smac = arppacket.SenderHardwareAddress;
                System.Net.NetworkInformation.PhysicalAddress dmac = arppacket.TargetHardwareAddress;
                nowPacket.slen = nowPacket.alen - arppacket.Header.Length;//消息体长度
            }
            else if (Icmppacket != null)
            {
                nowPacket.type = "ICMP";//ICMP协议数据包类型赋值
                nowPacket.ahead = Icmppacket.Header;
                var ippackete = (PacketDotNet.IpPacket)Icmppacket.ParentPacket;
                nowPacket.mhead = ippackete.Header;
                nowPacket.sip = ippackete.SourceAddress;//源IP地址
                nowPacket.dip = ippackete.DestinationAddress;//目的IP地址
                nowPacket.dport = -1;
                nowPacket.sport = -1;
                nowPacket.slen = nowPacket.alen - Icmppacket.Header.Length;//消息体长度
            }
            else if (udppacket != null)
            {
                nowPacket.type = "UDP";
                nowPacket.ahead = udppacket.Header;//消息头
                var ippackete = (PacketDotNet.IpPacket)udppacket.ParentPacket;//获取IP数据包
                nowPacket.mhead = ippackete.Header;//IP报文头
                nowPacket.sip = ippackete.SourceAddress;//源IP地址
                nowPacket.dip = ippackete.DestinationAddress;//目的IP地址
                nowPacket.sport = udppacket.SourcePort;//源端口
                nowPacket.dport = udppacket.DestinationPort;//目的端口
                nowPacket.slen = nowPacket.alen - udppacket.Header.Length;//消息体长度
            }
            else if (ippacket != null)
            {
                nowPacket.type = "IP";
                nowPacket.ahead = ippacket.Header;//消息头
                var ippackete = (PacketDotNet.IpPacket)ippacket.ParentPacket;//获取IP数据包
                nowPacket.mhead = ippacket.Header;//IP报文头
                nowPacket.sip = ippacket.SourceAddress;//源IP地址
                nowPacket.dip = ippacket.DestinationAddress;//目的IP地
                nowPacket.dport = -1;
                nowPacket.sport = -1;
                nowPacket.slen = nowPacket.alen - ippacket.Header.Length;//消息体长度
            }
            if (!string.IsNullOrEmpty(nowPacket.type))
            {
                nowPacket.id= publicinfo.useid;
                publicinfo.useid++;
                publicinfo.alldatapacket.Add(nowPacket);
            }
        }
    }
}
