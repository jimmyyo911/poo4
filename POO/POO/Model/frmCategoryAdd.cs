using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Model
{
    public partial class frmCategoryAdd : Sample_Actual_Add
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Console.WriteLine("asdasdasd");
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {

            string qry = "";

            if (id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            //  ht.Add("@Name", txtName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                // txtName.focus();
            }
        }

    
        public override void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
