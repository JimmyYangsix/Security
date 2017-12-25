using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace sniffer
{
    public class Data
    {
        public int id ;//协议序号
        public string type;//协议类型
        public IPAddress sip;//源ip
        public int sport;//源端口号
        public IPAddress dip;//目的ip
        public int dport;//目的端口号
        public int alen;//消息体长度
        public int slen;//消息长度
        public byte[] ahead;//ip报文头
        public byte[] mhead;//消息头
        public byte[] info;//所有信息
    }
}
