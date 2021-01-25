namespace Picturebox_zad2
{
    partial class Form1
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
            this.lablJedan = new System.Windows.Forms.Label();
            this.picTakumi = new System.Windows.Forms.PictureBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTakumi)).BeginInit();
            this.SuspendLayout();
            // 
            // lablJedan
            // 
            this.lablJedan.AutoSize = true;
            this.lablJedan.Location = new System.Drawing.Point(13, 13);
            this.lablJedan.Name = "lablJedan";
            this.lablJedan.Size = new System.Drawing.Size(59, 13);
            this.lablJedan.TabIndex = 0;
            this.lablJedan.Text = "Fotografija:";
            // 
            // picTakumi
            // 
            this.picTakumi.Image = global::Picturebox_zad2.Properties.Resources.Takumi1;
            this.picTakumi.Location = new System.Drawing.Point(92, 60);
            this.picTakumi.Name = "picTakumi";
            this.picTakumi.Size = new System.Drawing.Size(407, 301);
            this.picTakumi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTakumi.TabIndex = 1;
            this.picTakumi.TabStop = false;
            this.picTakumi.Click += new System.EventHandler(this.picTakumi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(246, 392);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(96, 28);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi sliku";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 469);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.picTakumi);
            this.Controls.Add(this.lablJedan);
            this.Name = "Form1";
            this.Text = "Upotreba PictureBox kontrole";
            ((System.ComponentModel.ISupportInitialize)(this.picTakumi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablJedan;
        private System.Windows.Forms.PictureBox picTakumi;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

