using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using QRCoder;
using System.Drawing.Drawing2D;

namespace Info_proform
{
    public partial class PicInfo : CCSkinMain
    {
        public PicInfo()
        {
            InitializeComponent();
        }

        private void PicInfo_Load(object sender, EventArgs e)
        {
            skinComboBox1.Items.AddRange(Publicinfo.Colors);
            skinComboBox1.SelectedIndex = 0;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string info = skinTextBox1.Text;
            if (info == "")
            {
                return;
            }
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage;
            if (Publicinfo.select == 0)
            {
                Random num = new Random();
                Publicinfo.select = num.Next(0, 4);
                qrCodeImage = qrcode.GetGraphic(6, Publicinfo.Colorselect[Publicinfo.select], Color.White, null, 15, 6, false);
                Publicinfo.select = 0;
            }
            else
            {
                qrCodeImage = qrcode.GetGraphic(6, Publicinfo.Colorselect[Publicinfo.select-1], Color.White, null, 15, 6, false);
            }
            Image drawjpg = qrCodeImage;
            skinPanel1.Width = drawjpg.Width;
            skinPanel1.Height = drawjpg.Height;
            this.skinPanel1.BackgroundImage = drawjpg;
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publicinfo.select = skinComboBox1.SelectedIndex;
        }
    }
}
