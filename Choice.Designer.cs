namespace Stegano
{
    partial class Choice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice));
            this.panelEncrypt = new System.Windows.Forms.Panel();
            this.panelDecrypt = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelEncrypt
            // 
            this.panelEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.panelEncrypt.Location = new System.Drawing.Point(121, 380);
            this.panelEncrypt.Name = "panelEncrypt";
            this.panelEncrypt.Size = new System.Drawing.Size(334, 56);
            this.panelEncrypt.TabIndex = 0;
            this.panelEncrypt.Click += new System.EventHandler(this.panelEncrypt_Click);
            // 
            // panelDecrypt
            // 
            this.panelDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.panelDecrypt.Location = new System.Drawing.Point(631, 380);
            this.panelDecrypt.Name = "panelDecrypt";
            this.panelDecrypt.Size = new System.Drawing.Size(334, 56);
            this.panelDecrypt.TabIndex = 1;
            this.panelDecrypt.Click += new System.EventHandler(this.panelDecrypt_Click);
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 612);
            this.Controls.Add(this.panelDecrypt);
            this.Controls.Add(this.panelEncrypt);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEncrypt;
        private System.Windows.Forms.Panel panelDecrypt;
    }
}