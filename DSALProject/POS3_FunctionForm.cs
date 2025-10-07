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
    public partial class POS3_FunctionForm : Form
    {
        //initialization of global variables
        double qty_total = 0.00;
        double discount_total = 0;
        double discounted_total = 0.00;
        public POS3_FunctionForm()
        {
            InitializeComponent();

            DisableTextboxes();

            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void POS3_FunctionForm_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clear function for new and cancel button
        private void Clear()
        {
            textbox_itemname.Clear();
            textbox_quantity.Clear();
            textbox_price.Clear();
            textbox_discountamount.Clear();
            textbox_discountedamount.Clear();

            textbox_totalquantity.Clear();
            textbox_totaldiscountgiven.Clear();
            textbox_totaldicountedamount.Clear();

            textbox_cashrendered.Clear();
            textbox_change.Clear();

            radiobutton_seniorcitizen.Checked = false;
            radiobutton_withdisccard.Checked = false;
            radiobutton_nodiscount.Checked = false;
            radiobutton_employeedisc.Checked = false;

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DisableTextboxes() //disable textbox function
        {
            textbox_itemname.Enabled = false;
            textbox_price.Enabled = false;
            textbox_discountamount.Enabled = false;
            textbox_discountedamount.Enabled = false;
            textbox_change.Enabled = false;

            textbox_totalquantity.Enabled = false;
            textbox_totaldiscountgiven.Enabled = false;
            textbox_totaldicountedamount.Enabled = false;
        }

        private void DisplayPriceName(string itemname, string price) //function for disabling price and item name
        {
            textbox_itemname.Text = itemname;
            textbox_price.Text = price;
        }

        private void ClearQuantity() //function for clearing and focusing textbox
        {
            textbox_quantity.Clear();
            textbox_quantity.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayPriceName("1-entree Lauriat", "200.00");
            ClearQuantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayPriceName("2-entree Lauriat", "200.00");
            ClearQuantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Beef Broccoli Lauriat", "220.00");
            ClearQuantity();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Beef Broccoli", "170.00");
            ClearQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Beef Wonton", "170.00");
            ClearQuantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Buchi Dim Sum", "180.00");
            ClearQuantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Bundle Feast 1", "570.00");
            ClearQuantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Bundle Feast 2", "570.00");
            ClearQuantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Chicken Mami", "150.00");
            ClearQuantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Halo-halo Supreme", "120.00");
            ClearQuantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Honey Walnut Shrimp", "150.00");
            ClearQuantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Longanisa Breakfast", "150.00");
            ClearQuantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Lumpiang Shanghai", "200.00");
            ClearQuantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Pancit Canton", "220.00");
            ClearQuantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Salt and Pepper Pork", "170.00");
            ClearQuantity();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Siomai Chao Fan", "150.00");
            ClearQuantity();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Taho", "50.00");
            ClearQuantity();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Popcorn Chicken", "220.00");
            ClearQuantity();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Tocino Breakfastr", "150.00");
            ClearQuantity();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DisplayPriceName("Wonton Noodle Soup", "230.00");
            ClearQuantity();
        }

        private void Discount(string discount, bool isChecked) //function for every discount
        {
            try
            {
                if (!isChecked) return;

                if (discount == "seniorcitizen")
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
                else if (discount == "withdisccard")
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
                else if (discount == "employeedisc")
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
                else if (discount == "nodisc")
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
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check all the inputs.");
            }
        }

        private void radiobutton_seniorcitizen_CheckedChanged(object sender, EventArgs e)
        {
            Discount("seniorcitizen", true);
        }

        private void radiobutton_withdisccard_CheckedChanged(object sender, EventArgs e)
        {
            Discount("withdisccard", true);
        }

        private void radiobutton_employeedisc_CheckedChanged(object sender, EventArgs e)
        {
            Discount("employeedisc", true);
        }

        private void radiobutton_nodiscount_CheckedChanged(object sender, EventArgs e)
        {
            Discount("nodisc", true);
        }

        private void Calculate() //calculate function
        {
            try
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
            catch (FormatException)
            {
                MessageBox.Show("Please check all the inputs.");
            }

            
            

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
