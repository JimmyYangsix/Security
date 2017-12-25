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
    public partial class ChoiceNet : Form
    {
        public ChoiceNet()
        {
            InitializeComponent();
        }

        private void ChoiceNet_Load(object sender, EventArgs e)
        {
            if (!publicinfo.reload)
            {
                publicinfo.selectid = -1;
                GetNetBIOS.GetallNet();
                publicinfo.reload = true;
            }
            foreach (string info in GetNetBIOS.NetBIOSinfo)
            {
                Allinfo.Items.Add(info);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            publicinfo.selectid = Allinfo.SelectedIndex;
            this.Close();
        }
    }
}
