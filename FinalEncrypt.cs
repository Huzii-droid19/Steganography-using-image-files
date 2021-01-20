using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stegano
{
    public partial class FinalEncrypt : Form
    {
        //holds provided image path, text, and passkey
        private string path, text, key;
        public FinalEncrypt()
        {
            InitializeComponent();
            this.path = this.text = this.key = string.Empty;
        }
        public FinalEncrypt(string path, string text, string key)
        {
            InitializeComponent();
            this.path = path;
            this.text = text;
            this.key = key;
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            //holds the dimensions of provided image
            var dim = (this.pictureBoxImage.Height * this.pictureBoxImage.Width) * 3;
            //holds the characters of text provided
            var characters = this.textBoxInput.Text.Length;
            //holds the limit value, if the limit=60,
            //which means you can embed only 60 bits.
            //So your text bit length must be less than limit.
            var limit = dim / 8;

            if (characters > limit)
            {
                MessageBox.Show("Cannot be able to encrypt\n" +
                    "Reason: Provided Image can Encrypt " + limit + " Characters\n" +
                    "Provided Characters: " + characters, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (this.pictureBoxImage.Image == null)
            {
                MessageBox.Show("Cannot be able to encrypt\n" +
                    "Reason: Image not provided", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBoxInput.Text.Equals(string.Empty))
            {
                MessageBox.Show("Cannot be able to encrypt\n" +
                    "Reason: Text not provided", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.key.Equals(string.Empty))
            {
                MessageBox.Show("Cannot be able to encrypt\n" +
                   "Reason: key not provided", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //embed the password key
                this.text = "<" + key + ">" + text;
                //calling cryptography function to embed text
                this.pictureBoxImage.Image = Cryptography.embedText(this.text, new Bitmap(this.pictureBoxImage.Image));
                //check if encryption is not successfull
                if (this.pictureBoxImage.Image != null)
                {
                    MessageBox.Show("Encryption done");
                    new EncryptFinal2(this.pictureBoxImage.Image).Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot be able to encrypt\n" +
                   "Reason: Some Error occured while encrypting", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void FinalEncrypt_Load(object sender, EventArgs e)
        {
            this.textBoxInput.Text = this.text;
            this.pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.Image = Image.FromFile(this.path);
            this.panel1.Focus();
        }
    }
}
