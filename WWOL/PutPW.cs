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
            string str = textField.Text;
            str.Substring(0, str.Length - 1);

            textField.Text = str;

            textField.Focus();
            textField.Select(textField.Text.Length, 0);
        }
    }
}