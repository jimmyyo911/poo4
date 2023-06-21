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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void studentLoginBtn_Click(object sender, EventArgs e)
        {
            Form1 studentLoginBtn = new Form1();
            
            studentLoginBtn.Show();
            this.Close();
        }

        private void loginInStudent_Click(object sender, EventArgs e)
        {
            

        }

        private void loginInStudent_Click_1(object sender, EventArgs e)
        {

        }
    }
}
