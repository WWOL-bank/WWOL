using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWOL
{
    public partial class PutPW : Form
    {
        public PutPW()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {
            if(Program.CN == "1")
            {
                this.Hide();
                PutOutMoney putOutMoney = new PutOutMoney();
                putOutMoney.Show();
                Program.ac.MainForm = putOutMoney;
                this.Close();
            } else if (Program.CN == "2")
            {
                this.Hide();
                BankNumCheck bankNumCheck = new BankNumCheck();
                bankNumCheck.Show();
                Program.ac.MainForm = bankNumCheck;
                this.Close();
            } else if (Program.CN == "3")
            {
                this.Hide();
                PutInMoney putInMoney = new PutInMoney();
                putInMoney.Show();
                Program.ac.MainForm = putInMoney;
                this.Close();
            } else if(Program.CN == "4")
            {
                this.Hide();
                PutOutNum putOutNum = new PutOutNum();
                putOutNum.Show();
                Program.ac.MainForm = putOutNum;
                this.Close();
            }
        }

        private void bX_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
            Program.ac.MainForm = main;
            this.Close();
        }
    }
}
