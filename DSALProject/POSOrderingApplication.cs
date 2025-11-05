using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DSALProject
{
    public partial class POSOrderingApplication : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Variables1 vars = new Variables1();
        Price_Item_Value price_item_value = new Price_Item_Value();
        private Image pic;

        public POSOrderingApplication()
        {
            InitializeComponent();
            posdb_connect = new pos_dbconnection(); // fixed: use class-level instance
        }

        private void POSOrderingApplication_Load(object sender, EventArgs e)
        {
            textbox_price.Enabled = false;
            textbox_discountedamount.Enabled = false;
            textbox_change.Enabled = false;
            textbox_discountamount.Enabled = false;
            textbox_totalquantity.Enabled = false;
            textbox_itemname.Enabled = false;
            textbox_totaldiscountgiven.Enabled = false;
            textbox_totaldicountedamount.Enabled = false;


            //pic = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\blank_image.jpg");
            pic = Image.FromFile("C:\\Users\\NewPC\\source\\repos\\DSALProject\\DSALProject\\Resources\\blank_image.jpg");

            pictureBox1.Image = pic;
            pictureBox2.Image = pic;
            pictureBox3.Image = pic;
            pictureBox4.Image = pic;
            pictureBox5.Image = pic;
            pictureBox6.Image = pic;
            pictureBox7.Image = pic;
            pictureBox8.Image = pic;
            pictureBox9.Image = pic;
            pictureBox10.Image = pic;
            pictureBox11.Image = pic;
            pictureBox12.Image = pic;
            pictureBox13.Image = pic;
            pictureBox14.Image = pic;
            pictureBox15.Image = pic;
            pictureBox16.Image = pic;
            pictureBox17.Image = pic;
            pictureBox18.Image = pic;
            pictureBox19.Image = pic;
            pictureBox20.Image = pic;


            textbox_picpath1.Hide();
            textbox_picpath2.Hide();
            textbox_picpath3.Hide();
            textbox_picpath4.Hide();
            textbox_picpath5.Hide();
            textbox_picpath6.Hide();
            textbox_picpath7.Hide();
            textbox_picpath8.Hide();
            textbox_picpath9.Hide();
            textbox_picpath10.Hide();
            textbox_picpath11.Hide();
            textbox_picpath12.Hide();
            textbox_picpath13.Hide();
            textbox_picpath14.Hide();
            textbox_picpath15.Hide();
            textbox_picpath16.Hide();
            textbox_picpath17.Hide();
            textbox_picpath18.Hide();
            textbox_picpath19.Hide();
            textbox_picpath20.Hide();

            posdb_connect.pos_select_cashieri();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            combobox_posidno.Items.Add("1");
            combobox_posidno.Items.Add("2");
            combobox_posidno.Items.Add("3");
        }
        private void quantity_function()
        {
            textbox_quantity.Clear();
            textbox_quantity.Focus();
        }

        private void quantity_price_convert()
        {
            vars.quantity = Convert.ToInt32(textbox_quantity.Text);
            vars.price = Convert.ToDouble(textbox_price.Text);
        }

        private void computation_formula_and_displaydata()
        {
            vars.discounted_amt = (vars.quantity * vars.price) - vars.discount_amt;
            textbox_discountamount.Text = vars.discount_amt.ToString("F2");
            textbox_discountedamount.Text = vars.discounted_amt.ToString("F2");
        }
        public void GetPriceItemValue()
        {
            textbox_itemname.Text = price_item_value.GetItemName();
            textbox_price.Text = price_item_value.GetPrice();

        }

        private void clear_textboxes()
        {
            textbox_itemname.Clear();
            textbox_price.Clear();
            textbox_quantity.Clear();
            textbox_discountamount.Clear();
            textbox_discountedamount.Clear();
            textbox_cashrendered.Clear();
            textbox_change.Clear();
        }

        private void textbox_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Reserved for future use
        }

        private void GetPriceDicountAmount()
        {

        }

        private void combobox_posidno_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reserved for future use
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl " +
                                    "INNER JOIN pos_pictbl ON pos_nameTbl.pos_id = pos_pictbl.pos_id " +
                                    "INNER JOIN pos_priceTbl ON pos_pictbl.pos_id = pos_priceTbl.pos_id " +
                                    "WHERE pos_nameTbl.pos_id = '" + combobox_posidno.Text + "';";

            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            if (posdb_connect.pos_sql_dataset.Tables.Count > 0 &&
                posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
            {
                DataTable dt = posdb_connect.pos_sql_dataset.Tables[0];
                DataRow row = dt.Rows[0];

                // --- Retrieve checkbox text values ---
                label1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name1"].ToString();
                label2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name2"].ToString();
                label3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name3"].ToString();
                label4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name4"].ToString();
                label5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name5"].ToString();
                label6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name6"].ToString();
                label7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name7"].ToString();
                label8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name8"].ToString();
                label9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name9"].ToString();
                label10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name10"].ToString();
                label11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name11"].ToString();
                label12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name12"].ToString();
                label13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name13"].ToString();
                label14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name14"].ToString();
                label15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name15"].ToString();
                label16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name16"].ToString();
                label17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name17"].ToString();
                label18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name18"].ToString();
                label19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name19"].ToString();
                label20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name20"].ToString();

                label33.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price1"].ToString();
                label34.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price2"].ToString();
                label35.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price3"].ToString();
                label36.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price4"].ToString();
                label37.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price5"].ToString();
                label38.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price6"].ToString();
                label39.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price7"].ToString();
                label40.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price8"].ToString();
                label41.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price9"].ToString();
                label42.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price10"].ToString();
                label43.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price11"].ToString();
                label44.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price12"].ToString();
                label45.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price13"].ToString();
                label46.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price14"].ToString();
                label47.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price15"].ToString();
                label48.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price16"].ToString();
                label49.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price17"].ToString();
                label50.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price18"].ToString();
                label51.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price19"].ToString();
                label52.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price20"].ToString();




                // --- Retrieve and display picture paths ---
                textbox_picpath1.Text = row["pic1"].ToString();
                pictureBox1.Image = Image.FromFile(textbox_picpath1.Text);

                textbox_picpath2.Text = row["pic2"].ToString();
                pictureBox2.Image = Image.FromFile(textbox_picpath2.Text);

                textbox_picpath3.Text = row["pic3"].ToString();
                pictureBox3.Image = Image.FromFile(textbox_picpath3.Text);

                textbox_picpath4.Text = row["pic4"].ToString();
                pictureBox4.Image = Image.FromFile(textbox_picpath4.Text);

                textbox_picpath5.Text = row["pic5"].ToString();
                pictureBox5.Image = Image.FromFile(textbox_picpath5.Text);

                textbox_picpath6.Text = row["pic6"].ToString();
                pictureBox6.Image = Image.FromFile(textbox_picpath6.Text);

                textbox_picpath7.Text = row["pic7"].ToString();
                pictureBox7.Image = Image.FromFile(textbox_picpath7.Text);

                textbox_picpath8.Text = row["pic8"].ToString();
                pictureBox8.Image = Image.FromFile(textbox_picpath8.Text);

                textbox_picpath9.Text = row["pic9"].ToString();
                pictureBox9.Image = Image.FromFile(textbox_picpath9.Text);

                textbox_picpath10.Text = row["pic10"].ToString();
                pictureBox10.Image = Image.FromFile(textbox_picpath10.Text);

                textbox_picpath11.Text = row["pic11"].ToString();
                pictureBox11.Image = Image.FromFile(textbox_picpath11.Text);

                textbox_picpath12.Text = row["pic12"].ToString();
                pictureBox12.Image = Image.FromFile(textbox_picpath12.Text);

                textbox_picpath13.Text = row["pic13"].ToString();
                pictureBox13.Image = Image.FromFile(textbox_picpath13.Text);

                textbox_picpath14.Text = row["pic14"].ToString();
                pictureBox14.Image = Image.FromFile(textbox_picpath14.Text);

                textbox_picpath15.Text = row["pic15"].ToString();
                pictureBox15.Image = Image.FromFile(textbox_picpath15.Text);

                textbox_picpath16.Text = row["pic16"].ToString();
                pictureBox16.Image = Image.FromFile(textbox_picpath16.Text);

                textbox_picpath17.Text = row["pic17"].ToString();
                pictureBox17.Image = Image.FromFile(textbox_picpath17.Text);

                textbox_picpath18.Text = row["pic18"].ToString();
                pictureBox18.Image = Image.FromFile(textbox_picpath18.Text);

                textbox_picpath19.Text = row["pic19"].ToString();
                pictureBox19.Image = Image.FromFile(textbox_picpath19.Text);

                textbox_picpath20.Text = row["pic20"].ToString();
                pictureBox20.Image = Image.FromFile(textbox_picpath20.Text);
            }
            else
            {
                MessageBox.Show("No data found for the selected POS ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radiobutton_seniorcitizen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                vars.discount_amt = (vars.quantity * vars.price) * 0.30;
                computation_formula_and_displaydata();
                radiobutton_withdisccard.Checked = false;
                radiobutton_employeedisc.Checked = false;
                radiobutton_nodiscount.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radiobutton_withdisccard_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                vars.discount_amt = (vars.quantity * vars.price) * 0.20;
                computation_formula_and_displaydata();
                radiobutton_seniorcitizen.Checked = false;
                radiobutton_employeedisc.Checked = false;
                radiobutton_nodiscount.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radiobutton_employeedisc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                vars.discount_amt = (vars.quantity * vars.price) * 0.10;
                computation_formula_and_displaydata();
                radiobutton_seniorcitizen.Checked = false;
                radiobutton_withdisccard.Checked = false;
                radiobutton_nodiscount.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radiobutton_nodiscount_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                vars.discount_amt = 0;
                computation_formula_and_displaydata();
                radiobutton_seniorcitizen.Checked = false;
                radiobutton_withdisccard.Checked = false;
                radiobutton_employeedisc.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(textbox_price.Text);
                vars.quantity = Convert.ToInt32(textbox_quantity.Text);
                vars.discount_amt = Convert.ToDouble(textbox_discountamount.Text);
                vars.cash_given = Convert.ToDouble(textbox_cashrendered.Text);


                vars.discounted_amt = (vars.quantity * price) - vars.discount_amt;
                vars.change = vars.cash_given - vars.discounted_amt;
                vars.qty_total += vars.quantity;
                vars.discount_total_given += vars.discount_amt;
                vars.discounted_total += vars.discounted_amt;

                // Display
                textbox_totalquantity.Text = vars.qty_total.ToString("F2");
                textbox_totaldiscountgiven.Text = vars.discount_total_given.ToString("F2");
                textbox_totaldicountedamount.Text = vars.discounted_total.ToString("F2");
                textbox_change.Text = vars.change.ToString("F2");
                textbox_cashrendered.Text = vars.cash_given.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label1.Text, label33.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label2.Text, label34.Text);
            GetPriceItemValue();
            quantity_function();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label4.Text, label36.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label3.Text, label35.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label5.Text, label37.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label10.Text, label42.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label9.Text, label41.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label8.Text, label40.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label7.Text, label39.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label6.Text, label38.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label15.Text, label47.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label14.Text, label46.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label13.Text, label45.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label12.Text, label44.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label11.Text, label43.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label20.Text, label52.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label19.Text, label51.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label18.Text, label50.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label17.Text, label49.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(label16.Text, label48.Text);
            GetPriceItemValue();
            quantity_function();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            clear_textboxes();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            clear_textboxes();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (radiobutton_seniorcitizen.Checked == true)
                {
                    posdb_connect.pos_sql =
                        "INSERT INTO salesTbl (" +
                        "product_name, product_quantity_per_transaction, product_price, discount_option, " +
                        "discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, " +
                        "summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                        "VALUES ('" + textbox_itemname.Text + "', '" +
                        textbox_quantity.Text + "', '" +
                        textbox_price.Text + "', '" +
                        radiobutton_seniorcitizen.Text + "', '" +
                        textbox_discountamount.Text + "', '" +
                        textbox_discountedamount.Text + "', '" +
                        textbox_totalquantity.Text + "', '" +
                        textbox_totaldiscountgiven.Text + "', '" +
                        textbox_totaldicountedamount.Text + "', '" +
                        textbox_pcterminalno.Text + "', '" +
                        dateTimePicker1.Text + "', '" +
                        textbox_employeeid.Text + "')";

                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    clear_textboxes();

                }
                else if (radiobutton_withdisccard.Checked == true)
                {
                    posdb_connect.pos_sql =
                        "INSERT INTO salesTbl (" +
                        "product_name, product_quantity_per_transaction, product_price, discount_option, " +
                        "discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, " +
                        "summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                        "VALUES ('" + textbox_itemname.Text + "', '" +
                        textbox_quantity.Text + "', '" +
                        textbox_price.Text + "', '" +
                        radiobutton_withdisccard.Text + "', '" +
                        textbox_discountamount.Text + "', '" +
                        textbox_discountedamount.Text + "', '" +
                        textbox_totalquantity.Text + "', '" +
                        textbox_totaldiscountgiven.Text + "', '" +
                        textbox_totaldicountedamount.Text + "', '" +
                        textbox_pcterminalno.Text + "', '" +
                        dateTimePicker1.Text + "', '" +
                        textbox_employeeid.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    clear_textboxes();

                }
                else if (radiobutton_employeedisc.Checked == true)
                {
                    posdb_connect.pos_sql =
                        "INSERT INTO salesTbl (" +
                        "product_name, product_quantity_per_transaction, product_price, discount_option, " +
                        "discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, " +
                        "summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                        "VALUES ('" + textbox_itemname.Text + "', '" +
                        textbox_quantity.Text + "', '" +
                        textbox_price.Text + "', '" +
                        radiobutton_employeedisc.Text + "', '" +
                        textbox_discountamount.Text + "', '" +
                        textbox_discountedamount.Text + "', '" +
                        textbox_totalquantity.Text + "', '" +
                        textbox_totaldiscountgiven.Text + "', '" +
                        textbox_totaldicountedamount.Text + "', '" +
                        textbox_pcterminalno.Text + "', '" +
                        dateTimePicker1.Text + "', '" +
                        textbox_employeeid.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    clear_textboxes();
                }
                else if (radiobutton_nodiscount.Checked == true)
                {
                    posdb_connect.pos_sql =
                        "INSERT INTO salesTbl (" +
                        "product_name, product_quantity_per_transaction, product_price, discount_option, " +
                        "discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, " +
                        "summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                        "VALUES ('" + textbox_itemname.Text + "', '" +
                        textbox_quantity.Text + "', '" +
                        textbox_price.Text + "', '" +
                        radiobutton_nodiscount.Text + "', '" +
                        textbox_discountamount.Text + "', '" +
                        textbox_discountedamount.Text + "', '" +
                        textbox_totalquantity.Text + "', '" +
                        textbox_totaldiscountgiven.Text + "', '" +
                        textbox_totaldicountedamount.Text + "', '" +
                        textbox_pcterminalno.Text + "', '" +
                        dateTimePicker1.Text + "', '" +
                        textbox_employeeid.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    clear_textboxes();
                }
                else
                {
                    MessageBox.Show("Please select a discount option before entering the transaction.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
