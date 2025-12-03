namespace DSALProject
{
    partial class PayrollReports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textbox_options = new System.Windows.Forms.TextBox();
            this.combobox_options = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 493);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(630, 15);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(96, 23);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(528, 15);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(96, 23);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textbox_options
            // 
            this.textbox_options.Location = new System.Drawing.Point(336, 17);
            this.textbox_options.Name = "textbox_options";
            this.textbox_options.Size = new System.Drawing.Size(186, 20);
            this.textbox_options.TabIndex = 8;
            // 
            // combobox_options
            // 
            this.combobox_options.FormattingEnabled = true;
            this.combobox_options.Location = new System.Drawing.Point(152, 17);
            this.combobox_options.Name = "combobox_options";
            this.combobox_options.Size = new System.Drawing.Size(178, 21);
            this.combobox_options.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select an option:";
            // 
            // PayrollReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textbox_options);
            this.Controls.Add(this.combobox_options);
            this.Controls.Add(this.label1);
            this.Name = "PayrollReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollReports";
            this.Load += new System.EventHandler(this.PayrollReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textbox_options;
        private System.Windows.Forms.ComboBox combobox_options;
        private System.Windows.Forms.Label label1;
    }
}