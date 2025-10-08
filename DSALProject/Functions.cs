using System;
using System.Collections.Generic;
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

    }
}
