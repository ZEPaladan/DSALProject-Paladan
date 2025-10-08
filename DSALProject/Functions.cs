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

        public static void FoodBundlesDisplay(string bundleName, Color bgColor, PictureBox pictureBox, Image bundleImage, TextBox priceBox, TextBox discountBox,
            TextBox quantityBox, RadioButton bundleRadioButton, 
            CheckBox check1, CheckBox check2, CheckBox check3, CheckBox check4, CheckBox check5, // group to check
            CheckBox uncheck1, CheckBox uncheck2, CheckBox uncheck3, CheckBox uncheck4, CheckBox uncheck5) // group to uncheck
        {
            pictureBox.Image = bundleImage;

            pictureBox.BackColor = bgColor;

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
                Variables.Current.item_name = "Food Bundle A";
                priceBox.Text = "1,000.00";
                discountBox.Text = "100.00";
            }
            else if (bundleName == "B")
            {
                Variables.Current.item_name = "Food Bundle B";
                priceBox.Text = "1,299.00";
                discountBox.Text = "194.85";
            }


            quantityBox.Focus();
            
        }

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

}
