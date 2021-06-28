
namespace WWOL
{
    partial class PutOutNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PutOutNum));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 48.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(178, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "이체하실 계좌번호를 입력하세요";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("한컴 고딕", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox3.Location = new System.Drawing.Point(254, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(556, 92);
            this.textBox3.TabIndex = 12;
            // 
            // PutOutNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Name = "PutOutNum";
            this.Text = "PutOutNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}