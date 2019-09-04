using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 管理系统
{
    static class Program
    {
        /// <summary>
        /// 入口点
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new frmBill());
        }
    }
}
