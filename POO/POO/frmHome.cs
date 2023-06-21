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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void AddControls(Form f)
        {

            CoursesPanel.Controls.Clear();
            f.Dock = System.Windows.Forms.DockStyle.Fill;
            f.TopLevel = false;
            CoursesPanel.Controls.Add(f);
            f.Show();
        }


        private void frmHome_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            AddControls(new Courses());

        }
        private void btnGrades_Click(object sender, EventArgs e)
        {
            AddControls(new Grades());
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            AddControls(new Exams());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            AddControls(new Schedule());

        }
    }
}
