using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RSAcode
{
    public partial class RSAcode : Form
    {
        public RSAcode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Input = input.Text;
            string Output = rsaCode.RSAEncrypt(Input);
            output.Text = Output;
            MessageBox.Show("加密成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rsaCode.CreateRSAKey();
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            publicKey.Text=rsaCode.publicKey;
            publicKey.ReadOnly=true;
            praviteKey.Text = rsaCode.privateKey;
            praviteKey.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Output = output.Text;
            string Input = rsaCode.RSADecrypt(Output);
            input.Text = Input;
            MessageBox.Show("解密成功");
        }
    }
}
