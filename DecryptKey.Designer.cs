namespace Stegano
{
    partial class DecryptKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptKey));
            this.panelDecrypt = new System.Windows.Forms.Panel();
            this.panelKey = new System.Windows.Forms.Panel();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.panelKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDecrypt
            // 
            this.panelDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.panelDecrypt.Location = new System.Drawing.Point(375, 521);
            this.panelDecrypt.Name = "panelDecrypt";
            this.panelDecrypt.Size = new System.Drawing.Size(337, 52);
            this.panelDecrypt.TabIndex = 1;
            this.panelDecrypt.Click += new System.EventHandler(this.panelDecrypt_Click);
            // 
            // panelKey
            // 
            this.panelKey.BackColor = System.Drawing.Color.Transparent;
            this.panelKey.Controls.Add(this.textBoxKey);
            this.panelKey.Location = new System.Drawing.Point(289, 220);
            this.panelKey.Name = "panelKey";
            this.panelKey.Size = new System.Drawing.Size(508, 175);
            this.panelKey.TabIndex = 1;
            this.panelKey.Click += new System.EventHandler(this.panelKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxKey.Location = new System.Drawing.Point(-2, -1);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(511, 176);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.Visible = false;
            // 
            // DecryptKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 612);
            this.Controls.Add(this.panelKey);
            this.Controls.Add(this.panelDecrypt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Click += new System.EventHandler(this.DecryptKey_Click);
            this.panelKey.ResumeLayout(false);
            this.panelKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDecrypt;
        private System.Windows.Forms.Panel panelKey;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}