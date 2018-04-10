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
    public partial class Infocode : CCSkinMain
    {
        public static string context = "";
        public static string path2 = "";
        public Infocode()
        {
            InitializeComponent();
        }

        private void Infocode_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            context = Input.Text.Replace(" ", "");
            if (!(context == ""))
            {
                Data usedata = new Data();
                usedata.Datatext = context;
                context = Caesar.encrypation(usedata).Datatext;//返回凯撒加密后数据
                skinTextBox3.Text = usedata.key.ToString();
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo EzoneFile = new FileInfo(ofd.FileName);
                    skinTextBox2.Text = EzoneFile.FullName;
                    if (ReadFile.GetuseFile(skinTextBox2.Text))
                    {
                        path2 = skinTextBox2.Text;
                        skinTextBox2.ReadOnly = true;
                        this.skinButton1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("使用的文件非jpg图片或过大，请重选择");
                        skinTextBox2.Text = "";
                    }
                }
                else
                {
                    skinTextBox2.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("信息能为空");
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                skinTextBox1.Text = ofd.SelectedPath;
                string paths = ReadFile.SetoutputFile(context, path2, skinTextBox1.Text, false);
                skinTextBox1.Text = paths;
                MessageBox.Show("隐写操作完成！文件已经保存");
            }
            else
            {
                MessageBox.Show("隐写操作失败");
            }
        }
    }
}
