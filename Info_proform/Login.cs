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
    public partial class Login : CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TitleCenter = true;         
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Publicinfo.change > 0)
            {
                if (Checkuse.GetMD5("惠阳") == Input.Text)
                {
                    Publicinfo.isImportant = true;
                    Checkuse.first();
                    ReadFile.WriteFile(Checkuse.GetMD5("惠阳"));
                    MessageBox.Show("验证通过");
                    this.Close();
                }
                else
                {
                    this.timer1.Enabled = false;
                    Publicinfo.change--;
                    skinTextBox1.Text = Publicinfo.change.ToString();
                    label2.Text = "60";
                    Publicinfo.second = 60;
                    this.timer1.Enabled = true;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {     
            Publicinfo.second = Convert.ToInt32(label2.Text);
            if (Publicinfo.second <= 0)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
            else
            {
                Publicinfo.second--;
                label2.Text = Publicinfo.second.ToString();
            }
        }
    }
}
