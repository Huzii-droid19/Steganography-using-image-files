namespace Stegano
{
    partial class DecryptImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptImage));
            this.panelDecrypt = new System.Windows.Forms.Panel();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDecrypt
            // 
            this.panelDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.panelDecrypt.Location = new System.Drawing.Point(375, 522);
            this.panelDecrypt.Name = "panelDecrypt";
            this.panelDecrypt.Size = new System.Drawing.Size(339, 52);
            this.panelDecrypt.TabIndex = 0;
            this.panelDecrypt.Click += new System.EventHandler(this.panelDecrypt_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOutput.Location = new System.Drawing.Point(348, 130);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(392, 354);
            this.pictureBoxOutput.TabIndex = 0;
            this.pictureBoxOutput.TabStop = false;
            this.pictureBoxOutput.Click += new System.EventHandler(this.pictureBoxOutput_Click);
            // 
            // DecryptImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 612);
            this.Controls.Add(this.panelDecrypt);
            this.Controls.Add(this.pictureBoxOutput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.DecryptImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDecrypt;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
    }
}