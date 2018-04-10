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
    public partial class USlove : CCSkinMain
    {
        string path;
        public USlove()
        {
            InitializeComponent();
        }

        private void USlove_Load(object sender, EventArgs e)
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
            else
            {
                skinTextBox1.ReadOnly = true;
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                skinTextBox1.Text = ofd.SelectedPath;
                Publicinfo.Cindex = "4";
                string hexs = ReadFile.SloveFile(Input.Text, true);
                string paths = ReadFile.UAddSloveFile(hexs, skinTextBox1.Text);
                skinTextBox1.Text = "相对路径：" + paths;
                MessageBox.Show("隐写操作完成！文件已经保存");
            }
            else
            {
                MessageBox.Show("隐写操作失败");
            }
        }
    }
}
