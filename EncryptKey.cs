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
    public partial class EncryptKey : Form
    {
        private string path, text;
        public EncryptKey()
        {
            InitializeComponent();
            this.path = this.text = string.Empty;
        }
        public EncryptKey(string path, string text)
        {
            InitializeComponent();
            this.path = path;
            this.text = text;
        }

        private void panelKey_Click(object sender, EventArgs e)
        {
            this.textBoxEncrytionKey.Visible = true;
            this.textBoxEncrytionKey.Focus();
        }

        private void panelEncrypt_Click(object sender, EventArgs e)
        {
            if (this.textBoxEncrytionKey.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please Provide Encryption Key", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBoxEncrytionKey.Text.Length < 8)
            {
                MessageBox.Show("Encryption key at least 8 characters long", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new FinalEncrypt(this.path, this.text, this.textBoxEncrytionKey.Text).Show();
                this.Close();
            }


        }

        private void EncryptKey_Click(object sender, EventArgs e)
        {
            this.textBoxEncrytionKey.Visible = false;
        }
    }
}
