
namespace WWOL
{
    partial class SignFinish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignFinish));
            this.label1 = new System.Windows.Forms.Label();
            this.gomain = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "가입완료";
            // 
            // gomain
            // 
            this.gomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.gomain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gomain.BackgroundImage")));
            this.gomain.FlatAppearance.BorderSize = 0;
            this.gomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gomain.Location = new System.Drawing.Point(682, 448);
            this.gomain.Name = "gomain";
            this.gomain.Size = new System.Drawing.Size(234, 84);
            this.gomain.TabIndex = 1;
            this.gomain.UseVisualStyleBackColor = false;
            this.gomain.Click += new System.EventHandler(this.gomain_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(130)))), ((int)(((byte)(212)))));
            this.num.Font = new System.Drawing.Font("한컴 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.num.Location = new System.Drawing.Point(380, 343);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(297, 31);
            this.num.TabIndex = 2;
            this.num.Text = "계좌번호: 123-4567-8901";
            // 
            // SignFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.num);
            this.Controls.Add(this.gomain);
            this.Controls.Add(this.label1);
            this.Name = "SignFinish";
            this.Text = "SignFinish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gomain;
        private System.Windows.Forms.Label num;
    }
}