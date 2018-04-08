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

namespace Student_platform
{
    public partial class PersonSlove_4 : Form
    {
        string path;
        public PersonSlove_4()
        {
            InitializeComponent();
        }

        private void PersonSlove_4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo EzoneFile = new FileInfo(ofd.FileName);
                textBox1.Text = EzoneFile.FullName;
                if (ReadFile.GetuseFile(textBox1.Text))
                {
                    path = textBox1.Text;
                    textBox1.ReadOnly = true;
                    this.button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("选择的文件非jpg图片无法，请重选择");
                    textBox1.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int key = Int32.Parse(textBox2.Text);//验证时提供的密钥
            Publicinfo.Cindex = textBox3.Text.Length.ToString();
            string hexs = ReadFile.SloveFile(textBox1.Text, true);
            string outtext = ReadFile.USloveAll(hexs);
            outtext = Caesar.deciphering(outtext, key);
            if (!(textBox3.Text == ""))
            {
                if (outtext == textBox3.Text)
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
