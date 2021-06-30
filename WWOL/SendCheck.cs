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
    public partial class SendCheck : Form
    {
        public SendCheck()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendFinish sendFinish = new SendFinish();
            sendFinish.Show();
            Program.ac.MainForm = sendFinish;
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
