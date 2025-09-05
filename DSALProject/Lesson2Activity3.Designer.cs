namespace DSALProject
{
    partial class Lesson2Activity3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobutton_foodbundleA = new System.Windows.Forms.RadioButton();
            this.radiobutton_foodbundleb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_discount = new System.Windows.Forms.TextBox();
            this.textbox_price = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkbox_A_friedchicken = new System.Windows.Forms.CheckBox();
            this.checkbox_A_fries = new System.Windows.Forms.CheckBox();
            this.checkbox_A_sidedishes = new System.Windows.Forms.CheckBox();
            this.checkbox_A_coke = new System.Windows.Forms.CheckBox();
            this.checkbox_A_pizza = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkbox_B_pizza = new System.Windows.Forms.CheckBox();
            this.checkbox_B_fries = new System.Windows.Forms.CheckBox();
            this.checkbox_B_carbonara = new System.Windows.Forms.CheckBox();
            this.checkbox_B_friedchicken = new System.Windows.Forms.CheckBox();
            this.checkbox_B_halohalo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobutton_foodbundleb);
            this.groupBox1.Controls.Add(this.radiobutton_foodbundleA);
            this.groupBox1.Location = new System.Drawing.Point(18, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Order Choices";
            // 
            // radiobutton_foodbundleA
            // 
            this.radiobutton_foodbundleA.AutoSize = true;
            this.radiobutton_foodbundleA.Location = new System.Drawing.Point(39, 29);
            this.radiobutton_foodbundleA.Name = "radiobutton_foodbundleA";
            this.radiobutton_foodbundleA.Size = new System.Drawing.Size(95, 17);
            this.radiobutton_foodbundleA.TabIndex = 0;
            this.radiobutton_foodbundleA.TabStop = true;
            this.radiobutton_foodbundleA.Text = "Food Bundle A";
            this.radiobutton_foodbundleA.UseVisualStyleBackColor = true;
            this.radiobutton_foodbundleA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiobutton_foodbundleb
            // 
            this.radiobutton_foodbundleb.AutoSize = true;
            this.radiobutton_foodbundleb.Location = new System.Drawing.Point(39, 61);
            this.radiobutton_foodbundleb.Name = "radiobutton_foodbundleb";
            this.radiobutton_foodbundleb.Size = new System.Drawing.Size(95, 17);
            this.radiobutton_foodbundleb.TabIndex = 1;
            this.radiobutton_foodbundleb.TabStop = true;
            this.radiobutton_foodbundleb.Text = "Food Bundle B";
            this.radiobutton_foodbundleb.UseVisualStyleBackColor = true;
            this.radiobutton_foodbundleb.CheckedChanged += new System.EventHandler(this.radiobutton_foodbundleb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textbox_price);
            this.groupBox2.Controls.Add(this.textbox_discount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Order Choices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount:";
            // 
            // textbox_discount
            // 
            this.textbox_discount.Location = new System.Drawing.Point(95, 63);
            this.textbox_discount.Name = "textbox_discount";
            this.textbox_discount.Size = new System.Drawing.Size(189, 20);
            this.textbox_discount.TabIndex = 4;
            // 
            // textbox_price
            // 
            this.textbox_price.Location = new System.Drawing.Point(95, 25);
            this.textbox_price.Name = "textbox_price";
            this.textbox_price.Size = new System.Drawing.Size(189, 20);
            this.textbox_price.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Image:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkbox_A_pizza);
            this.groupBox3.Controls.Add(this.checkbox_A_sidedishes);
            this.groupBox3.Controls.Add(this.checkbox_A_coke);
            this.groupBox3.Controls.Add(this.checkbox_A_fries);
            this.groupBox3.Controls.Add(this.checkbox_A_friedchicken);
            this.groupBox3.Location = new System.Drawing.Point(314, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food Bundle A";
            // 
            // checkbox_A_friedchicken
            // 
            this.checkbox_A_friedchicken.AutoSize = true;
            this.checkbox_A_friedchicken.Location = new System.Drawing.Point(47, 29);
            this.checkbox_A_friedchicken.Name = "checkbox_A_friedchicken";
            this.checkbox_A_friedchicken.Size = new System.Drawing.Size(175, 17);
            this.checkbox_A_friedchicken.TabIndex = 0;
            this.checkbox_A_friedchicken.Text = "10 pcs. Delicious Fried Chicken";
            this.checkbox_A_friedchicken.UseVisualStyleBackColor = true;
            // 
            // checkbox_A_fries
            // 
            this.checkbox_A_fries.AutoSize = true;
            this.checkbox_A_fries.Location = new System.Drawing.Point(47, 61);
            this.checkbox_A_fries.Name = "checkbox_A_fries";
            this.checkbox_A_fries.Size = new System.Drawing.Size(87, 17);
            this.checkbox_A_fries.TabIndex = 1;
            this.checkbox_A_fries.Text = "2 Large Fries";
            this.checkbox_A_fries.UseVisualStyleBackColor = true;
            // 
            // checkbox_A_sidedishes
            // 
            this.checkbox_A_sidedishes.AutoSize = true;
            this.checkbox_A_sidedishes.Location = new System.Drawing.Point(47, 127);
            this.checkbox_A_sidedishes.Name = "checkbox_A_sidedishes";
            this.checkbox_A_sidedishes.Size = new System.Drawing.Size(91, 17);
            this.checkbox_A_sidedishes.TabIndex = 3;
            this.checkbox_A_sidedishes.Text = "4 Side Dishes";
            this.checkbox_A_sidedishes.UseVisualStyleBackColor = true;
            // 
            // checkbox_A_coke
            // 
            this.checkbox_A_coke.AutoSize = true;
            this.checkbox_A_coke.Location = new System.Drawing.Point(47, 95);
            this.checkbox_A_coke.Name = "checkbox_A_coke";
            this.checkbox_A_coke.Size = new System.Drawing.Size(69, 17);
            this.checkbox_A_coke.TabIndex = 2;
            this.checkbox_A_coke.Text = "1.5 Coke";
            this.checkbox_A_coke.UseVisualStyleBackColor = true;
            // 
            // checkbox_A_pizza
            // 
            this.checkbox_A_pizza.AutoSize = true;
            this.checkbox_A_pizza.Location = new System.Drawing.Point(47, 159);
            this.checkbox_A_pizza.Name = "checkbox_A_pizza";
            this.checkbox_A_pizza.Size = new System.Drawing.Size(130, 17);
            this.checkbox_A_pizza.TabIndex = 4;
            this.checkbox_A_pizza.Text = "Special Pizza Delights";
            this.checkbox_A_pizza.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkbox_B_pizza);
            this.groupBox4.Controls.Add(this.checkbox_B_fries);
            this.groupBox4.Controls.Add(this.checkbox_B_carbonara);
            this.groupBox4.Controls.Add(this.checkbox_B_friedchicken);
            this.groupBox4.Controls.Add(this.checkbox_B_halohalo);
            this.groupBox4.Location = new System.Drawing.Point(314, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 214);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Food Bundle B";
            // 
            // checkbox_B_pizza
            // 
            this.checkbox_B_pizza.AutoSize = true;
            this.checkbox_B_pizza.Location = new System.Drawing.Point(47, 159);
            this.checkbox_B_pizza.Name = "checkbox_B_pizza";
            this.checkbox_B_pizza.Size = new System.Drawing.Size(147, 17);
            this.checkbox_B_pizza.TabIndex = 4;
            this.checkbox_B_pizza.Text = "1 Medium Hawaiian Pizza";
            this.checkbox_B_pizza.UseVisualStyleBackColor = true;
            // 
            // checkbox_B_fries
            // 
            this.checkbox_B_fries.AutoSize = true;
            this.checkbox_B_fries.Location = new System.Drawing.Point(47, 127);
            this.checkbox_B_fries.Name = "checkbox_B_fries";
            this.checkbox_B_fries.Size = new System.Drawing.Size(115, 17);
            this.checkbox_B_fries.TabIndex = 3;
            this.checkbox_B_fries.Text = "1 Famiy Pack Fries";
            this.checkbox_B_fries.UseVisualStyleBackColor = true;
            // 
            // checkbox_B_carbonara
            // 
            this.checkbox_B_carbonara.AutoSize = true;
            this.checkbox_B_carbonara.Location = new System.Drawing.Point(47, 95);
            this.checkbox_B_carbonara.Name = "checkbox_B_carbonara";
            this.checkbox_B_carbonara.Size = new System.Drawing.Size(144, 17);
            this.checkbox_B_carbonara.TabIndex = 2;
            this.checkbox_B_carbonara.Text = "1 Family Pack Carbonara";
            this.checkbox_B_carbonara.UseVisualStyleBackColor = true;
            // 
            // checkbox_B_friedchicken
            // 
            this.checkbox_B_friedchicken.AutoSize = true;
            this.checkbox_B_friedchicken.Location = new System.Drawing.Point(47, 61);
            this.checkbox_B_friedchicken.Name = "checkbox_B_friedchicken";
            this.checkbox_B_friedchicken.Size = new System.Drawing.Size(169, 17);
            this.checkbox_B_friedchicken.TabIndex = 1;
            this.checkbox_B_friedchicken.Text = "6 pcs. Delicious Fried Chicken";
            this.checkbox_B_friedchicken.UseVisualStyleBackColor = true;
            // 
            // checkbox_B_halohalo
            // 
            this.checkbox_B_halohalo.AutoSize = true;
            this.checkbox_B_halohalo.Location = new System.Drawing.Point(47, 29);
            this.checkbox_B_halohalo.Name = "checkbox_B_halohalo";
            this.checkbox_B_halohalo.Size = new System.Drawing.Size(186, 17);
            this.checkbox_B_halohalo.TabIndex = 0;
            this.checkbox_B_halohalo.Text = "4 cups Special Halo-Halo Regular";
            this.checkbox_B_halohalo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "McDon\'t Food Ordering Application";
            // 
            // Lesson2Activity3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Lesson2Activity3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lesson2Activity3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_foodbundleb;
        private System.Windows.Forms.RadioButton radiobutton_foodbundleA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textbox_price;
        private System.Windows.Forms.TextBox textbox_discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkbox_A_pizza;
        private System.Windows.Forms.CheckBox checkbox_A_sidedishes;
        private System.Windows.Forms.CheckBox checkbox_A_coke;
        private System.Windows.Forms.CheckBox checkbox_A_fries;
        private System.Windows.Forms.CheckBox checkbox_A_friedchicken;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkbox_B_pizza;
        private System.Windows.Forms.CheckBox checkbox_B_fries;
        private System.Windows.Forms.CheckBox checkbox_B_carbonara;
        private System.Windows.Forms.CheckBox checkbox_B_friedchicken;
        private System.Windows.Forms.CheckBox checkbox_B_halohalo;
        private System.Windows.Forms.Label label5;
    }
}