using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWOL
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>

        public static ApplicationContext ac = new ApplicationContext();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartPage startPage = new StartPage();
            ac.MainForm = startPage;

            Application.Run(ac);
        }
    }
}
