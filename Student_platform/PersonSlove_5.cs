using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.Drawing.Drawing2D;

namespace Student_platform
{
    public partial class PersonSlove_5 : Form
    {
        public static string[]  Colors= new string[]{"黑","红","黄","绿"};
        public static Color[] Colorselect = new Color[] { Color.Black,Color.Red,Color.Yellow,Color.Green};
        public static int select = 0;
        public PersonSlove_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = textBox1.Text;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(6, Colorselect[select], Color.White, null, 15, 6, false);

            /* GetGraphic方法参数说明
                 public Bitmap GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor, Bitmap icon = null, int iconSizePercent = 15, int iconBorderWidth = 6, bool drawQuietZones = true)
             * 
                 int pixelsPerModule:生成二维码图片的像素大小 ，我这里设置的是5 
             * 
                 Color darkColor：暗色   一般设置为Color.Black 黑色
             * 
                 Color lightColor:亮色   一般设置为Color.White  白色
             * 
                 Bitmap icon :二维码 水印图标 例如：Bitmap icon = new Bitmap(context.Server.MapPath("~/images/zs.png")); 默认为NULL ，加上这个二维码中间会显示一个图标
             * 
                 int iconSizePercent： 水印图标的大小比例 ，可根据自己的喜好设置 
             * 
                 int iconBorderWidth： 水印图标的边框
             * 
                 bool drawQuietZones:静止区，位于二维码某一边的空白边界,用来阻止读者获取与正在浏览的二维码无关的信息 即是否绘画二维码的空白边框区域 默认为true
   */
            Image drawjpg = qrCodeImage;
            panel1.Width = drawjpg.Width;
            panel1.Height = drawjpg.Height;
            this.panel1.BackgroundImage = drawjpg;
            panel1.BackgroundImage.Save("../../output/otp.jpg");
        }

        private void PersonSlove_5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Colors);
            comboBox1.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = comboBox1.SelectedIndex;
        }
    }
}
