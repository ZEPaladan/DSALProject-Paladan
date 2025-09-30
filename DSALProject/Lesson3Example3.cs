using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSALProject
{
    public partial class Lesson3Example3 : Form
    {

        private double total_amount = 0;
        private int total_qty = 0;
        public Lesson3Example3()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

        }

        private void Lesson3Example3_Load(object sender, EventArgs e)
        {
            textbox_price.Enabled = false;
            textbox_discountedamount.Enabled = false;
            textbox_change.Enabled = false;
            textbox_totalbills.Enabled = false;
            textbox_discountamount.Enabled = false;
            textbox_totalquantity.Enabled = false;

            checkbox_A_chicken.Checked = false;
            checkbox_A_fries.Checked = false;
            checkbox_A_coke.Checked = false;
            checkbox_A_sidedishes.Checked = false;
            checkbox_A_pizza.Checked = false;

            checkbox_B_halohalo.Checked = false;
            checkbox_B_chicken.Checked = false;
            checkbox_B_carbonara.Checked = false;
            checkbox_B_fries.Checked = false;
            checkbox_B_pizza.Checked = false;
        }

        private void radiobutton_foodbundleA_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_foodbundleA.Checked)
            {
                double price;

                this.BackColor = Color.LightCyan;



                picturebox_orderimage.Image = Properties.Resources.Food_Bundle_A;

                checkbox_A_chicken.Checked = true;
                checkbox_A_fries.Checked = true;
                checkbox_A_coke.Checked = true;
                checkbox_A_sidedishes.Checked = true;
                checkbox_A_pizza.Checked = true;

                checkbox_B_halohalo.Checked = false;
                checkbox_B_chicken.Checked = false;
                checkbox_B_carbonara.Checked = false;
                checkbox_B_fries.Checked = false;
                checkbox_B_pizza.Checked = false;

                textbox_price.Text = "1,000.00";
                textbox_discountamount.Text = "200.00";
                price = Convert.ToDouble(textbox_price.Text);
                listbox_display.Items.Add(radiobutton_foodbundleA.Text + "          " + textbox_price.Text);
                listbox_display.Items.Add("          Discount Amount: " + "         " + textbox_discountamount.Text);
                textbox_quantity.Text = "0";
                textbox_quantity.Focus();
            }
            

        }

        private void radiobutton_foodbundleB_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_foodbundleB.Checked)
            {
                double price;

                this.BackColor = Color.LightBlue;



                picturebox_orderimage.Image = Properties.Resources.Food_Bundle_B;

                checkbox_A_chicken.Checked = false;
                checkbox_A_fries.Checked = false;
                checkbox_A_coke.Checked = false;
                checkbox_A_sidedishes.Checked = false;
                checkbox_A_pizza.Checked = false;

                checkbox_B_halohalo.Checked = true;
                checkbox_B_chicken.Checked = true;
                checkbox_B_carbonara.Checked = true;
                checkbox_B_fries.Checked = true;
                checkbox_B_pizza.Checked = true;

                textbox_price.Text = "1,299.00";
                textbox_discountamount.Text = "194.85";
                price = Convert.ToDouble(textbox_price.Text);

                listbox_display.Items.Add(radiobutton_foodbundleB.Text + "          " + textbox_price.Text);
                listbox_display.Items.Add("          Discount Amount: " + "         " + textbox_discountamount.Text);
                textbox_quantity.Text = "0";
                textbox_quantity.Focus();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(textbox_cashgiven.Text);
            total_amountPaid = Convert.ToDouble(textbox_totalbills.Text);
            change = cash_given - total_amountPaid;

            textbox_change.Text = change.ToString("n");
            listbox_display.Items.Add("Total Bills: " + "          " + textbox_totalbills.Text);
            listbox_display.Items.Add("Cash Given: " + "          " + textbox_cashgiven.Text);
            listbox_display.Items.Add("Change: " + "          " + textbox_change.Text);
            listbox_display.Items.Add("Total No. of Items: " + "          " + textbox_totalquantity.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lesson3Example3_PrintForm print = new Lesson3Example3_PrintForm();

            print.listbox_printdisplay.Items.AddRange(this.listbox_display.Items);
            print.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listbox_display.Items.RemoveAt(listbox_display.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            radiobutton_foodbundleA.Checked = false;
            radiobutton_foodbundleB.Checked = false;

            picturebox_orderimage.Image = Properties.Resources.default_image;

            checkbox_A_chicken.Checked = false;
            checkbox_A_fries.Checked = false;
            checkbox_A_coke.Checked = false;
            checkbox_A_sidedishes.Checked = false;
            checkbox_A_pizza.Checked = false;

            checkbox_B_halohalo.Checked = false;
            checkbox_B_chicken.Checked = false;
            checkbox_B_carbonara.Checked = false;
            checkbox_B_fries.Checked = false;
            checkbox_B_pizza.Checked = false;

            textbox_price.Clear();
            textbox_quantity.Clear();

            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;

            listbox_display.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_quantity_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            int qty;
            price = Convert.ToDouble(textbox_price.Text);
            qty = Convert.ToInt32(textbox_quantity.Text);
            discount_amount = Convert.ToDouble(textbox_discountamount.Text);
            discounted_amount = (price - discount_amount) * qty;
            total_qty += qty;
            textbox_totalquantity.Text = total_qty.ToString();
            total_amount += discounted_amount;
            textbox_totalbills.Text = total_amount.ToString("n");
            textbox_discountedamount.Text = discounted_amount.ToString("n");
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "280.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox11.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "320.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox12.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "350.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox13.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "380.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox14.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "420.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox15.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "330.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox20.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "400.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox19.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "450.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox18.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "390.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox17.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "480.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox16.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "370.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox30.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "500.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox29.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "360.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox28.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "380.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox27.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "340.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox26.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "360.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox25.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "450.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox24.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "400.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox23.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "300.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox22.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            textbox_discountamount.Text = "0.00";
            textbox_price.Text = "520.00";
            price = Convert.ToDouble(textbox_price.Text);
            listbox_display.Items.Add(checkBox21.Text + "          " + textbox_price.Text);
            textbox_quantity.Text = "0";
            textbox_quantity.Focus();
        }
    }
}
