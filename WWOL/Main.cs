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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dissaving_Click(object sender, EventArgs e)
        {
            this.Hide();
            PutNum putNum = new PutNum();
            putNum.Show();
            Program.ac.MainForm = putNum;
            this.Close();
        }

        private void check_Click(object sender, EventArgs e)
        {
            this.Hide();
            PutNum putNum = new PutNum();
            putNum.Show();
            Program.ac.MainForm = putNum;
            this.Close();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PutNum putNum = new PutNum();
            putNum.Show();
            Program.ac.MainForm = putNum;
            this.Close();
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            PutNum putNum = new PutNum();
            putNum.Show();
            Program.ac.MainForm = putNum;
            this.Close();
        }
    }
}
