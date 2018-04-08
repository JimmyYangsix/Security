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
    public partial class PersonSlove_3 : Form
    {
        public static string context = "";
        public static string path2 = "";
        public PersonSlove_3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context = textBox1.Text.Replace(" ", "");
            if (!(context == ""))
            {             
                Data usedata = new Data();
                usedata.Datatext = context;
                context = Caesar.encrypation(usedata).Datatext;//返回凯撒加密后数据
                textBox4.Text = usedata.key.ToString();
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
            else
            {
                MessageBox.Show("信息能为空");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = ofd.SelectedPath;
                string paths = ReadFile.SetoutputFile(context, path2, textBox3.Text,false);
                textBox3.Text = paths;
                MessageBox.Show("隐写操作完成！文件已经保存");
            }
            else
            {
                MessageBox.Show("隐写操作失败");
            }
        }

        private void PersonSlove_3_Load(object sender, EventArgs e)
        {
        
        }

    }
}

