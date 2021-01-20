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
    public partial class DecryptText : Form
    {
        public DecryptText()
        {
            InitializeComponent();
        }
        public DecryptText(string text)
        {
            InitializeComponent();
            this.textBoxOutput.Text = text;
        }

        private void panelDecrypt_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
