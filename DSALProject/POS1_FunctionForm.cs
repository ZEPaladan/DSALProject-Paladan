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
    public partial class POS1_FunctionForm : Form
    {
        public POS1_FunctionForm()
        {
            InitializeComponent();

            textbox_change.Enabled = false;
            textbox_itemname.Enabled = false;
            textbox_price.Enabled = false;
            textbox_amountpaid.Enabled = false;
        }

        private void POS1_FunctionForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayItem(string itemname, string price)
        {
            textbox_itemname.Text = itemname;
            textbox_price.Text = price;
        }
        private void ClearQuantity()
        {
            textbox_quantity.Clear();
            textbox_quantity.Focus();
        }

        private void AmountPaid(TextBox quantitybox, TextBox pricebox, TextBox amountpaidbox)
        {
            try
            {
                int quantity = Convert.ToInt32(quantitybox.Text);
                double price = Convert.ToDouble(pricebox.Text);
                double amountPaid = price * quantity;

                amountpaidbox.Text = amountPaid.ToString("n");
            }
            catch (FormatException)
            {
                amountpaidbox.Clear();
            }
        }
        private void Calculate(TextBox cashGivenBox, TextBox priceBox, TextBox quantityBox,
                       TextBox amountPaidBox, TextBox changeBox)
        {
            try
            {
                double price = Convert.ToDouble(priceBox.Text);
                int quantity = Convert.ToInt32(quantityBox.Text);
                double cashGiven = Convert.ToDouble(cashGivenBox.Text);

                double totalPrice = price * quantity;
                double change = cashGiven - totalPrice;

                amountPaidBox.Text = totalPrice.ToString("n");
                changeBox.Text = change.ToString("n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for price, quantity, and cash given.");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayItem("Bacon Quarter Pounder", "450.00");
            ClearQuantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayItem("Big Mac", "260.00");
            ClearQuantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayItem("Deluxe McCrispy", "270.00");
            ClearQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayItem("Quarter Ponder", "250.00");
            ClearQuantity();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            DisplayItem("Filet-O-Fish", "200.00");
            ClearQuantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DisplayItem("Egg McMuffin", "180.00");
            ClearQuantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken McNuggets", "280.00");
            ClearQuantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DisplayItem("Baked Apple Pie", "80.00");
            ClearQuantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DisplayItem("Chocolate Chip Cookie", "50.00");
            ClearQuantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayItem("Ranch Snack Wrap", "150.00");
            ClearQuantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DisplayItem("Hot Fudge Sundae", "80.00");
            ClearQuantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DisplayItem("McCafe", "150.00");
            ClearQuantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DisplayItem("McFlurry", "120.00");
            ClearQuantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DisplayItem("Vanilla Shake", "220.00");
            ClearQuantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DisplayItem("Strawberry Shake", "220.00");
            ClearQuantity();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            Calculate(textbox_cashgiven, textbox_price, textbox_quantity, textbox_amountpaid, textbox_change);
        }

        private void Clear()
        {
            textbox_itemname.Clear();
            textbox_price.Clear();
            textbox_quantity.Clear();
            textbox_cashgiven.Clear();
            textbox_amountpaid.Clear();
            textbox_change.Clear();
            
        }
        private void button_new_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_quantity_TextChanged(object sender, EventArgs e)
        {
            AmountPaid(textbox_quantity, textbox_price, textbox_amountpaid);
        }
    }
}
