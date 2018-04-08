using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using QRCoder;
using System.Drawing.Drawing2D;
namespace Student_platform
{
    public partial class Main_student : Form
    {
        public Main_student()
        {
            InitializeComponent();
        }

        private void Main_student_Load(object sender, EventArgs e)
        {


        }

        private void Slove1_Click(object sender, EventArgs e)
        {
            PersonSlove_1 pf1 = new PersonSlove_1();
            pf1.MdiParent = this;
            pf1.Show();
            pf1.Dock = DockStyle.Fill;
            pf1.FormBorderStyle = FormBorderStyle.None;
            this.Text = "图片隐写";
        }

        private void Slove2_Click(object sender, EventArgs e)
        {
            PersonSlove_2 pf2 = new PersonSlove_2();
            pf2.MdiParent = this;
            pf2.Show();
            pf2.Dock = DockStyle.Fill;
            pf2.FormBorderStyle = FormBorderStyle.None;
            this.Text = "解图片隐写";
        }

        private void Slove3_Click(object sender, EventArgs e)
        {
            PersonSlove_3 pf3 = new PersonSlove_3();
            pf3.MdiParent = this;
            pf3.Show();
            pf3.Dock = DockStyle.Fill;
            pf3.FormBorderStyle = FormBorderStyle.None;
            this.Text = "信息隐写";
        }

        private void Slove4_Click(object sender, EventArgs e)
        {
            PersonSlove_4 pf4 = new PersonSlove_4();
            pf4.MdiParent = this;
            pf4.Show();
            pf4.Dock = DockStyle.Fill;
            pf4.FormBorderStyle = FormBorderStyle.None;
            this.Text = "信息验证";
        }

        private void Slove5_Click(object sender, EventArgs e)
        {
            PersonSlove_5 pf5 = new PersonSlove_5();
            pf5.MdiParent = this;
            pf5.Show();
            pf5.Dock = DockStyle.Fill;
            pf5.FormBorderStyle = FormBorderStyle.None;
            this.Text = "图片生成";
        }

        private void Slove6_Click(object sender, EventArgs e)
        {
           Checkuse.first();
            if (Publicinfo.isAccept )
            {
                Publicinfo.useCode= Checkuse.GetMD5("惠阳");//授权内容
                ReadFile.WriteFile(Publicinfo.useCode);
                MessageBox.Show("授权成功");
                PersonSlove_6 pf6= new PersonSlove_6();
                pf6.MdiParent = this;
                pf6.Show();
                pf6.Dock = DockStyle.Fill;
                pf6.FormBorderStyle = FormBorderStyle.None;
                this.Text = "授权二维码生成";
            }
            else
            {
                MessageBox.Show("未检查到已经授权的U盘,请重试");
            }
        }

        private void Slove7_Click(object sender, EventArgs e)
        {
            PersonSlove_7 pf7 = new PersonSlove_7();
            pf7.MdiParent = this;
            pf7.Show();
            pf7.Dock = DockStyle.Fill;
            pf7.FormBorderStyle = FormBorderStyle.None;
        }

        private void Notice_Click(object sender, EventArgs e)
        {
            PublicNotice pn = new PublicNotice();
            pn.MdiParent = this;
            pn.Show();
            pn.Dock = DockStyle.Fill;
            pn.FormBorderStyle = FormBorderStyle.None;
        }

        private void MessageTo_Click(object sender, EventArgs e)
        {
            MessageLeave ml = new MessageLeave();
            ml.MdiParent = this;
            ml.Show();
            ml.Dock = DockStyle.Fill;
            ml.FormBorderStyle = FormBorderStyle.None;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出", "用户退出窗口", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
