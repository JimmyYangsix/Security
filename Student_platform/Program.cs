using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_platform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Checkuse.first();
            Checkuse.Second();
            if (Publicinfo.isAccept&&Publicinfo.isImportant)
            {
               Application.Run(new Main_student());
            }
            else
            {
                MessageBox.Show("未检查到U盘或U盘未授权");
                if (Publicinfo.isAccept == true && Publicinfo.isImportant == false)
                {
                    MessageBox.Show("请输入授权码登录");
                    Application.Run(new LoginForm());
                    if (Publicinfo.isImportant)
                    {
                        Application.Run(new Main_student());
                    }
                }
            }
             
        }
    }
}
