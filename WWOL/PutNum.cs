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
    public partial class PutNum : Form
    {
        public PutNum()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {
            this.Hide();
            PutPW putPW = new PutPW();
            putPW.Show();
            Program.ac.MainForm = putPW;
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
