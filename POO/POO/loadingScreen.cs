using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 700)
            {
                timer1.Stop();
                studentDashboard studentDashboard = new studentDashboard();
                studentDashboard.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
