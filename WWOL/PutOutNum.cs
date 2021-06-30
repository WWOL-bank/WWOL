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

        private void b1_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textField.Text = textField.Text + "0";
        }

        private void bb_Click(object sender, EventArgs e)
        {
            textField.Text = "";
            textField.Focus();
            textField.Select(textField.Text.Length, 0);
        }
    }
}
