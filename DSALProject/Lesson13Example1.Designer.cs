namespace DSALProject
{
    partial class Lesson13Example1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_save = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.textbox_studentnumber = new System.Windows.Forms.TextBox();
            this.textbox_studentname = new System.Windows.Forms.TextBox();
            this.textbox_department = new System.Windows.Forms.TextBox();
            this.textbox_picturebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 172);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(380, 390);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(153, 43);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(569, 390);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(153, 43);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(761, 390);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(153, 43);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(761, 439);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(153, 43);
            this.button_new.TabIndex = 10;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(569, 439);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(153, 43);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(380, 439);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(153, 43);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button6_Click);
            // 
            // textbox_studentnumber
            // 
            this.textbox_studentnumber.Location = new System.Drawing.Point(484, 86);
            this.textbox_studentnumber.Name = "textbox_studentnumber";
            this.textbox_studentnumber.Size = new System.Drawing.Size(430, 20);
            this.textbox_studentnumber.TabIndex = 11;
            // 
            // textbox_studentname
            // 
            this.textbox_studentname.Location = new System.Drawing.Point(484, 128);
            this.textbox_studentname.Name = "textbox_studentname";
            this.textbox_studentname.Size = new System.Drawing.Size(430, 20);
            this.textbox_studentname.TabIndex = 12;
            // 
            // textbox_department
            // 
            this.textbox_department.Location = new System.Drawing.Point(484, 177);
            this.textbox_department.Name = "textbox_department";
            this.textbox_department.Size = new System.Drawing.Size(430, 20);
            this.textbox_department.TabIndex = 13;
            // 
            // textbox_picturebox
            // 
            this.textbox_picturebox.Location = new System.Drawing.Point(380, 12);
            this.textbox_picturebox.Name = "textbox_picturebox";
            this.textbox_picturebox.Size = new System.Drawing.Size(534, 20);
            this.textbox_picturebox.TabIndex = 14;
            // 
            // Lesson13Example1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 501);
            this.Controls.Add(this.textbox_picturebox);
            this.Controls.Add(this.textbox_department);
            this.Controls.Add(this.textbox_studentname);
            this.Controls.Add(this.textbox_studentnumber);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lesson13Example1";
            this.Text = "Lesson13Example1";
            this.Load += new System.EventHandler(this.Lesson13Example1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textbox_studentnumber;
        private System.Windows.Forms.TextBox textbox_studentname;
        private System.Windows.Forms.TextBox textbox_department;
        private System.Windows.Forms.TextBox textbox_picturebox;
    }
}