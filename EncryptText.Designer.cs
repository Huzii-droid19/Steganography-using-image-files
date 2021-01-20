namespace Stegano
{
    partial class EncryptText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptText));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panelEncrypt = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.labelClickToAdd = new System.Windows.Forms.Label();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(0, -3);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(510, 178);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Visible = false;
            // 
            // panelEncrypt
            // 
            this.panelEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.panelEncrypt.Location = new System.Drawing.Point(375, 482);
            this.panelEncrypt.Name = "panelEncrypt";
            this.panelEncrypt.Size = new System.Drawing.Size(337, 54);
            this.panelEncrypt.TabIndex = 1;
            this.panelEncrypt.Click += new System.EventHandler(this.panelEncrypt_Click);
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.textBoxInput);
            this.panelText.Controls.Add(this.labelClickToAdd);
            this.panelText.Location = new System.Drawing.Point(289, 219);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(510, 175);
            this.panelText.TabIndex = 3;
            this.panelText.Click += new System.EventHandler(this.panelText_Click);
            // 
            // labelClickToAdd
            // 
            this.labelClickToAdd.AutoSize = true;
            this.labelClickToAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToAdd.Location = new System.Drawing.Point(112, 58);
            this.labelClickToAdd.Name = "labelClickToAdd";
            this.labelClickToAdd.Size = new System.Drawing.Size(278, 45);
            this.labelClickToAdd.TabIndex = 0;
            this.labelClickToAdd.Text = "Click to add text";
            this.labelClickToAdd.Click += new System.EventHandler(this.labelClickToAdd_Click);
            // 
            // EncryptText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 612);
            this.Controls.Add(this.panelEncrypt);
            this.Controls.Add(this.panelText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Click += new System.EventHandler(this.EncryptText_Click);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Panel panelEncrypt;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label labelClickToAdd;
    }
}