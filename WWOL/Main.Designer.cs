
namespace WWOL
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button dissaving;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.transfer = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            dissaving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dissaving
            // 
            dissaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            dissaving.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dissaving.BackgroundImage")));
            dissaving.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(141)))));
            dissaving.FlatAppearance.BorderSize = 0;
            dissaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dissaving.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dissaving.Location = new System.Drawing.Point(236, 63);
            dissaving.Name = "dissaving";
            dissaving.Size = new System.Drawing.Size(250, 85);
            dissaving.TabIndex = 0;
            dissaving.UseVisualStyleBackColor = false;
            dissaving.Click += new System.EventHandler(this.dissaving_Click);
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.transfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transfer.BackgroundImage")));
            this.transfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(141)))));
            this.transfer.FlatAppearance.BorderSize = 0;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.transfer.Location = new System.Drawing.Point(639, 396);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(250, 85);
            this.transfer.TabIndex = 1;
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check.BackgroundImage")));
            this.check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(141)))));
            this.check.FlatAppearance.BorderSize = 0;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.check.Location = new System.Drawing.Point(639, 167);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(250, 85);
            this.check.TabIndex = 2;
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.deposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deposit.BackgroundImage")));
            this.deposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(141)))));
            this.deposit.FlatAppearance.BorderSize = 0;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deposit.Location = new System.Drawing.Point(236, 252);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(250, 85);
            this.deposit.TabIndex = 3;
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.White;
            this.time.Font = new System.Drawing.Font("한컴 고딕", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.time.Location = new System.Drawing.Point(322, 625);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(229, 65);
            this.time.TabIndex = 4;
            this.time.Text = "현재 시각";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.num.Font = new System.Drawing.Font("한컴 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.num.Location = new System.Drawing.Point(614, 95);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(297, 31);
            this.num.TabIndex = 5;
            this.num.Text = "계좌번호: 123-4567-8901";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.num);
            this.Controls.Add(this.time);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.check);
            this.Controls.Add(this.transfer);
            this.Controls.Add(dissaving);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label num;
    }
}