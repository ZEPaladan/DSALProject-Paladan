using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSALProject
{
    public class POS1_Functions
    {
        // Function to display item name and price based on item number
        public static void ItemsAndPricesDisplay(TextBox itemNameBox, TextBox priceBox, int itemNumber)
        {
            try 
            {
                var item = POS1_ItemsAndPrices.ItemsAndPrices[itemNumber];
                itemNameBox.Text = item.ItemName;
                priceBox.Text = item.Price.ToString("F2");

                
                Variables.Current.item_name = item.ItemName;
                Variables.Current.price = item.Price;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ItemsAndPricesDisplay: " + ex.Message);
            }
        }

        // Function to calculate discount based on discount type
        public static void ApplyDiscount(
            string discountType,
            TextBox quantityBox,
            TextBox priceBox,
            TextBox discountAmountBox,
            TextBox discountedAmountBox,
            RadioButton seniorRadio,
            RadioButton cardRadio,
            RadioButton employeeRadio,
            RadioButton noDiscRadio)
        {
            try
            {
                // Get quantity and price safely
                Variables.Current.quantity = Convert.ToInt32(quantityBox.Text);
                Variables.Current.price = Convert.ToDouble(priceBox.Text);

                double discountRate = 0;

                // Assign discount rate based on type
                switch (discountType)
                {
                    case "seniorcitizen":
                        discountRate = 0.30;
                        break;
                    case "withdisccard":
                        discountRate = 0.10;
                        break;
                    case "employeedisc":
                        discountRate = 0.15;
                        break;
                    case "nodisc":
                        discountRate = 0;
                        break;
                }

                // Perform calculations
                Variables.Current.discount = (Variables.Current.quantity * Variables.Current.price) * discountRate;
                Variables.Current.discounted_amount = (Variables.Current.quantity * Variables.Current.price) - Variables.Current.discount;

                // Display results
                discountAmountBox.Text = Variables.Current.discount.ToString("n");
                discountedAmountBox.Text = Variables.Current.discounted_amount.ToString("n");
               
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ApplyDiscount: " + ex.Message);
            }
        }


        // Function to clear and focus on quantity textbox
        public static void ClearAndFocusQuanity(TextBox quantityBox)
        {
            try 
            {
                quantityBox.Clear();
                quantityBox.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ClearAndFocusQuantity: " + ex.Message);
            }
        }

        // Function to calculate totals and change
        public static void Calculate(TextBox totalQuantityBox, TextBox totalDiscountGivenBox, TextBox totalDiscountedAmountBox, 
            TextBox quantityBox, TextBox discountBox, TextBox discountedAmountBox, TextBox cashrenderedBox, TextBox changeBox)
        {
            try 
            {
                //Calculate for change
                Variables.Current.cash_rendered = Convert.ToDouble(cashrenderedBox.Text);
                Variables.Current.change = Variables.Current.cash_rendered - Variables.Current.discounted_amount;
                changeBox.Text = Variables.Current.change.ToString("F2");

                //Calculate for totals
                Variables.Current.total_quantity += Convert.ToInt32(quantityBox.Text);
                totalQuantityBox.Text = Variables.Current.total_quantity.ToString();

                //Accumulate total discount given and total discounted amount
                Variables.Current.total_discount_given += Convert.ToDouble(discountBox.Text);
                totalDiscountGivenBox.Text = Variables.Current.total_discount_given.ToString("F2");
                Variables.Current.total_discounted_amount += Convert.ToDouble(discountedAmountBox.Text);
                totalDiscountedAmountBox.Text = Variables.Current.total_discounted_amount.ToString("F2");
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Calculate: " + ex.Message);
            }
        }
        // Function to clear all textboxes and reset variables
        public static void ClearAll(TextBox itemNameBox, TextBox priceBox, TextBox quantityBox,
            TextBox discountAmountBox, TextBox discountedAmountBox, RadioButton seniorRadio,
            RadioButton cardRadio, RadioButton employeeRadio, RadioButton noDiscRadio,
            TextBox totalQuantityBox, TextBox totalDiscountGivenBox, TextBox totalDiscountedAmountBox,
            TextBox cashrenderedBox, TextBox changeBox)
        {
            try 
            {
                // Clear all textboxes
                itemNameBox.Clear();
                priceBox.Clear();
                quantityBox.Clear();
                discountAmountBox.Clear();
                discountedAmountBox.Clear();
                totalQuantityBox.Clear();
                totalDiscountGivenBox.Clear();
                totalDiscountedAmountBox.Clear();
                cashrenderedBox.Clear();
                changeBox.Clear();
                // Reset radio buttons
                seniorRadio.Checked = false;
                cardRadio.Checked = false;
                employeeRadio.Checked = false;
                noDiscRadio.Checked = false;
                // Reset variables
                Variables.Current.item_name = string.Empty;
                Variables.Current.price = 0;
                Variables.Current.quantity = 0;
                Variables.Current.discount = 0;
                Variables.Current.discounted_amount = 0;
                Variables.Current.cash_rendered = 0;
                Variables.Current.change = 0;
                // Note: Total variables are not reset here to preserve running totals
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ClearAll: " + ex.Message);
            }
        }
        public static void DisableTextboxes(params TextBox[] textboxes)
        {
            foreach (var tb in textboxes)
            {
                tb.Enabled = false;
            }
        }

    }
    public class POS2_Functions
    {
        // Function to display item name and price based on item number
        public static void ItemsAndPricesDisplay(TextBox priceBox, int itemNumber)
        {
            try
            {
                var item = POS2_ItemsAndPrices.ItemsAndPrices[itemNumber];
                priceBox.Text = item.Price.ToString("F2");

                Variables.Current.item_name = item.ItemName;
                Variables.Current.price = item.Price;
                Variables.Current.discount = item.Discount;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ItemsAndPricesDisplay: " + ex.Message);
            }
        }
        // Function to display food bundles and manage checkboxes
        public static void FoodBundlesDisplay(Form form, string bundleName, Color bgColor, PictureBox pictureBox, Image bundleImage, TextBox priceBox, TextBox discountBox,
            TextBox quantityBox, RadioButton bundleRadioButton, 
            CheckBox check1, CheckBox check2, CheckBox check3, CheckBox check4, CheckBox check5, // group to check
            CheckBox uncheck1, CheckBox uncheck2, CheckBox uncheck3, CheckBox uncheck4, CheckBox uncheck5) // group to uncheck
        {
            pictureBox.Image = bundleImage;

            check1.Checked = true;
            check2.Checked = true;
            check3.Checked = true;
            check4.Checked = true;
            check5.Checked = true;

            uncheck1.Checked = false;
            uncheck2.Checked = false;
            uncheck3.Checked = false;
            uncheck4.Checked = false;
            uncheck5.Checked = false;

            if (bundleName == "A")
            {   
                form.BackColor = bgColor;
                pictureBox.BackColor = bgColor;
                Variables.Current.item_name = "Food Bundle A";
                priceBox.Text = "1,000.00";
                discountBox.Text = "100.00";
            }
            else if (bundleName == "B")
            {
                form.BackColor = bgColor;
                pictureBox.BackColor = bgColor;
                Variables.Current.item_name = "Food Bundle B";
                priceBox.Text = "1,299.00";
                discountBox.Text = "194.85";
            }


            quantityBox.Focus();
            
        }
        // Function to calculate price, discount, and discounted amount
        public static void CalculatePriceAndDiscount(TextBox priceBox, TextBox discountBox, TextBox quantityBox, TextBox discountedAmountBox)
        {
            try
            {
                double price = 0;
                int quantity = 0;
                double discount = 0;

                double.TryParse(priceBox.Text, out price);
                int.TryParse(quantityBox.Text, out quantity);
                double.TryParse(discountBox.Text, out discount);

                Variables.Current.price = price;
                Variables.Current.quantity = quantity;
                Variables.Current.discount = discount;

                Variables.Current.discounted_amount = (price * quantity) - discount;
                discountedAmountBox.Text = Variables.Current.discounted_amount.ToString("F2");
            }
            catch (Exception ex)
            {
                // Optional: handle unexpected errors
                Variables.Current.price = 0;
                Variables.Current.quantity = 0;
                Variables.Current.discount = 0;
                Variables.Current.discounted_amount = 0;
                discountedAmountBox.Text = "0.00";
            }
        }
        // Function to add item to listbox and update totals
        public static void AddToListboxAndIncrementTotal(ListBox listbox, TextBox priceBox, TextBox totalQuantityBox, 
            TextBox quantityBox, TextBox discountBox, TextBox discountedAmountBox, TextBox totalPrice, RadioButton radioButton1, RadioButton radioButton2)
        {
            try
            {
                int quantity = 0;
                int.TryParse(quantityBox.Text, out quantity);

                double price = 0;
                double.TryParse(priceBox.Text, out price);

                double discount = 0;
                double.TryParse(discountBox.Text, out discount);

                double discountedAmount = 0;
                double.TryParse(discountedAmountBox.Text, out discountedAmount);

                int totalQuantity = 0;
                int.TryParse(totalQuantityBox.Text, out totalQuantity);

                double totalPriceValue = 0;
                double.TryParse(totalPrice.Text, out totalPriceValue);

                // Add item to listbox
                listbox.Items.Add($"Item: {Variables.Current.item_name}");
                listbox.Items.Add($"    Qty: {quantity}");
                listbox.Items.Add($"    Price: {price:F2}");
                listbox.Items.Add($"    Discount: {discount:F2}");
                listbox.Items.Add($"    Total: {discountedAmount:F2}");
                listbox.Items.Add("----------------------------------------------");                
                // Increment totals
                totalQuantity += quantity;
                totalPriceValue += discountedAmount;
                totalQuantityBox.Text = totalQuantity.ToString();
                totalPrice.Text = totalPriceValue.ToString("F2");
                // Reset price and quantity for next item
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                Variables.Current.price = 0;
                Variables.Current.quantity = 0;
                Variables.Current.discount = 0;
                quantityBox.Clear();
                priceBox.Clear();
                discountBox.Clear();
                discountedAmountBox.Clear();
                

            }
            catch (Exception ex)
            {
                throw new Exception("Error in AddToListboxAndIncrementTotal: " + ex.Message);
            }
        }
        // Function to start a new order by clearing all fields and resetting variables
        public static void NewOrder(
            ListBox listbox,
            TextBox priceBox,
            TextBox quantityBox,
            TextBox discountBox,
            TextBox discountedAmountBox,
            TextBox totalQuantityBox,
            TextBox totalPriceBox,
            TextBox cashGivenBox,
            TextBox changeBox,
            params CheckBox[] checkboxes
            )
        {
            try
            {
                // Clear listbox
                listbox.Items.Clear();

                // Clear textboxes
                priceBox.Clear();
                quantityBox.Clear();
                discountBox.Clear();
                discountedAmountBox.Clear();
                totalQuantityBox.Clear();
                totalPriceBox.Clear();
                cashGivenBox.Clear();
                changeBox.Clear();

                // Reset all checkboxes
                foreach (var cb in checkboxes)
                {
                    cb.Checked = false;
                }

                // Reset variables
                Variables.Current.price = 0;
                Variables.Current.quantity = 0;
                Variables.Current.discount = 0;
                Variables.Current.discounted_amount = 0;
                Variables.Current.total_quantity = 0;
                Variables.Current.total_discount_given = 0;
                Variables.Current.total_discounted_amount = 0;
                Variables.Current.cash_rendered = 0;
                Variables.Current.change = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in NewOrder: " + ex.Message);
            }
        }
        // Function to remove selected item from listbox and update totals
        public static void RemoveSelectedItemMultiLine(
            ListBox listbox,
            TextBox totalQuantityBox,
            TextBox totalPriceBox,
            TextBox totalDiscountBox,
            TextBox totalDiscountedAmountBox)
        {
            try
            {
                if (listbox.SelectedIndex < 0) return;

                int startIndex = listbox.SelectedIndex;

                // Make sure there are enough lines
                if (startIndex + 5 >= listbox.Items.Count) return;

                // Parse values from the lines
                int quantity = 0;
                double price = 0, discount = 0, discountedAmount = 0;

                int.TryParse(listbox.Items[startIndex + 1].ToString().Trim().Replace("Qty:", ""), out quantity);
                double.TryParse(listbox.Items[startIndex + 2].ToString().Trim().Replace("Price:", ""), out price);
                double.TryParse(listbox.Items[startIndex + 3].ToString().Trim().Replace("Discount:", ""), out discount);
                double.TryParse(listbox.Items[startIndex + 4].ToString().Trim().Replace("Total:", ""), out discountedAmount);

                // Remove the 6 lines (item + details + separator)
                for (int i = 0; i < 6; i++)
                    listbox.Items.RemoveAt(startIndex);

                // Update totals
                int totalQty = 0;
                double totalPrice = 0;
                double totalDisc = 0;
                double totalDiscAmt = 0;

                int.TryParse(totalQuantityBox.Text, out totalQty);
                double.TryParse(totalPriceBox.Text, out totalPrice);
                double.TryParse(totalDiscountBox.Text, out totalDisc);
                double.TryParse(totalDiscountedAmountBox.Text, out totalDiscAmt);

                totalQty -= quantity;
                totalDisc -= discount;
                totalDiscAmt -= discountedAmount;
                totalPrice -= discountedAmount;

                if (totalQty < 0) totalQty = 0;
                if (totalDisc < 0) totalDisc = 0;
                if (totalDiscAmt < 0) totalDiscAmt = 0;
                if (totalPrice < 0) totalPrice = 0;

                totalQuantityBox.Text = totalQty.ToString();
                totalPriceBox.Text = totalPrice.ToString("F2");
                totalDiscountBox.Text = totalDisc.ToString("F2");
                totalDiscountedAmountBox.Text = totalDiscAmt.ToString("F2");

                // Reset current variables
                Variables.Current.quantity = 0;
                Variables.Current.discount = 0;
                Variables.Current.discounted_amount = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in RemoveSelectedItemMultiLine: " + ex.Message);
            }
        }
        // Function to print the contents of the listbox
        public static void PrintListBox(ListBox listbox)
        {
            try 
            { 
                Lesson3Example3_PrintForm printForm = new Lesson3Example3_PrintForm();
                printForm.listbox_printdisplay.Items.AddRange(listbox.Items);
                printForm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in PrintListBox: " + ex.Message);
            }
        }
        // Function to calculate change and display transaction summary
        public static void CalculateChange(TextBox cashGivenBox, TextBox changeBox, TextBox totalPriceBox, ListBox listbox)
        {
            try 
            {
                double cashGiven = 0;
                double totalPrice = 0;
                double.TryParse(cashGivenBox.Text, out cashGiven);
                double.TryParse(totalPriceBox.Text, out totalPrice);
                Variables.Current.cash_rendered = cashGiven;
                Variables.Current.change = cashGiven - totalPrice;
                changeBox.Text = Variables.Current.change.ToString("F2");

                listbox.Items.Add($"Cash Given: {cashGiven:F2}");
                listbox.Items.Add($"Total Price: {totalPrice:F2}");
                listbox.Items.Add($"Change: {Variables.Current.change:F2}");
                listbox.Items.Add("Thank you! Please come again!");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in CalculateChange: " + ex.Message);
            }
        }



    }
    public class Payrol
    {
        // Function to calculate income based on hourly rate and hours worked
        public static void CalculateIncome(TextBox hourlyrateBox, TextBox hoursworkedBox, TextBox incomeBox)
        {
            try
            {
                if (!double.TryParse(hourlyrateBox.Text, out double hourlyrate))
                {
                    hourlyrateBox.Text = "";
                    hourlyrateBox.Focus();
                    return;
                }
                if (!double.TryParse(hoursworkedBox.Text, out double hoursworked))
                {
                    hourlyrateBox.Text = "";
                    hoursworkedBox.Focus();
                    return;
                }

                double income = hourlyrate * hoursworked;

                incomeBox.Text = income.ToString("F2");
            }
            catch (Exception ex)
            {
                hourlyrateBox.Text = "";
            }
        }
        // Function to populate ComboBox with values
        public static void ComboBoxValues(ComboBox comboBox)
        {
            comboBox.Text = "Select";
            comboBox.Items.Add("Others 1");
            comboBox.Items.Add("Others 2");
            comboBox.Items.Add("Others 3");
            comboBox.Items.Add("Others 4");
            comboBox.Items.Add("None");
        }
        // Function to set other loan amount based on ComboBox selection
        public static void ComboBoxOthersLoan(ComboBox comboBox, TextBox otherloanBox)
        {
            if (comboBox.SelectedItem != null && comboBox.SelectedItem.ToString() == "None")
            {
                otherloanBox.Text = "0.00";
            }
            else if (comboBox.SelectedItem != null && comboBox.Text == "Others 1")
            {
                otherloanBox.Text = "500.00";
            }
            else if (comboBox.SelectedItem != null && comboBox.Text == "Others 2")
            {
                otherloanBox.Text = "550.00";
            }
            else if (comboBox.SelectedItem != null && comboBox.Text == "Others 3")
            {
                otherloanBox.Text = "1550.00";
            }
            else if (comboBox.SelectedItem != null && comboBox.Text == "Others 4")
            {
                otherloanBox.Text = "1250.00";
            }
        }
        // Function to calculate gross income, contributions, deductions, and net income
        public static void CalculateGrossIncomeandContributions(
            TextBox basicpayIncomeBox, TextBox honorariumIncomeBox, TextBox otherIncomeBox,
            TextBox grossIncomeBox, TextBox netIncomeBox, TextBox totaldeductionBox,
            TextBox ssscontribBox, TextBox philhealthcontribBox, TextBox pagibigcontribBox, TextBox taxcontribBox,
            TextBox sssloanBox, TextBox pagibigloanbox, TextBox facultysavingsBox, TextBox facultyloanBox, TextBox salaryloanBox, TextBox otherloanBox)
        {
            try
            {
                //Parse incomes
                double basicPay = double.TryParse(basicpayIncomeBox.Text, out double b) ? b : 0;
                double honorarium = double.TryParse(honorariumIncomeBox.Text, out double h) ? h : 0;
                double otherIncome = double.TryParse(otherIncomeBox.Text, out double o) ? o : 0;

                // Calculate gross income
                double grossIncome = basicPay + honorarium + otherIncome;
                grossIncomeBox.Text = grossIncome.ToString("F2");

                // Calculate SSS Contribution
                double[] sssLimits = { 1000, 1249.99, 1749.99, 2249.99, 2749.99, 3249.99, 3749.99, 4249.99, 4749.99, 5249.99,
                               5749.99, 6249.99, 6749.99, 7249.99, 7749.99, 8249.99, 8749.99, 9249.99, 9749.99, 10249.99,
                               10749.99, 11249.99, 11749.99, 12249.99, 12749.99, 13249.99, 13749.99, 14249.99, 14749.99, 15249.99, 15749.99 };
                double[] sssValues = { 0, 36.30, 54.50, 72.70, 90.80, 109.00, 127.20, 145.30, 163.50, 181.70,
                               199.80, 218.00, 236.20, 254.30, 272.50, 290.70, 308.80, 327.00, 345.20, 363.30,
                               381.50, 399.70, 417.80, 436.00, 454.20, 472.30, 490.50, 508.70, 526.80, 545.00, 563.00 };

                double sssContribution = sssValues[sssValues.Length - 1];
                for (int i = 0; i < sssLimits.Length; i++)
                {
                    if (grossIncome <= sssLimits[i])
                    {
                        sssContribution = sssValues[i];
                        break;
                    }
                }
                ssscontribBox.Text = sssContribution.ToString("F2");

                // PhilHealth Contribution
                double[] phLimits = { 10000, 11000, 12000, 13000, 14000, 15000, 16000, 17000, 18000, 19000, 20000, 21000, 22000, 23000,
                              24000, 25000, 26000, 27000, 28000, 29000, 30000, 31000, 32000, 33000, 34000, 35000, 36000, 37000, 38000, 39000 };
                double[] phValues = { 137.50, 151.25, 165.00, 178.75, 192.50, 206.25, 220.00, 233.75, 247.50, 261.25, 275.00, 288.75,
                              302.50, 316.25, 330.00, 343.75, 357.50, 371.25, 385.00, 398.75, 412.50, 426.25, 440.00, 453.75, 467.50, 481.25, 495.00, 508.75, 522.50, 536.25 };

                double philHealthContribution = phValues[phValues.Length - 1];
                for (int i = 0; i < phLimits.Length; i++)
                {
                    if (grossIncome <= phLimits[i])
                    {
                        philHealthContribution = phValues[i];
                        break;
                    }
                }
                philhealthcontribBox.Text = philHealthContribution.ToString("F2");

                // Pag-IBIG Contribution (fixed 100 for example)
                double pagibigContribution = 100;
                pagibigcontribBox.Text = pagibigContribution.ToString("F2");

                // Loans / Deductions
                double sssLoan = double.TryParse(sssloanBox.Text, out double sL) ? sL : 0;
                double pagibigLoan = double.TryParse(pagibigloanbox.Text, out double pL) ? pL : 0;
                double facultySavings = double.TryParse(facultysavingsBox.Text, out double fS) ? fS : 0;
                double facultyLoan = double.TryParse(facultyloanBox.Text, out double fL) ? fL : 0;
                double salaryLoan = double.TryParse(salaryloanBox.Text, out double saL) ? saL : 0;
                double otherLoan = double.TryParse(otherloanBox.Text, out double oL) ? oL : 0;

                

                // Net Income
                
                

                // Tax Contribution (simplified example)
                double taxContribution = 0;
                if (grossIncome > (25000.0 / 24))
                {
                    if (grossIncome <= 10416.67) taxContribution = 0;
                    else if (grossIncome <= 16666.67) taxContribution = ((((grossIncome * 24) - 250000) * 0.20) / 24);
                    else if (grossIncome <= 33333.33) taxContribution = ((((grossIncome * 24) - 400000) * 0.25 + 30000) / 24);
                    else if (grossIncome <= 83333.33) taxContribution = ((((grossIncome * 24) - 800000) * 0.30 + 82500) / 24);
                    else if (grossIncome <= 208333.33) taxContribution = ((((grossIncome * 24) - 2000000) * 0.32 + 245500) / 24);
                    else taxContribution = ((((grossIncome * 24) - 8000000) * 0.35 + 1254500) / 24);
                }
                taxcontribBox.Text = taxContribution.ToString("F2");

                double totalDeductions = sssContribution + philHealthContribution + pagibigContribution + sssLoan + pagibigLoan + facultySavings + facultyLoan + salaryLoan + otherLoan + taxContribution;
                
                totaldeductionBox.Text = totalDeductions.ToString("F2");
                double netIncome = grossIncome - totalDeductions;
                netIncome = grossIncome - totalDeductions;
                netIncomeBox.Text = netIncome.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating gross income and contributions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function to clear all input fields and reset selections
        public static void ClearAll(TextBox[] textboxes, ComboBox comboBox, ListBox lisBox, PictureBox pictureBox)
        {
            foreach (var tb in textboxes)
            {
                tb.Clear();
            }
            comboBox.Text = "Select";
            lisBox.Items.Clear();
            pictureBox.Image = null;
        }
        // Function to generate payslip preview in a ListBox
        public static void PayslipPreview(ListBox listbox, TextBox[] textboxes, DateTimePicker payDate)
        {
            try
            {
                listbox.Items.Clear(); // clear previous items

                // Basic Employee Info (assuming order in array: employee number, first name, middle, surname, designation, status, department)
                listbox.Items.Add("Employee Number: " + textboxes[0].Text);
                listbox.Items.Add("First Name: " + textboxes[1].Text);
                listbox.Items.Add("Middle Name: " + textboxes[2].Text);
                listbox.Items.Add("Surname: " + textboxes[3].Text);
                listbox.Items.Add("Designation: " + textboxes[4].Text);
                listbox.Items.Add("Employee Status: " + textboxes[5].Text);
                listbox.Items.Add("Department: " + textboxes[6].Text);
                listbox.Items.Add("Pay Date: " + payDate.Text);
                listbox.Items.Add("---------------------------------------------------------------------");

                // Basic Pay (assuming order in array: no of hours, rate per hour, income)
                listbox.Items.Add("Basic Pay No. of Hours: " + textboxes[7].Text);
                listbox.Items.Add("Basic Pay Rate per Hour: " + textboxes[8].Text);
                listbox.Items.Add("Basic Pay Income: " + textboxes[9].Text);
                listbox.Items.Add("---------------------------------------------------------------------");

                // Honorarium Pay
                listbox.Items.Add("Honorarium Pay No. of Hours: " + textboxes[10].Text);
                listbox.Items.Add("Honorarium Pay Rate per Hour: " + textboxes[11].Text);
                listbox.Items.Add("Honorarium Pay Income: " + textboxes[12].Text);
                listbox.Items.Add("---------------------------------------------------------------------");

                // Other Income
                listbox.Items.Add("Other Income No. of Hours: " + textboxes[13].Text);
                listbox.Items.Add("Other Income Rate per Hour: " + textboxes[14].Text);
                listbox.Items.Add("Other Income: " + textboxes[15].Text);
                listbox.Items.Add("---------------------------------------------------------------------");

                // Contributions (SSS, Pag-IBIG, PhilHealth, Tax)
                listbox.Items.Add("SSS Contribution: " + textboxes[16].Text);
                listbox.Items.Add("Pag-IBIG Contribution: " + textboxes[17].Text);
                listbox.Items.Add("PhilHealth Contribution: " + textboxes[18].Text);
                listbox.Items.Add("Tax Contribution: " + textboxes[19].Text);

                // Loans
                listbox.Items.Add("SSS Loan: " + textboxes[20].Text);
                listbox.Items.Add("Pag-IBIG Loan: " + textboxes[21].Text);
                listbox.Items.Add("Faculty Savings Deposit: " + textboxes[22].Text);
                listbox.Items.Add("Faculty Savings Loan: " + textboxes[23].Text);
                listbox.Items.Add("Salary Loan: " + textboxes[24].Text);
                listbox.Items.Add("Other Loan: " + textboxes[25].Text);
                listbox.Items.Add("---------------------------------------------------------------------");

                // Totals
                listbox.Items.Add("Total Deduction: " + textboxes[26].Text);
                listbox.Items.Add("Gross Income: " + textboxes[27].Text);
                listbox.Items.Add("Net Income: " + textboxes[28].Text);
                listbox.Items.Add("---------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in PayslipPreview: " + ex.Message);
            }
        }
        // Function to print the payslip from the ListBox
        public static void PrintPayslip(ListBox listbox)
        {
            try
            {
                Lesson3Example5_PrintForm printForm = new Lesson3Example5_PrintForm();
                printForm.listbox_payslipview.Items.AddRange(listbox.Items);
                printForm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in PrintPayslip: " + ex.Message);
            }


        }
        // Function to browse and load an image into a PictureBox
        public static void BrowseImage(PictureBox pictureBox)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an Image";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BrowseImage: " + ex.Message);
            }
        }
    }
}
