using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;

namespace DSALProject
{
    public partial class POSFoodOrderingApplication : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Variables1 vars = new Variables1();
        Price_Item_Value price_item_value = new Price_Item_Value();
        private Image pic;

        private double total_amount = 0;
        private int total_qty = 0;

        private double[] itemPrices = new double[20];
        private int[] itemQuantities = new int[20];

        private string[] itemNames = new string[20];

        private int bundleAQuantity = 0;
        private int bundleBQuantity = 0;

        private int lastCheckedIndex = -1;

        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string TerminalNo { get; set; }
        public string LoginDate { get; set; }

        // add after private int total_qty = 0;
        private double grandTotalAmount = 0;   // running total that persists after Add-to-Receipt
        private int grandTotalQty = 0;         // running qty that persists after Add-to-Receipt

        public POSFoodOrderingApplication()
        {
            posdb_connect = new pos_dbconnection();
            InitializeComponent();
        }

        private void POSFoodOrderingApplication_Load(object sender, EventArgs e)
        {
            //pic = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\blank_image.jpg");
            pic = Image.FromFile("C:\\Users\\NewPC\\source\\repos\\DSALProject\\DSALProject\\Resources\\blank_image.jpg");
            //pic = Properties.Resources.blank_image;

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

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();


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

            textbox_price.Enabled = false;
            textbox_discountamount.Enabled = false;
            textbox_discountedamount.Enabled = false;
            textbox_totalbills.Enabled = false;
            textbox_totalquantity.Enabled = false;
            textbox_change.Enabled = false;

            textbox_employeeid.Text = EmployeeID;
            textbox_employeename.Text = EmployeeName;
            textbox_pcterminalno.Text = TerminalNo;
            if (!string.IsNullOrEmpty(LoginDate))
                dateTimePicker1.Value = DateTime.Parse(LoginDate);
            else
                dateTimePicker1.Value = DateTime.Now;
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

                checkBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name1"].ToString();
                checkBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name2"].ToString();
                checkBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name3"].ToString();
                checkBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name4"].ToString();
                checkBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name5"].ToString();
                checkBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name6"].ToString();
                checkBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name7"].ToString();
                checkBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name8"].ToString();
                checkBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name9"].ToString();
                checkBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name10"].ToString();
                checkBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name11"].ToString();
                checkBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name12"].ToString();
                checkBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name13"].ToString();
                checkBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name14"].ToString();
                checkBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name15"].ToString();
                checkBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name16"].ToString();
                checkBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name17"].ToString();
                checkBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name18"].ToString();
                checkBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name19"].ToString();
                checkBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name20"].ToString();

                //--------------------------------------------
                label1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price1"].ToString();
                label2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price2"].ToString();
                label3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price3"].ToString();
                label4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price4"].ToString();
                label5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price5"].ToString();
                label6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price6"].ToString();
                label7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price7"].ToString();
                label8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price8"].ToString();
                label9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price9"].ToString();
                label10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price10"].ToString();
                label11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price11"].ToString();
                label12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price12"].ToString();
                label13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price13"].ToString();
                label14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price14"].ToString();
                label15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price15"].ToString();
                label16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price16"].ToString();
                label17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price17"].ToString();
                label18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price18"].ToString();
                label19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price19"].ToString();
                label20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price20"].ToString();


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

                itemNames[0] = checkBox1.Text;
                itemNames[1] = checkBox2.Text;
                itemNames[2] = checkBox3.Text;
                itemNames[3] = checkBox4.Text;
                itemNames[4] = checkBox5.Text;
                itemNames[5] = checkBox6.Text;
                itemNames[6] = checkBox7.Text;
                itemNames[7] = checkBox8.Text;
                itemNames[8] = checkBox9.Text;
                itemNames[9] = checkBox10.Text;
                itemNames[10] = checkBox11.Text;
                itemNames[11] = checkBox12.Text;
                itemNames[12] = checkBox13.Text;
                itemNames[13] = checkBox14.Text;
                itemNames[14] = checkBox15.Text;
                itemNames[15] = checkBox16.Text;
                itemNames[16] = checkBox17.Text;
                itemNames[17] = checkBox18.Text;
                itemNames[18] = checkBox19.Text;
                itemNames[19] = checkBox20.Text;

                checkbox_B_halohalo.Checked = false;
                checkbox_B_chicken.Checked = false;
                checkbox_B_carbonara.Checked = false;
                checkbox_B_fries.Checked = false;
                checkbox_B_pizza.Checked = false;


                checkbox_A_chicken.Checked = false;
                checkbox_A_fries.Checked = false;
                checkbox_A_coke.Checked = false;
                checkbox_A_sidedishes.Checked = false;
                checkbox_A_pizza.Checked = false;

                // Load prices into array
                for (int i = 0; i < 20; i++)
                {
                    itemPrices[i] = Convert.ToDouble(row["price" + (i + 1)]);
                    itemQuantities[i] = 0; // initialize quantities to 0
                }
            }
            else
            {
                MessageBox.Show("No data found for the selected POS ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void quantity_function()
        {
            textbox_quantity.Clear();
            textbox_quantity.Focus();
        }
        private void GetPriceDiscountAmount()
        {
            textbox_price.Text = (price_item_value.GetPriceItem());
            textbox_discountamount.Text = (price_item_value.GetDiscountAmount());
            vars.price = Convert.ToDouble(textbox_price.Text);
        }
        private void RefreshTotals()
        {
            // compute current selection totals (not touching grand totals)
            double currentAmount = 0;
            int currentQty = 0;

            // individual items
            for (int i = 0; i < 20; i++)
            {
                if (itemQuantities[i] > 0)
                {
                    double itemTotal = itemPrices[i] * itemQuantities[i];
                    currentQty += itemQuantities[i];
                    currentAmount += itemTotal;
                }
            }

            // bundles (net after discount)
            if (bundleAQuantity > 0)
            {
                double netPrice = 1000 - 200;
                currentQty += bundleAQuantity;
                currentAmount += netPrice * bundleAQuantity;
            }

            if (bundleBQuantity > 0)
            {
                double netPrice = 1299 - 194.85;
                currentQty += bundleBQuantity;
                currentAmount += netPrice * bundleBQuantity;
            }

            // Show running total = grand totals (already added) + current selection
            int displayQty = grandTotalQty + currentQty;
            double displayAmount = grandTotalAmount + currentAmount;

            textbox_totalquantity.Text = displayQty.ToString();
            textbox_totalbills.Text = displayAmount.ToString("n");
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            
        }



        private void radiobutton_foodbundleA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radiobutton_foodbundleA.Checked)
                {
                    this.BackColor = Color.LightCyan;
                    picturebox_orderimage.Image = Properties.Resources.Food_Bundle_A;

                    // Set checkboxes for bundle A
                    checkbox_A_chicken.Checked = true;
                    checkbox_A_fries.Checked = true;
                    checkbox_A_coke.Checked = true;
                    checkbox_A_sidedishes.Checked = true;
                    checkbox_A_pizza.Checked = true;

                    // Reset bundle B checkboxes
                    checkbox_B_halohalo.Checked = false;
                    checkbox_B_chicken.Checked = false;
                    checkbox_B_carbonara.Checked = false;
                    checkbox_B_fries.Checked = false;
                    checkbox_B_pizza.Checked = false;

                    // Set price and discount
                    textbox_price.Text = "1000.00";
                    textbox_discountamount.Text = "200.00";

                    double price = Convert.ToDouble(textbox_price.Text);
                    double discount = Convert.ToDouble(textbox_discountamount.Text);
                    textbox_discountedamount.Text = (price - discount).ToString("n");

                    // Reset quantity textbox for user input
                    textbox_quantity.Clear();
                    textbox_quantity.Focus();

                    // Do NOT update listbox or totals here
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radiobutton_foodbundleB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radiobutton_foodbundleB.Checked)
                {
                    this.BackColor = Color.LightBlue;
                    picturebox_orderimage.Image = Properties.Resources.Food_Bundle_B;

                    // Reset bundle A checkboxes
                    checkbox_A_chicken.Checked = false;
                    checkbox_A_fries.Checked = false;
                    checkbox_A_coke.Checked = false;
                    checkbox_A_sidedishes.Checked = false;
                    checkbox_A_pizza.Checked = false;

                    // Set checkboxes for bundle B
                    checkbox_B_halohalo.Checked = true;
                    checkbox_B_chicken.Checked = true;
                    checkbox_B_carbonara.Checked = true;
                    checkbox_B_fries.Checked = true;
                    checkbox_B_pizza.Checked = true;

                    // Set price and discount
                    textbox_price.Text = "1299.00";
                    textbox_discountamount.Text = "194.85";

                    double price = Convert.ToDouble(textbox_price.Text);
                    double discount = Convert.ToDouble(textbox_discountamount.Text);
                    textbox_discountedamount.Text = (price - discount).ToString("n");

                    // Reset quantity textbox for user input
                    textbox_quantity.Clear();
                    textbox_quantity.Focus();

                    // Do NOT update listbox or totals here
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textbox_cashgiven.Text, out double cash_given))
                {
                    MessageBox.Show("Please enter a valid cash amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_cashgiven.Focus();
                    return;
                }

                if (!double.TryParse(textbox_totalbills.Text, out double total_amountPaid))
                {
                    MessageBox.Show("Total Bills is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double change = cash_given - total_amountPaid;
                textbox_change.Text = change.ToString("n");

                listbox_display.Items.Add("-----------------------------------------------------");
                listbox_display.Items.Add("Total Bills: " + textbox_totalbills.Text);
                listbox_display.Items.Add("Cash Given: " + textbox_cashgiven.Text);
                listbox_display.Items.Add("Change: " + textbox_change.Text);
                listbox_display.Items.Add("Total No. of Items: " + textbox_totalquantity.Text);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
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

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
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

                listbox_display.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbox_quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textbox_quantity.Text, out int qty))
                {
                    RefreshTotals();
                    return;
                }

                double price = 0;
                double discount = 0;

                // Bundles
                if (radiobutton_foodbundleA.Checked)
                {
                    bundleAQuantity = qty;
                    price = 1000;
                    discount = 200;
                }
                else if (radiobutton_foodbundleB.Checked)
                {
                    bundleBQuantity = qty;
                    price = 1299;
                    discount = 194.85;
                }
                else if (lastCheckedIndex >= 0) // individual item
                {
                    itemQuantities[lastCheckedIndex] = qty;
                    price = itemPrices[lastCheckedIndex];
                    discount = 0; // change if items have discounts
                }

                // Update discounted amount for current selection
                textbox_discountedamount.Text = ((price - discount) * qty).ToString("n");

                RefreshTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Lesson3Example3_PrintForm print = new Lesson3Example3_PrintForm();

                print.listbox_printdisplay.Items.AddRange(this.listbox_display.Items);
                print.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listbox_display.Items.RemoveAt(listbox_display.SelectedIndex);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.CheckBox chk = sender as System.Windows.Forms.CheckBox;
                if (chk == null) return;

                int index = -1;
                // Map checkboxes -> index (same as before)
                if (chk == checkBox1) index = 0;
                else if (chk == checkBox2) index = 1;
                else if (chk == checkBox3) index = 2;
                else if (chk == checkBox4) index = 3;
                else if (chk == checkBox5) index = 4;
                else if (chk == checkBox6) index = 5;
                else if (chk == checkBox7) index = 6;
                else if (chk == checkBox8) index = 7;
                else if (chk == checkBox9) index = 8;
                else if (chk == checkBox10) index = 9;
                else if (chk == checkBox11) index = 10;
                else if (chk == checkBox12) index = 11;
                else if (chk == checkBox13) index = 12;
                else if (chk == checkBox14) index = 13;
                else if (chk == checkBox15) index = 14;
                else if (chk == checkBox16) index = 15;
                else if (chk == checkBox17) index = 16;
                else if (chk == checkBox18) index = 17;
                else if (chk == checkBox19) index = 18;
                else if (chk == checkBox20) index = 19;

                if (index == -1) return;

                // Track active item so qty textbox knows which item to edit
                lastCheckedIndex = index;

                if (chk.Checked)
                {
                    // default quantity to 1 for preview (doesn't affect grand totals yet)
                    itemQuantities[index] = 1;

                    // populate UI to help the user edit (price & qty fields)
                    textbox_price.Text = itemPrices[index].ToString("n");
                    textbox_discountamount.Text = "0.00";
                    textbox_discountedamount.Text = "0.00"; // if not using discount for single items
                    textbox_quantity.Text = "";
                    textbox_quantity.Focus();
                }
                else
                {
                    // uncheck -> remove from current selection only
                    itemQuantities[index] = 0;

                    if (lastCheckedIndex == index) lastCheckedIndex = -1;

                    // clear UI input fields if nothing selected
                    textbox_price.Clear();
                    textbox_quantity.Clear();
                    textbox_discountamount.Clear();
                    textbox_discountedamount.Clear();
                }

                // refresh shown totals (grand + current)
                RefreshTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // compute current selection totals (mirrors RefreshTotals logic)
                double currentAmount = 0;
                int currentQty = 0;

                // bundles
                if (bundleAQuantity > 0)
                {
                    double net = 1000 - 200;
                    double subtotal = net * bundleAQuantity;
                    listbox_display.Items.Add("Bundle A x " + bundleAQuantity + " = " + subtotal.ToString("n"));
                    currentQty += bundleAQuantity;
                    currentAmount += subtotal;
                    InsertTransaction("Food Bundle A", bundleAQuantity, 1000, 200, "Bundle A");
                }

                if (bundleBQuantity > 0)
                {
                    double net = 1299 - 194.85;
                    double subtotal = net * bundleBQuantity;
                    listbox_display.Items.Add("Bundle B x " + bundleBQuantity + " = " + subtotal.ToString("n"));
                    currentQty += bundleBQuantity;
                    currentAmount += subtotal;
                    InsertTransaction("Food Bundle B", bundleBQuantity, 1299, 194.85, "Bundle B");
                }

                // individual items
                for (int i = 0; i < 20; i++)
                {
                    if (itemQuantities[i] > 0)
                    {
                        double subtotal = itemPrices[i] * itemQuantities[i];
                        listbox_display.Items.Add(itemNames[i] + " x " + itemQuantities[i] + " = " + subtotal.ToString("n"));
                        currentQty += itemQuantities[i];
                        currentAmount += subtotal;
                        InsertTransaction(itemNames[i], itemQuantities[i], itemPrices[i], 0, ""); // No discount for individual items
                    }
                }

                // nothing selected -> no add
                if (currentQty == 0 && currentAmount == 0)
                {
                    MessageBox.Show("No items selected to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // update grand totals (accumulate)
                grandTotalQty += currentQty;
                grandTotalAmount += currentAmount;



                // Update displayed totals to reflect accumulated totals (current selection is now added)
                RefreshTotals();

                // Clear current selection for next entry (but keep grand totals)
                textbox_price.Clear();
                textbox_quantity.Clear();
                textbox_discountamount.Clear();
                textbox_discountedamount.Clear();
                radiobutton_foodbundleA.Checked = false;
                radiobutton_foodbundleB.Checked = false;
                lastCheckedIndex = -1;
                bundleAQuantity = 0;
                bundleBQuantity = 0;
                for (int i = 0; i < 20; i++) itemQuantities[i] = 0;

                // RefreshTotals again to ensure display (should show grand totals)
                RefreshTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertTransaction(string productName, int quantity, double price, double discount, string discountOption)
        {
            try
            {
                // Multiply discount by quantity for total discount
                double totalDiscount = discount * quantity;
                double discountedAmount = (price * quantity) - totalDiscount;

                // Optional: show total discounted amount in UI
                textbox_discountedamount.Text = discountedAmount.ToString("n");
                textbox_discountamount.Text = totalDiscount.ToString("n"); // now shows total discount for all items

                posdb_connect.pos_sql =
                    "INSERT INTO salesTbl (" +
                    "product_name, product_quantity_per_transaction, product_price, discount_option, " +
                    "discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, " +
                    "summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                    "VALUES ('" + productName + "', '" +
                    quantity + "', '" +
                    price + "', '" +
                    discountOption + "', '" +
                    totalDiscount + "', '" +
                    discountedAmount + "', '" +
                    textbox_totalquantity.Text + "', '" +
                    totalDiscount + "', '" +
                    textbox_totalbills.Text + "', '" +
                    textbox_pcterminalno.Text + "', '" +
                    dateTimePicker1.Text + "', '" +
                    textbox_employeeid.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting transaction: " + ex.Message);
            }
        }
    }
    
}