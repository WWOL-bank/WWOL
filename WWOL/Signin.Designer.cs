
namespace WWOL
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.label2.Font = new System.Drawing.Font("한컴 고딕", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.label3.Font = new System.Drawing.Font("한컴 고딕", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(281, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(476, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 59);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("한컴 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox2.Location = new System.Drawing.Point(476, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 59);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.sign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sign.BackgroundImage")));
            this.sign.FlatAppearance.BorderSize = 0;
            this.sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign.Font = new System.Drawing.Font("한컴 고딕", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sign.Location = new System.Drawing.Point(789, 450);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(160, 85);
            this.sign.TabIndex = 5;
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signin";
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sign;
    }
}