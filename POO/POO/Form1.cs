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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void administrativeLoginPopout_Click(object sender, EventArgs e)
        {
            Form2 administrativeLogin = new Form2();
            administrativeLogin.Show();
            this.Hide();
            
        }

        private void loginInStudent_Click(object sender, EventArgs e)
        {


            /*loadingScreen loadingScreen = new loadingScreen();
            this.Hide();
            loadingScreen.Show();*/

      
            
            if (MainClass.isValidUser(guna2TextBox1.Text, guna2TextBox2.Text) == false)
            {


          

                 Console.WriteLine("sucks");
                 return;

            }
            else {
                loadingScreen loadingScreen = new loadingScreen();
                this.Hide();
                loadingScreen.Show();
            }
         
        }
    }
}
