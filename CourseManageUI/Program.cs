using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using CourseManageModels;

namespace CourseManageUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //显示登录窗体
            FrmAdminLogin frmLogin = new FrmAdminLogin();
            //用Show()的话下面的代码会继续执行。
            DialogResult result = frmLogin.ShowDialog();//模式窗体可有返回值。模式窗体的好处，窗体不关闭下面的代码不执行。

            //通过登录窗体的返回值，确定是否显示主窗体
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
            
        }
        //定义全局变量
        public static Teacher currentTeacher = null;
    }
}
