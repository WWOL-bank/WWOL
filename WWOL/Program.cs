using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WWOL
{

    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>

        public static string CN = "0";
        public static void CNIn(out string CN, string ch)
        {
            CN = ch;
        }

        public static string rnd;
        public static void RR(out string rnd, int a, int b, int c)
        {
            rnd = a + "-" + b + "-" + c;
        }

        public static string mm;
        public static void MS(out string mm, string inM)
        {
            mm = inM;
        }

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
