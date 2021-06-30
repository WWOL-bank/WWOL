
namespace WWOL
{
    partial class BankNumCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankNumCheck));
            this.bO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bO
            // 
            this.bO.BackColor = System.Drawing.Color.White;
            this.bO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bO.BackgroundImage")));
            this.bO.FlatAppearance.BorderSize = 0;
            this.bO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bO.Location = new System.Drawing.Point(389, 630);
            this.bO.Name = "bO";
            this.bO.Size = new System.Drawing.Size(246, 80);
            this.bO.TabIndex = 0;
            this.bO.UseVisualStyleBackColor = false;
            this.bO.Click += new System.EventHandler(this.bO_Click);
            // 
            // BankNumCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bO);
            this.Name = "BankNumCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankNumCheck";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bO;
    }
}