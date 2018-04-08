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
    public partial class PersonSlove_6 : Form
    {
        public PersonSlove_6()
        {
            InitializeComponent();
        }

        private void PersonSlove_6_Load(object sender, EventArgs e)
        {
            string info = Publicinfo.useCode;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(6, Color.Black, Color.White, null, 15, 6, false);
            Image drawjpg = qrCodeImage;         
            panel2.Width = drawjpg.Width;
            panel2.Height = drawjpg.Height;
            this.panel2.BackgroundImage = drawjpg;
        }
    }
}
