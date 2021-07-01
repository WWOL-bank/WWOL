
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
            this.deposit = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            dissaving = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            dissaving.Location = new System.Drawing.Point(263, 168);
            dissaving.Name = "dissaving";
            dissaving.Size = new System.Drawing.Size(250, 85);
            dissaving.TabIndex = 0;
            dissaving.UseVisualStyleBackColor = false;
            dissaving.Click += new System.EventHandler(this.dissaving_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.deposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deposit.BackgroundImage")));
            this.deposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(141)))));
            this.deposit.FlatAppearance.BorderSize = 0;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deposit.Location = new System.Drawing.Point(640, 343);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(620, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.time);
            this.Controls.Add(this.deposit);
            this.Controls.Add(dissaving);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}