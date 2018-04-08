using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_platform
{
    public class Publicinfo
    {
        public static string Cindex;
        public static bool isAccept = false; //检查是否有U盘
        public static string Wpath = Checkuse.first();//接收盘符位置
        public static bool isImportant = false;//检测是否授权
        public static string info_1 = Checkuse.GetMD5("惠阳");//预制信息；
        public static string info_2;//读出信息
        public static string useCode = "";//授权内容
    }
}
