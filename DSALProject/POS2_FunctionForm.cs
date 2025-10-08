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
    public partial class POS2_FunctionForm : Form
    {
        public POS2_FunctionForm()
        {
            InitializeComponent();
            DisableTextboxes();
        }

        private void POS2_FunctionForm_Load(object sender, EventArgs e)
        {
            SetupPizzaCheckboxes();
        }

        // Radiobutton Function
        private void HandleFoodBundle(string bundle, bool isChecked)
        {
            if (!isChecked) return; // Only run when checked

            if (bundle == "A")
            {
                this.BackColor = Color.LightCyan;
                picturebox_orderimage.Image = Properties.Resources.Food_Bundle_A;

                // Check A bundle checkboxes
                checkbox_A_chicken.Checked = true;
                checkbox_A_fries.Checked = true;
                checkbox_A_coke.Checked = true;
                checkbox_A_sidedishes.Checked = true;
                checkbox_A_pizza.Checked = true;

                // Uncheck B bundle checkboxes
                checkbox_B_halohalo.Checked = false;
                checkbox_B_chicken.Checked = false;
                checkbox_B_carbonara.Checked = false;
                checkbox_B_fries.Checked = false;
                checkbox_B_pizza.Checked = false;

                // Update disabled textboxes
                textbox_price.Text = "1,000.00";
                textbox_discountamount.Text = "200.00";
                textbox_discountedamount.Text = "";
                textbox_quantity.Text = "0";

                // Add items to listbox
                listbox_display.Items.Add(radiobutton_foodbundleA.Text + "          " + textbox_price.Text);
                listbox_display.Items.Add("          Discount Amount: " + "         " + textbox_discountamount.Text);
            }
            else if (bundle == "B")
            {
                this.BackColor = Color.LightBlue;
                picturebox_orderimage.Image = Properties.Resources.Food_Bundle_B;

                // Check B bundle checkboxes
                checkbox_B_halohalo.Checked = true;
                checkbox_B_chicken.Checked = true;
                checkbox_B_carbonara.Checked = true;
                checkbox_B_fries.Checked = true;
                checkbox_B_pizza.Checked = true;

                // Uncheck A bundle checkboxes
                checkbox_A_chicken.Checked = false;
                checkbox_A_fries.Checked = false;
                checkbox_A_coke.Checked = false;
                checkbox_A_sidedishes.Checked = false;
                checkbox_A_pizza.Checked = false;

                // Update disabled textboxes
                textbox_price.Text = "1,299.00";
                textbox_discountamount.Text = "194.85";
                textbox_discountedamount.Text = "";
                textbox_quantity.Text = "0";

                // Add items to listbox
                listbox_display.Items.Add(radiobutton_foodbundleB.Text + "          " + textbox_price.Text);
                listbox_display.Items.Add("          Discount Amount: " + "         " + textbox_discountamount.Text);
            }

            textbox_quantity.Focus();
        }
        // Radiobutton A
        private void radiobutton_foodbundleA_CheckedChanged(object sender, EventArgs e)
        {
            HandleFoodBundle("A", radiobutton_foodbundleA.Checked);
        }
        // Radiobutton B
        private void radiobutton_foodbundleB_CheckedChanged(object sender, EventArgs e)
        {
            HandleFoodBundle("B", radiobutton_foodbundleB.Checked);
        }
        // Exit Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Disable Textboxes Function
        private void DisableTextboxes()
        {
            textbox_price.Enabled = false;
            textbox_discountamount.Enabled = false;
            textbox_discountedamount.Enabled = false;
            textbox_totalbills.Enabled = false;
            textbox_totalquantity.Enabled = false;
            textbox_change.Enabled = false;
        }

        private void AddPizzaItem(CheckBox checkbox, string pizzaName, double price)
        {
            if (!checkbox.Checked)
            {
                // Remove from listbox if unchecked
                for (int i = 0; i < listbox_display.Items.Count; i++)
                {
                    if (listbox_display.Items[i].ToString().StartsWith(pizzaName))
                    {
                        listbox_display.Items.RemoveAt(i);
                        break;
                    }
                }
                // If no pizza remains checked, reset price textbox
                if (!IsAnyPizzaChecked())
                    textbox_price.Text = "";
                UpdateTotals();
                return;
            }

            // If any pizza is clicked, uncheck food bundle radio buttons
            radiobutton_foodbundleA.Checked = false;
            radiobutton_foodbundleB.Checked = false;

            // Change background color for pizza selection
            this.BackColor = Color.LightYellow;

            // Add item to listbox
            listbox_display.Items.Add($"{pizzaName}          {price.ToString("n2")}");

            // Update price textbox to the selected pizza price
            textbox_price.Text = price.ToString("n2");

            // Focus on quantity
            textbox_quantity.Text = "1"; // optional default quantity
            textbox_quantity.Focus();

            // Update totals immediately
            UpdateTotals();
        }

        // Helper function to check if any pizza checkbox is checked
        private bool IsAnyPizzaChecked()
        {
            return checkBox11.Checked || checkBox12.Checked || checkBox13.Checked || checkBox14.Checked ||
                   checkBox15.Checked || checkBox16.Checked || checkBox17.Checked || checkBox18.Checked ||
                   checkBox19.Checked || checkBox20.Checked || checkBox21.Checked || checkBox22.Checked ||
                   checkBox23.Checked || checkBox24.Checked || checkBox25.Checked || checkBox26.Checked ||
                   checkBox27.Checked || checkBox28.Checked || checkBox29.Checked || checkBox30.Checked;
        }

        // Setup pizza checkboxes with event handlers
        private void SetupPizzaCheckboxes()
        {
            Dictionary<CheckBox, (string, double)> pizzaItems = new Dictionary<CheckBox, (string, double)>
            {
                { checkBox11, ("Margherita", 280) },
                { checkBox12, ("Pepperoni", 320) },
                { checkBox13, ("Hawaiian", 350) },
                { checkBox14, ("BBQ Chicken", 380) },
                { checkBox15, ("Meat Lovers", 420) },
                { checkBox16, ("Veggie", 480) },
                { checkBox17, ("Four Cheese", 390) },
                { checkBox18, ("Supreme", 450) },
                { checkBox19, ("Buffalo Chicken", 400) },
                { checkBox20, ("Seafood Pizza", 330) },
                { checkBox21, ("Spinach and Feta", 520) },
                { checkBox22, ("Mushroom Truffle", 300) },
                { checkBox23, ("Breakfast Pizza", 400) },
                { checkBox24, ("Cheeseburger", 450) },
                { checkBox25, ("White Pizza", 360) },
                { checkBox26, ("Sicilian", 340) },
                { checkBox27, ("Detroit Style", 380) },
                { checkBox28, ("Neapolitan", 360) },
                { checkBox29, ("Calzone", 500) },
                { checkBox30, ("Chicago Deep Dish", 370) }
            };
            // Attach event handlers
            foreach (var pair in pizzaItems)
            {
                pair.Key.CheckedChanged += (s, e) => AddPizzaItem(pair.Key, pair.Value.Item1, pair.Value.Item2);
            }
        }

        // Calculate Totals Function
        private void CalculateTotals()
        {
            double totalBill = 0;
            int totalQuantity = 0;
            double discount = 0;
            double.TryParse(textbox_discountamount.Text, out discount);

            foreach (var item in listbox_display.Items)
            {
                string line = item.ToString();
                if (line.Contains("Discount Amount")) continue;

                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string priceStr = parts[parts.Length - 1];

                if (double.TryParse(priceStr, out double price))
                {
                    int quantity = 1;
                    if (!string.IsNullOrWhiteSpace(textbox_quantity.Text))
                        int.TryParse(textbox_quantity.Text, out quantity);

                    totalBill += price * quantity;
                    totalQuantity += quantity;
                }
            }

            totalBill -= discount;
            if (totalBill < 0) totalBill = 0;

            textbox_discountedamount.Text = totalBill.ToString("n2");
            textbox_totalbills.Text = totalBill.ToString("n2");
            textbox_totalquantity.Text = totalQuantity.ToString();

            if (double.TryParse(textbox_cashgiven.Text, out double cashReceived))
            {
                double change = cashReceived - totalBill;
                textbox_change.Text = change.ToString("n2");
            }
        }
        // Update totals when quantity or cash given changes
        private void UpdateTotals()
        {
            double totalBill = 0;
            double totalDiscount = 0; // reset discount every time
            int totalQuantity = 0;

            // Iterate through the listbox items
            foreach (var item in listbox_display.Items)
            {
                string line = item.ToString();

                // Skip discount lines
                if (line.Contains("Discount Amount")) continue;

                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string priceStr = parts[parts.Length - 1];

                if (double.TryParse(priceStr, out double price))
                {
                    int quantity = 1;
                    if (int.TryParse(textbox_quantity.Text, out int q))
                        quantity = q;

                    totalBill += price * quantity;
                    totalQuantity += quantity;
                }
            }

            // Apply discount only if a bundle is selected
            if (radiobutton_foodbundleA.Checked)
                totalDiscount += 200; // Discount for bundle A
            else if (radiobutton_foodbundleB.Checked)
                totalDiscount += 194.85; // Discount for bundle B
                                         // Otherwise totalDiscount stays 0

            textbox_discountamount.Text = totalDiscount.ToString("n2");

            double discountedAmount = totalBill - totalDiscount;
            if (discountedAmount < 0) discountedAmount = 0;

            textbox_discountedamount.Text = discountedAmount.ToString("n2");
            textbox_totalbills.Text = totalBill.ToString("n2");
            textbox_totalquantity.Text = totalQuantity.ToString();

            // Optional: update change if cash received is entered
            if (double.TryParse(textbox_cashgiven.Text, out double cashReceived))
            {
                double change = cashReceived - discountedAmount;
                textbox_change.Text = change.ToString("n2");
            }
        }
        // Calculate Button
        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        // Cash Given Textbox Change Event
        private void textbox_quantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        // Clear Function
        private void Clear()
        {
            // Clear all selections and inputs
            radiobutton_foodbundleA.Checked = false;
            radiobutton_foodbundleB.Checked = false;
            foreach (var checkbox in new CheckBox[] {
                checkbox_A_chicken, checkbox_A_fries, checkbox_A_coke, checkbox_A_sidedishes, checkbox_A_pizza,
                checkbox_B_halohalo, checkbox_B_chicken, checkbox_B_carbonara, checkbox_B_fries, checkbox_B_pizza,
                checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18,
                checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26,
                checkBox27, checkBox28, checkBox29, checkBox30 })
            {
                checkbox.Checked = false;
            }
            listbox_display.Items.Clear();
            textbox_price.Text = "";
            textbox_discountamount.Text = "";
            textbox_discountedamount.Text = "";
            textbox_quantity.Text = "0";
            textbox_totalbills.Text = "";
            textbox_totalquantity.Text = "";
            textbox_cashgiven.Text = "";
            textbox_change.Text = "";
            picturebox_orderimage.Image = null;
            this.BackColor = SystemColors.Control; // Reset to default color
        }
        // Clear Button
        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
        // Print Receipt Function
        private void printreceipt()
        {
            Lesson3Example3_PrintForm print = new Lesson3Example3_PrintForm();

            print.listbox_printdisplay.Items.AddRange(this.listbox_display.Items);
            print.Show();
        }

        // Print Receipt Button
        private void button2_Click(object sender, EventArgs e)
        {
            printreceipt();
        }
        // Remove Selected Item Button
        private void button3_Click(object sender, EventArgs e)
        {
            removeSelectedItem();
        }
        // Remove Selected Item Function
        private void removeSelectedItem()
        {
            if (listbox_display.SelectedItem != null)
            {
                listbox_display.Items.Remove(listbox_display.SelectedItem);
                UpdateTotals();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
