namespace POO.View
{
    partial class frmCategoryView
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
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.Addbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Addbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Addbtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Addbtn.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.Addbtn.Location = new System.Drawing.Point(33, 36);
            this.Addbtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            // 
            // frmCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 682);
            this.Name = "frmCategoryView";
            this.Text = "frmCategoryView";
            this.Load += new System.EventHandler(this.frmCategoryView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}