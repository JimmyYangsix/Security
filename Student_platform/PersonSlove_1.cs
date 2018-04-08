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
using System.Media;

namespace Student_platform
{
    public partial class PersonSlove_1 : Form
    {
        public static string path1 = "";
        public static string path2 = "";
        public PersonSlove_1()
        {
            InitializeComponent();
        }

        private void PersonSlove_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo EzoneFile = new FileInfo(ofd.FileName);
                textBox1.Text = EzoneFile.FullName;
                if (ReadFile.GetinputFile(textBox1.Text))
                {
                    path1 = textBox1.Text;
                    textBox1.ReadOnly = true;
                    this.button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("使用的文件非txt文本，请重选择");
                    textBox1.Text = "";
                }
            }
            else
            {
                textBox1.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo EzoneFile = new FileInfo(ofd.FileName);
                textBox2.Text = EzoneFile.FullName;
                if (ReadFile.GetuseFile(textBox2.Text))
                {
                    path2 = textBox2.Text;
                    textBox2.ReadOnly = true;
                    this.button2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("使用的文件非jpg图片或过大，请重选择");
                    textBox2.Text = "";
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
                textBox3.Text = ofd.SelectedPath;
                string paths = ReadFile.SetoutputFile(path1, path2, textBox3.Text,true);
                textBox3.Text = paths;
                MessageBox.Show("隐写操作完成！文件已经保存");
            }
            else
            {
                MessageBox.Show("隐写操作失败");
            }
        }
    }
}
