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
    public partial class Lesson3Example2 : Form
    {
        int qty_total = 0;
        double discount_total = 0, discounted_total = 0;
        public Lesson3Example2()
        {
            InitializeComponent();

            textbox_itemname.Enabled = false;
            textbox_price.Enabled = false;
            textbox_discountamount.Enabled = false;
            textbox_discountedamount.Enabled = false;
            textbox_totalquantity.Enabled = false;
            textbox_totaldiscountgiven.Enabled = false;
            textbox_totaldicountedamount.Enabled = false;
            textbox_change.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "1-entree Lauriat";
            textbox_price.Text = "200.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "2-entree Lauriat";
            textbox_price.Text = "200.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Beef Broccoli Lauriat";
            textbox_price.Text = "220.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Beef Broccoli";
            textbox_price.Text = "170.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Beef Wonton";
            textbox_price.Text = "175.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Buchi Dim Sum";
            textbox_price.Text = "180.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Bundle Feast 1";
            textbox_price.Text = "570.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Bundle Feast 2";
            textbox_price.Text = "570.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Chicken Mami";
            textbox_price.Text = "150.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Halo-halo Supreme";
            textbox_price.Text = "120.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Honey Walnut Shrimp";
            textbox_price.Text = "150.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Longanisa Breakfast";
            textbox_price.Text = "150.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Lumpiang Shanghai";
            textbox_price.Text = "200.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Pancit Canton";
            textbox_price.Text = "220.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Salt and Pepper Pork";
            textbox_price.Text = "170.00";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Siomai Chao Fan";
            textbox_price.Text = "150.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Taho";
            textbox_price.Text = "50.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Popcorn Chicken";
            textbox_price.Text = "220.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Tocino Breakfast";
            textbox_price.Text = "150.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            textbox_itemname.Text = "Wonton Noodle Soup";
            textbox_price.Text = "230.00";
        }

        private void radiobutton_seniorcitizen_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amount, discounted_amount;

            qty = Convert.ToInt32(textbox_quantity.Text);
            price = Convert.ToDouble(textbox_price.Text);

            discount_amount = (qty * price) * 0.30;
            discounted_amount = (qty * price) - discount_amount;

            textbox_discountamount.Text = discount_amount.ToString("n");
            textbox_discountedamount.Text = discounted_amount.ToString("n");

            radiobutton_withdisccard.Checked = false;
            radiobutton_employeedisc.Checked = false;
            radiobutton_nodiscount.Checked = false;
        }

        private void radiobutton_withdisccard_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amount, discounted_amount;

            qty = Convert.ToInt32(textbox_quantity.Text);
            price = Convert.ToDouble(textbox_price.Text);

            discount_amount = (qty * price) * 0.10;
            discounted_amount = (qty * price) - discount_amount;

            textbox_discountamount.Text = discount_amount.ToString("n");
            textbox_discountedamount.Text = discounted_amount.ToString("n");

            radiobutton_seniorcitizen.Checked = false;
            radiobutton_employeedisc.Checked = false;
            radiobutton_nodiscount.Checked = false;
        }

        private void radiobutton_employeedisc_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amount, discounted_amount;

            qty = Convert.ToInt32(textbox_quantity.Text);
            price = Convert.ToDouble(textbox_price.Text);

            discount_amount = (qty * price) * 0.15;
            discounted_amount = (qty * price) - discount_amount;

            textbox_discountamount.Text = discount_amount.ToString("n");
            textbox_discountedamount.Text = discounted_amount.ToString("n");

            radiobutton_seniorcitizen.Checked = false;
            radiobutton_withdisccard.Checked = false;
            radiobutton_nodiscount.Checked = false;
        }

        private void radiobutton_nodiscount_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amount, discounted_amount;

            qty = Convert.ToInt32(textbox_quantity.Text);
            price = Convert.ToDouble(textbox_price.Text);

            discount_amount = (qty * price) * 0;
            discounted_amount = (qty * price) - discount_amount;

            textbox_discountamount.Text = discount_amount.ToString("n");
            textbox_discountedamount.Text = discounted_amount.ToString("n");

            radiobutton_seniorcitizen.Checked = false;
            radiobutton_withdisccard.Checked = false;
            radiobutton_employeedisc.Checked = false;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amount, discounted_amount, cash_rendered, change;

            qty = Convert.ToInt32(textbox_quantity.Text);
            discount_amount = Convert.ToDouble(textbox_discountamount.Text);
            discounted_amount = Convert.ToDouble(textbox_discountedamount.Text);
            cash_rendered = Convert.ToDouble(textbox_cashrendered.Text);

            qty_total += qty;
            discount_total += discount_amount;
            discounted_total += discounted_amount;
            change = cash_rendered - discounted_amount;

            textbox_totalquantity.Text = qty_total.ToString();
            textbox_totaldiscountgiven.Text = discount_total.ToString("n");
            textbox_totaldicountedamount.Text = discounted_total.ToString("n");
            textbox_change.Text = change.ToString("n");

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textbox_itemname.Clear();
            textbox_price.Clear();
            textbox_discountamount.Clear();
            textbox_discountedamount.Clear();
            textbox_change.Clear();
            textbox_cashrendered.Clear();
            textbox_quantity.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
