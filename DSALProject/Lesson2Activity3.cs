using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSALProject
{
    public partial class Lesson2Activity3 : Form
    {
        public Lesson2Activity3()
        {
            InitializeComponent();

            textbox_price.Enabled = false;
            textbox_discount.Enabled = false;
        }

        private void Lesson2Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;

            radiobutton_foodbundleb.Checked = false;

            pictureBox1.Image = Properties.Resources.Food_Bundle_A;

            checkbox_A_friedchicken.Checked = true;
            checkbox_A_fries.Checked = true;
            checkbox_A_coke.Checked = true;
            checkbox_A_sidedishes.Checked = true;
            checkbox_A_pizza.Checked = true;

            checkbox_B_halohalo.Checked = false;
            checkbox_B_friedchicken.Checked = false;
            checkbox_B_carbonara.Checked = false;
            checkbox_B_fries.Checked = false;
            checkbox_B_pizza.Checked = false;

            textbox_price.Text = "₱1,000.00";
            textbox_discount.Text = "(20% of the Price) ₱200.00";
        }

        private void radiobutton_foodbundleb_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;

            radiobutton_foodbundleA.Checked = false;

            pictureBox1.Image = Properties.Resources.Food_Bundle_B;

            checkbox_A_friedchicken.Checked = false;
            checkbox_A_fries.Checked = false;
            checkbox_A_coke.Checked = false;
            checkbox_A_sidedishes.Checked = false;
            checkbox_A_pizza.Checked = false;

            checkbox_B_halohalo.Checked = true;
            checkbox_B_friedchicken.Checked = true;
            checkbox_B_carbonara.Checked = true;
            checkbox_B_fries.Checked = true;
            checkbox_B_pizza.Checked = true;

            textbox_price.Text = "₱1,299.00";
            textbox_discount.Text = "(15% of the Price) ₱194.85";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            radiobutton_foodbundleA.Checked = false;
            radiobutton_foodbundleb.Checked = false;

            pictureBox1.Image = null;

            checkbox_A_friedchicken.Checked = false;
            checkbox_A_fries.Checked = false;
            checkbox_A_coke.Checked = false;
            checkbox_A_sidedishes.Checked = false;
            checkbox_A_pizza.Checked = false;

            checkbox_B_halohalo.Checked = false;
            checkbox_B_friedchicken.Checked = false;
            checkbox_B_carbonara.Checked = false;
            checkbox_B_fries.Checked = false;
            checkbox_B_pizza.Checked = false;

            textbox_price.Clear();
            textbox_discount.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
