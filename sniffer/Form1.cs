using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPcap;
using PacketDotNet;
namespace sniffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "退出", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceNet cn = new ChoiceNet();
            cn.Show();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repair.Enabled = false;
            publicinfo.usedevice.StopCapture();//停止捕获
            publicinfo.usedevice.Close();
            MessageBox.Show("停止抓包");
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (publicinfo.usedevice == null)
                {
                }
            }
            catch
            {
                return;
            }
            Slove.Getinfo();//调用开启网卡捕获的方法
            //publicinfo.usedevice.StartCapture();//开始捕获
            repair.Enabled = true;
            MessageBox.Show("开始抓包");
        }

        private void repair_Tick(object sender, EventArgs e)
        {
            List<Data> uselist = new List<Data>();
            uselist = publicinfo.alldatapacket;
            AllPacketdata.Rows.Clear();
            int i = publicinfo.alldatapacket.Count;
            try
            {
                foreach (Data use in uselist)
                {
                    int j = publicinfo.alldatapacket.IndexOf(use);
                    if (j == i)
                    {
                        break;
                    }
                    AllPacketdata.Rows.Add(use.id, use.type, use.sip, use.sport, use.dip, use.dport, use.alen, use.slen, publicinfo.Tohex(use.ahead), publicinfo.Tohex(use.mhead));
                }
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            repair.Enabled = false;
        }


        private void AllPacketdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Data usedata = publicinfo.alldatapacket.Where(d=>d.id==e.RowIndex).FirstOrDefault();
           MessageBox.Show(publicinfo.Tohex( usedata.info),"报文体内容"); 
        }

        private void 筛选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceType ct = new ChoiceType();
            ct.Show();
        }
    }
}
