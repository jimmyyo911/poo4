namespace POO
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCourses = new Guna.UI2.WinForms.Guna2Button();
            this.btnExams = new Guna.UI2.WinForms.Guna2Button();
            this.btnGrades = new Guna.UI2.WinForms.Guna2Button();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.CoursesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.btnSchedule);
            this.HomePanel.Controls.Add(this.btnGrades);
            this.HomePanel.Controls.Add(this.btnExams);
            this.HomePanel.Controls.Add(this.btnCourses);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(150, 450);
            this.HomePanel.TabIndex = 1;
            // 
            // btnCourses
            // 
            this.btnCourses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCourses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCourses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(12, 93);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(126, 46);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnExams
            // 
            this.btnExams.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExams.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExams.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExams.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExams.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExams.ForeColor = System.Drawing.Color.White;
            this.btnExams.Location = new System.Drawing.Point(12, 202);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(126, 46);
            this.btnExams.TabIndex = 3;
            this.btnExams.Text = "Exams";
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGrades.ForeColor = System.Drawing.Color.White;
            this.btnGrades.Location = new System.Drawing.Point(12, 150);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(126, 46);
            this.btnGrades.TabIndex = 4;
            this.btnGrades.Text = "Grades";
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(12, 254);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(126, 46);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // CoursesPanel
            // 
            this.CoursesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoursesPanel.Location = new System.Drawing.Point(150, 0);
            this.CoursesPanel.Name = "CoursesPanel";
            this.CoursesPanel.Size = new System.Drawing.Size(650, 450);
            this.CoursesPanel.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoursesPanel);
            this.Controls.Add(this.HomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.HomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel HomePanel;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Button btnGrades;
        private Guna.UI2.WinForms.Guna2Button btnExams;
        private Guna.UI2.WinForms.Guna2Button btnCourses;
        private Guna.UI2.WinForms.Guna2Panel CoursesPanel;
    }
}