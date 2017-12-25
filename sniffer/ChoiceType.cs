using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sniffer
{
    public partial class ChoiceType : Form
    {
        public ChoiceType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            publicinfo.type = -1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            publicinfo.type = comboBox1.SelectedIndex;
            this.Close();
        }
    }
}
