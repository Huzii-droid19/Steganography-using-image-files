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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panelStart_Click(object sender, EventArgs e)
        {
            //when click on start, it will proceed to Choice Frame
            new Choice().Show();
            this.Close();
        }
    }
}
