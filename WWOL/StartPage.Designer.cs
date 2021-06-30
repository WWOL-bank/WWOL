
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
            this.SuspendLayout();
            // 
            // signinBtn
            // 
            this.signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.signinBtn.FlatAppearance.BorderSize = 0;
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("한컴 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.signinBtn.ForeColor = System.Drawing.Color.White;
            this.signinBtn.Location = new System.Drawing.Point(476, 215);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(295, 120);
            this.signinBtn.TabIndex = 1;
            this.signinBtn.Text = "회원가입";
            this.signinBtn.UseVisualStyleBackColor = false;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.signinBtn);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signinBtn;
    }
}