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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            num.Text = "계좌번호 : " + Program.rnd; // 계좌 번호: 랜덤값 표시

            time.Text = DateTime.Now.ToString("HH : mm"); // 현재 시간 표시
        }

        private void dissaving_Click(object sender, EventArgs e)
        {
            Program.CNIn(out Program.CN, "1");
            this.Hide();
            PutPW putPW = new PutPW();
            putPW.Show();
            Program.ac.MainForm = putPW;
            this.Close();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Program.CNIn(out Program.CN, "3");
            this.Hide();
            PutPW putPW = new PutPW();
            putPW.Show();
            Program.ac.MainForm = putPW;
            this.Close();
        }
    }
}
