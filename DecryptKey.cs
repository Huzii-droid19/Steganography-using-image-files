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
    public partial class DecryptKey : Form
    {
        private string path;
        public DecryptKey()
        {
            InitializeComponent();
            this.path = string.Empty;
        }
        public DecryptKey(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void panelDecrypt_Click(object sender, EventArgs e)
        {
            string text = Cryptography.extractText(new Bitmap(Image.FromFile(path)));
            var key = text.Split('>');
            key[0] = key[0].Substring(1);
            if (this.textBoxKey.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please Provide Key", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!key[0].Equals(this.textBoxKey.Text))
            {
                MessageBox.Show("Invalid Key Provided!", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new DecryptText(key[1]).Show();
                this.Close();
            }


        }

        private void panelKey_Click(object sender, EventArgs e)
        {
            this.textBoxKey.Visible = true;
            this.textBoxKey.Focus();
        }

        private void DecryptKey_Click(object sender, EventArgs e)
        {
            this.textBoxKey.Visible = false;
        }
    }
}
