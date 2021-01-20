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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
            //huzaifa
        }

        private void panelEncrypt_Click(object sender, EventArgs e)
        {
            new EncryptImage().Show();
            this.Close();
        }

        private void panelDecrypt_Click(object sender, EventArgs e)
        {
            new DecryptImage().Show();
            this.Close();
        }
    }
}
