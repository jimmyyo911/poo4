using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.View
{
    public partial class frmCategoryView : SampleAdd
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }

        public void GetData() {
         //  string qry = "Select * From category where catName like '%"+txtSearch.Text+"%'";
            ListBox lb = new ListBox();
          //  lb.Items.Add(dgvid);
          //  lb.Items.Add(dgvname);

           // MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        private  void frmCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }


        //frmCategoryAdd frm = new frmCategoryAdd();
       // frm.showDialog();
    }
}
