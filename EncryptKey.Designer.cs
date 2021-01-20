namespace Stegano
{
    partial class EncryptKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptKey));
            this.panelEncrypt = new System.Windows.Forms.Panel();
            this.textBoxEncrytionKey = new System.Windows.Forms.TextBox();
            this.panelKey = new System.Windows.Forms.Panel();
            this.panelKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncrypt
            // 
            this.panelEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.panelEncrypt.Location = new System.Drawing.Point(374, 484);
            this.panelEncrypt.Name = "panelEncrypt";
            this.panelEncrypt.Size = new System.Drawing.Size(338, 52);
            this.panelEncrypt.TabIndex = 1;
            this.panelEncrypt.Click += new System.EventHandler(this.panelEncrypt_Click);
            // 
            // textBoxEncrytionKey
            // 
            this.textBoxEncrytionKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEncrytionKey.Location = new System.Drawing.Point(0, 0);
            this.textBoxEncrytionKey.Multiline = true;
            this.textBoxEncrytionKey.Name = "textBoxEncrytionKey";
            this.textBoxEncrytionKey.Size = new System.Drawing.Size(509, 176);
            this.textBoxEncrytionKey.TabIndex = 0;
            this.textBoxEncrytionKey.Visible = false;
            // 
            // panelKey
            // 
            this.panelKey.BackColor = System.Drawing.Color.Transparent;
            this.panelKey.Controls.Add(this.textBoxEncrytionKey);
            this.panelKey.Location = new System.Drawing.Point(289, 218);
            this.panelKey.Name = "panelKey";
            this.panelKey.Size = new System.Drawing.Size(509, 176);
            this.panelKey.TabIndex = 2;
            this.panelKey.Click += new System.EventHandler(this.panelKey_Click);
            // 
            // EncryptKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 612);
            this.Controls.Add(this.panelKey);
            this.Controls.Add(this.panelEncrypt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Click += new System.EventHandler(this.EncryptKey_Click);
            this.panelKey.ResumeLayout(false);
            this.panelKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEncrypt;
        private System.Windows.Forms.TextBox textBoxEncrytionKey;
        private System.Windows.Forms.Panel panelKey;
    }
}