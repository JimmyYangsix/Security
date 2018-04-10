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

namespace Info_proform
{
    public partial class Main_Form : CCSkinMain
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭所有子窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public  void CloseChild()
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void 图片隐写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            Slove pf1 = new Slove();
            pf1.MdiParent = this;
            pf1.WindowState = FormWindowState.Maximized;
            pf1.Dock = DockStyle.Fill;
            pf1.FormBorderStyle = FormBorderStyle.None;
            pf1.Show();
            this.Text = "图片隐写";
        }

        private void 提取文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            USlove pf2 = new USlove();
            pf2.MdiParent = this;
            pf2.WindowState = FormWindowState.Maximized;
            pf2.Dock = DockStyle.Fill;
            pf2.FormBorderStyle = FormBorderStyle.None;
            pf2.Show();
            this.Text = "提取文件";
        }

        private void 水印写入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            Infocode pf3 = new Infocode();
            pf3.MdiParent = this;
            pf3.WindowState = FormWindowState.Maximized;
            pf3.Dock = DockStyle.Fill;
            pf3.FormBorderStyle = FormBorderStyle.None;
            pf3.Show();
            this.Text = "水印写入";
        }

        private void 信息验证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            UInfocode pf4 = new UInfocode();
            pf4.MdiParent = this;
            pf4.WindowState = FormWindowState.Maximized;
            pf4.Dock = DockStyle.Fill;
            pf4.FormBorderStyle = FormBorderStyle.None;
            pf4.Show();
            this.Text = "水印写入";
        }

        private void 图片生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            PicInfo pf5 = new PicInfo();
            pf5.MdiParent = this;
            pf5.WindowState = FormWindowState.Maximized;
            pf5.Dock = DockStyle.Fill;
            pf5.FormBorderStyle = FormBorderStyle.None;
            pf5.Show();
            this.Text = "图片生成";
        }

        private void 软件授权ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            AddUser pf6 = new AddUser();
            pf6.MdiParent = this;
            pf6.WindowState = FormWindowState.Maximized;
            pf6.Dock = DockStyle.Fill;
            pf6.FormBorderStyle = FormBorderStyle.None;
            pf6.Show();
            this.Text = "图片生成";
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出", "用户退出窗口", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
