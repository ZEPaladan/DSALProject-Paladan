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
    public partial class Lesson2Activity1 : Form
    {
        public Lesson2Activity1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Bacon Quarter Pounder";
            textbox_price.Text = "450.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Big Mac";
            textbox_price.Text = "260.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Deluxe McCrispy";
            textbox_price.Text = "270.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Quarter Ponder";
            textbox_price.Text = "250.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Filet-O-Fish";
            textbox_price.Text = "200.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Egg McMuffin";
            textbox_price.Text = "180.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Chicken McNuggets";
            textbox_price.Text = "280.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Baked Apple Pie";
            textbox_price.Text = "80.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Chocolate Chip Cookie";
            textbox_price.Text = "50.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Ranch Snack Wrap";
            textbox_price.Text = "150.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Hot Fudge Sundae";
            textbox_price.Text = "80.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "McCafe";
            textbox_price.Text = "150.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "McFlurry";
            textbox_price.Text = "120.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Vanilla Shake";
            textbox_price.Text = "220.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Strawberry Shake";
            textbox_price.Text = "220.00";
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textbox_itemname.Clear();
            textbox_price.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lesson2Activity1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
