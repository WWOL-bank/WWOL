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
    public partial class PutInMoney : Form
    {
        public PutInMoney()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {
            if (Program.CN == "3")
            {
                this.Hide();
                InCheck inCheck= new InCheck();
                inCheck.Show();
                Program.ac.MainForm = inCheck;
                this.Close();
            }
            else if (Program.CN == "4")
            {
                this.Hide();
                SendCheck sendCheck = new SendCheck();
                sendCheck.Show();
                Program.ac.MainForm = sendCheck;
                this.Close();
            }
        }
    }
}
