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
    public partial class POS1_Class : Form
    {
        public POS1_Class()
        {
            InitializeComponent();

            POS1_Functions.DisableTextboxes(textbox_itemname, textbox_price, textbox_discountamount, textbox_discountedamount, textbox_change, textbox_totalquantity,
                textbox_totaldiscountgiven, textbox_totaldicountedamount);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 1);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 2);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 3);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 4);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 5);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 10);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 9);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 8);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 7);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 6);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 15);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 14);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 13);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 12);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 11);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 20);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 19);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 18);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 17);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            POS1_Functions.ItemsAndPricesDisplay(textbox_itemname, textbox_price, 16);
            POS1_Functions.ClearAndFocusQuanity(textbox_quantity);
        }

        private void radiobutton_seniorcitizen_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_seniorcitizen.Checked)
            {
                POS1_Functions.ApplyDiscount("seniorcitizen", textbox_quantity, textbox_price,
                textbox_discountamount, textbox_discountedamount, radiobutton_seniorcitizen,
                radiobutton_withdisccard, radiobutton_employeedisc, radiobutton_nodiscount);
            }
        }
        private void radiobutton_withdisccard_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_withdisccard.Checked)
            {
                POS1_Functions.ApplyDiscount("withdisccard", textbox_quantity, textbox_price,
                textbox_discountamount, textbox_discountedamount, radiobutton_seniorcitizen,
                radiobutton_withdisccard, radiobutton_employeedisc, radiobutton_nodiscount);
            }
        }

        private void radiobutton_employeedisc_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_employeedisc.Checked)
            {
                POS1_Functions.ApplyDiscount("employeedisc", textbox_quantity, textbox_price,
                textbox_discountamount, textbox_discountedamount, radiobutton_seniorcitizen,
                radiobutton_withdisccard, radiobutton_employeedisc, radiobutton_nodiscount);
            }
        }

        private void radiobutton_nodiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_nodiscount.Checked)
            {
                POS1_Functions.ApplyDiscount("nodisc", textbox_quantity, textbox_price,
                textbox_discountamount, textbox_discountedamount, radiobutton_seniorcitizen,
                radiobutton_withdisccard, radiobutton_employeedisc, radiobutton_nodiscount);
            }
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            POS1_Functions.Calculate(textbox_totalquantity, textbox_totaldiscountgiven, textbox_totaldicountedamount,
                textbox_quantity, textbox_discountamount, textbox_discountedamount, textbox_cashrendered, textbox_change);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            POS1_Functions.ClearAll(textbox_itemname, textbox_price, textbox_quantity,
                textbox_discountamount, textbox_discountedamount, radiobutton_seniorcitizen, radiobutton_withdisccard,
                radiobutton_employeedisc, radiobutton_nodiscount, textbox_totalquantity, textbox_totaldiscountgiven, 
                textbox_totaldicountedamount, textbox_cashrendered, textbox_change);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            POS1_Functions.ClearAll(textbox_itemname, textbox_price, textbox_quantity,
                textbox_discountamount, textbox_discountedamount, radiobutton_seniorcitizen, radiobutton_withdisccard,
                radiobutton_employeedisc, radiobutton_nodiscount, textbox_totalquantity, textbox_totaldiscountgiven,
                textbox_totaldicountedamount, textbox_cashrendered, textbox_change);
        }

        private void POS1_Class_Load(object sender, EventArgs e)
        {

        }
    }
}
