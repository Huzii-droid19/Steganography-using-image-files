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
    public partial class EncryptFinal2 : Form
    {
        private IFile file;
        public EncryptFinal2()
        {
            InitializeComponent();
            this.file = new File();
        }
        public EncryptFinal2(Image img)
        {
            InitializeComponent();
            this.pictureBox1.Image = img;
            this.file = new File();
        }
        private void panelDone_Click(object sender, EventArgs e)
        {
            this.file.SaveImageFile(this.pictureBox1.Image);
            new Main().Show();
            this.Close();
        }
        private void EncryptFinal2_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
