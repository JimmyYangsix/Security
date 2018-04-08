using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_platform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Checkuse.GetMD5("惠阳") == Pwd.Text)
            {
                Publicinfo.isImportant = true;
                Checkuse.first();
                ReadFile.WriteFile(Checkuse.GetMD5("惠阳"));
                MessageBox.Show("验证通过");
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
