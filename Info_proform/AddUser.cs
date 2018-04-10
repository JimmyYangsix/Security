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
    public partial class AddUser : CCSkinMain
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            string info = Publicinfo.useCode;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(6, Publicinfo.Colorselect[Publicinfo.select], Color.White, null, 15, 6, false);
            Image drawjpg = qrCodeImage;
            skinPanel1.Width = drawjpg.Width;
            skinPanel1.Height = drawjpg.Height;
            this.skinPanel1.BackgroundImage = drawjpg;
        }
    }
}
