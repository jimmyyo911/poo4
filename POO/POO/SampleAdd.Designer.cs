namespace POO
{
    partial class SampleAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleAdd));
            this.Addbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Header = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Addbtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.Addbtn.ImageRotate = 0F;
            this.Addbtn.Location = new System.Drawing.Point(24, 36);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Addbtn.Size = new System.Drawing.Size(74, 65);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(2, 96);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(786, 19);
            this.guna2Separator1.TabIndex = 1;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(28, 8);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(82, 25);
            this.Header.TabIndex = 2;
            this.Header.Text = "Header";
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(488, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(261, 54);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // SampleAdd
            // 
            this.AccessibleName = "s";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.Addbtn);
            this.Name = "SampleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleAdd";
            this.Load += new System.EventHandler(this.SampleAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ImageButton Addbtn;
        public System.Windows.Forms.Label Header;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}