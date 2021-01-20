using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Stegano
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            //start the timerand call timer tick after 3 seconds
            timerSleep.Start();
        }

        private void timerSleep_Tick(object sender, EventArgs e)
        {
            //stops timer
            timerSleep.Stop();
            //proceed to main window
            new Main().Show();
            this.Hide();
        }
    }
}
