﻿using System;
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
    public partial class OutCheck : Form
    {
        public OutCheck()
        {
            InitializeComponent();
        }

        private void bO_Click(object sender, EventArgs e)
        {
            this.Hide();
            OutFinish outFinish = new OutFinish();
            outFinish.Show();
            Program.ac.MainForm = outFinish;
            this.Close();
        }
    }
}