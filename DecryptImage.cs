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
    public partial class DecryptImage : Form
    {
        private IFile file;
        private string path;
        public DecryptImage()
        {
            InitializeComponent();
            this.file = new File();
            this.path = string.Empty;
        }

        private void pictureBoxOutput_Click(object sender, EventArgs e)
        {
            this.path = file.ReadImageFile();
            if (path != string.Empty)
            {
                this.pictureBoxOutput.Image = Image.FromFile(this.path);
            }
        }

        private void panelDecrypt_Click(object sender, EventArgs e)
        {
            new DecryptKey(this.path).Show();
            this.Close();
        }

        private void DecryptImage_Load(object sender, EventArgs e)
        {
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
