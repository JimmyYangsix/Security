using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_proform
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
            Console.Write(Checkuse.GetMD5("惠阳"));
            Checkuse.first();
            Checkuse.Second();
            if (Publicinfo.isAccept && Publicinfo.isImportant)
            {
                Application.Run(new Main_Form());
            }
            else
            {
                MessageBox.Show("未检查到U盘或U盘未授权");
                if (Publicinfo.isAccept == true && Publicinfo.isImportant == false)
                {
                    MessageBox.Show("请输入授权码登录");
                    Console.WriteLine(Checkuse.GetMD5("惠阳"));
                    Application.Run(new Login());
                    if (Publicinfo.isImportant)
                    {
                        Application.Run(new Main_Form());
                    }
                }
            }       
        }
    }
}
