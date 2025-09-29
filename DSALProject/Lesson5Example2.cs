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
    public partial class Lesson5Example2 : Form
    {
        public Lesson5Example2()
        {
            InitializeComponent();
        }

        private void button_computediscount_Click(object sender, EventArgs e)
        {
            double price, computed_discount;
            const double discount = 0.20D;

            try
            {
                price = Convert.ToDouble(textbox_price.Text);
                if (price >= 2500)
                {
                    computed_discount = price * discount;
                    textbox_discount.Text = computed_discount.ToString("c");
                }
                else
                {
                    computed_discount = price * 0.12;
                    textbox_discount.Text = computed_discount.ToString("c");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input data for price is invalid.");
                textbox_price.Clear();
                textbox_price.Focus();
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textbox_discount.Clear();
            textbox_price.Clear();
            textbox_price.Focus();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_discount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
