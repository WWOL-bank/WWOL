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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin signin = new Signin();
            signin.Show();
            Program.ac.MainForm = signin;
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            Program.ac.MainForm = login;
            this.Close();
        }
    }
}
