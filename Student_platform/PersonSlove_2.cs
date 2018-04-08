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
    public partial class PersonSlove_2 : Form
    {
        string path;
        public PersonSlove_2()
        {
            InitializeComponent();
        }

        private void PersonSlove_2_Load(object sender, EventArgs e)
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
            else
            {
                textBox2.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.SelectedPath;
                Publicinfo.Cindex = "4";
                string hexs = ReadFile.SloveFile(textBox1.Text, true);
                string paths = ReadFile.UAddSloveFile(hexs, textBox2.Text);
                textBox2.Text = "相对路径：" + paths;
                MessageBox.Show("隐写操作完成！文件已经保存");
            }
            else
            {
                MessageBox.Show("隐写操作失败");
            }
        }
    }
}
