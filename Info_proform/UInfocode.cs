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
using System.IO;
namespace Info_proform
{
    public partial class UInfocode : CCSkinMain
    {
        string path;
        public UInfocode()
        {
            InitializeComponent();
        }

        private void UInfocode_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo EzoneFile = new FileInfo(ofd.FileName);
                Input.Text = EzoneFile.FullName;
                if (ReadFile.GetuseFile(Input.Text))
                {
                    path = Input.Text;
                    Input.ReadOnly = true;
                    this.skinButton1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("选择的文件非jpg图片无法，请重选择");
                    Input.Text = "";
                }
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            int key = Int32.Parse(skinTextBox3.Text);//验证时提供的密钥
            Publicinfo.Cindex = skinTextBox1.Text.Length.ToString();
            string hexs = ReadFile.SloveFile(Input.Text, true);
            string outtext = ReadFile.USloveAll(hexs);
            outtext = Caesar.deciphering(outtext, key);
            if (!(skinTextBox1.Text == ""))
            {
                if (outtext == skinTextBox1.Text)
                {
                    MessageBox.Show("验证成功");
                }
                else
                {
                    MessageBox.Show("未通过验证");
                }
            }
            else
            {
                MessageBox.Show("验证数据不能为空");
            }
        }
    }
}
