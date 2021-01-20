using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stegano
{
    public partial class EncryptImage : Form
    {
        private string path;
        private IFile file;
        public EncryptImage()
        {
            InitializeComponent();
            this.path = string.Empty;
            this.file = new File();
        }

        private void panelEncrypt_Click(object sender, EventArgs e)
        {
            if (this.path.Equals(string.Empty) || this.pictureBoxInput.Image == null)
            {
                MessageBox.Show("Please Select Input Image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new EncryptText(this.path).Show();
                this.Close();
            }

        }
        private void pictureBoxInput_Click(object sender, EventArgs e)
        {
            this.path = file.ReadImageFile();
            if (path != string.Empty)
            {
                this.pictureBoxInput.Image = Image.FromFile(this.path);
            }
        }

        private void EncryptImage_Load(object sender, EventArgs e)
        {
            this.pictureBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
