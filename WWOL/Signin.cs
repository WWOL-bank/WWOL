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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            this.Hide();

            string t1 = textBox1.Text.ToString();
            string t2 = textBox2.Text.ToString();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;userid=root;Pwd=6311yjnoh*");

            connection.Open();

            

            MySqlCommand comm = connection.CreateCommand();


            Random rand = new Random();
            int a = rand.Next(100, 1000);
            int b = rand.Next(100, 1000);
            int c = rand.Next(1000, 10000);

            Program.RR(out Program.rnd, a, b, c);

            comm.CommandText = "INSERT INTO user(userid,userpw,usernb) VALUES('" + t1 + "','" + t2 + "','" + Program.rnd+ "');";

            comm.ExecuteNonQuery();
            connection.Close();

            SignFinish signfinish = new SignFinish();
            signfinish.Show();
            Program.ac.MainForm = signfinish;
            this.Close();
        }


    }


}
