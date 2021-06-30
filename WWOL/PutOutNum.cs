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
    public partial class PutOutNum : Form
    {
        public PutOutNum()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {
            this.Hide();
            PutInMoney putInMoney = new PutInMoney();
            putInMoney.Show();
            Program.ac.MainForm = putInMoney;
            this.Close();
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
