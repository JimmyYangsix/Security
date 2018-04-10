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
using System.Media;

namespace Info_proform
{
    public partial class Slove : CCSkinMain
    {
        public static string path1 = "";
        public static string path2 = "";
        public Slove()
        {
            InitializeComponent();
        }

        private void Slove_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo EzoneFile = new FileInfo(ofd.FileName);
                Input.Text = EzoneFile.FullName;
                if (ReadFile.GetinputFile(Input.Text))
                {
                    path1 = Input.Text;
                    Input.ReadOnly = true;
                    this.skinButton1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("使用的文件非txt文本，请重选择");
                    Input.Text = "";
                }
            }
            else
            {
                Input.ReadOnly = true;
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo EzoneFile = new FileInfo(ofd.FileName);
                skinTextBox1.Text = EzoneFile.FullName;
                if (ReadFile.GetuseFile(skinTextBox1.Text))
                {
                    path2 = skinTextBox1.Text;
                    skinTextBox1.ReadOnly = true;
                    this.skinButton2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("使用的文件非jpg图片或过大，请重选择");
                    skinTextBox1.Text = "";
                }
            }
            else
            {
                skinTextBox1.ReadOnly = true;
            }
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                skinTextBox2.Text = ofd.SelectedPath;
                string paths = ReadFile.SetoutputFile(path1, path2, skinTextBox2.Text, true);
                skinTextBox2.Text = paths;
                MessageBox.Show("隐写操作完成！文件已经保存");
            }
            else
            {
                MessageBox.Show("隐写操作失败");
            }
        }
    }
}
