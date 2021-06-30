
namespace WWOL
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.signinBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinBtn
            // 
            this.signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.signinBtn.FlatAppearance.BorderSize = 0;
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("한컴 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.signinBtn.ForeColor = System.Drawing.Color.White;
            this.signinBtn.Location = new System.Drawing.Point(265, 120);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(295, 120);
            this.signinBtn.TabIndex = 1;
            this.signinBtn.Text = "회원가입";
            this.signinBtn.UseVisualStyleBackColor = false;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("한컴 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(637, 324);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(221, 120);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.signinBtn);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}