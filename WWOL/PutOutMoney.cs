using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WWOL
{
    public partial class PutOutMoney : Form
    {
        public PutOutMoney()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;userid=root;Pwd=6311yjnoh*");

            connection.Open();


            MySqlCommand comm = connection.CreateCommand();

            int cash = int.Parse(textField.Text);

            comm.CommandText = "UPDATE user SET cash = cash - " + cash + "WHERE usernb = '" + Program.rnd + "');";

            connection.Close();

            this.Hide();
            OutCheck outCheck= new OutCheck();
            outCheck.Show();
            Program.ac.MainForm = outCheck;
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

        private void PutOutMoney_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void textField_TextChanged(object sender, EventArgs e)
        {
            Program.MS(out Program.mm, textField.Text);
        }
    }
}
