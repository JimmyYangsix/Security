using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Info_proform
{
    public class Publicinfo
    {
        public static string Cindex;//读取位数
        public static bool isAccept = false; //检查是否有U盘
        public static string Wpath = Checkuse.first();//接收盘符位置
        public static bool isImportant = false;//检测是否授权
        public static string info_1 = Checkuse.GetMD5("惠阳");//预制信息；
        public static string info_2;//读出信息
        public static string useCode = "";//授权内容
        public static string[] Colors = new string[] { "随机","黑", "红", "黄", "绿" };
        public static Color[] Colorselect = new Color[] { Color.Black, Color.Red, Color.Yellow, Color.Green };
        public static int select = 0;//选中的颜色
        public static int second = 60;//剩余秒数
        public static int change = 3;//输入次数
    }
}
