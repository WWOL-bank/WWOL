
namespace WWOL
{
    partial class OutCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(183, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 114);
            this.label1.TabIndex = 4;
            this.label1.Text = "출금하실 금액을 확인하시고\r\n맞으면 확인 틀리면 취소를 누르세요\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("한컴 고딕", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(280, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 85);
            this.label2.TabIndex = 5;
            this.label2.Text = "MONEY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bO
            // 
            this.bO.BackColor = System.Drawing.Color.White;
            this.bO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bO.BackgroundImage")));
            this.bO.FlatAppearance.BorderSize = 0;
            this.bO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bO.Location = new System.Drawing.Point(590, 570);
            this.bO.Name = "bO";
            this.bO.Size = new System.Drawing.Size(246, 80);
            this.bO.TabIndex = 6;
            this.bO.UseVisualStyleBackColor = false;
            this.bO.Click += new System.EventHandler(this.bO_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(263, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 80);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // OutCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OutCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bO;
        private System.Windows.Forms.Button button2;
    }
}