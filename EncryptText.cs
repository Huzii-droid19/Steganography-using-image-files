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
    public partial class EncryptText : Form
    {
        private string path;
        public EncryptText()
        {
            InitializeComponent();
            this.path = string.Empty;
        }
        public EncryptText(string path)
        {
            InitializeComponent();
            this.path = path;
        }
        private void panelEncrypt_Click(object sender, EventArgs e)
        {
            if (this.textBoxInput.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Text to Encrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new EncryptKey(this.path, this.textBoxInput.Text).Show();
                this.Close();
            }
        }

        private void labelClickToAdd_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Visible = true;
            this.textBoxInput.Focus();
        }

        private void panelText_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Visible = true;
            this.textBoxInput.Focus();
        }

        private void EncryptText_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Visible = false;
            this.textBoxInput.Focus();
        }
    }
}
