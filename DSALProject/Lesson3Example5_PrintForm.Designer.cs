namespace DSALProject
{
    partial class Lesson3Example5_PrintForm
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
            this.listbox_payslipview = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listbox_payslipview
            // 
            this.listbox_payslipview.FormattingEnabled = true;
            this.listbox_payslipview.Location = new System.Drawing.Point(12, 12);
            this.listbox_payslipview.Name = "listbox_payslipview";
            this.listbox_payslipview.Size = new System.Drawing.Size(325, 498);
            this.listbox_payslipview.TabIndex = 0;
            // 
            // Lesson3Example5_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 515);
            this.Controls.Add(this.listbox_payslipview);
            this.Name = "Lesson3Example5_PrintForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lesson3Example5_PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listbox_payslipview;
    }
}