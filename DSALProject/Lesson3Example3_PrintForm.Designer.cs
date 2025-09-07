namespace DSALProject
{
    partial class Lesson3Example3_PrintForm
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
            this.listbox_printdisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox_printdisplay
            // 
            this.listbox_printdisplay.FormattingEnabled = true;
            this.listbox_printdisplay.Location = new System.Drawing.Point(12, 40);
            this.listbox_printdisplay.Name = "listbox_printdisplay";
            this.listbox_printdisplay.Size = new System.Drawing.Size(347, 394);
            this.listbox_printdisplay.TabIndex = 0;
            this.listbox_printdisplay.SelectedIndexChanged += new System.EventHandler(this.listbox_printdisplay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIZZA HURT ORDERING APPLICATION";
            // 
            // Lesson3Example3_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_printdisplay);
            this.Name = "Lesson3Example3_PrintForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listbox_printdisplay;
    }
}