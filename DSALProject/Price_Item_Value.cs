using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALProject
{
    internal class Price_Item_Value
    {
        public string price;
        public string itemname;
        public string discount_amount;

        // Codes for setting the value of the Item name and item price
        public void SetPriceItemValue(string item_name, string item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }

        // Codes for getting the value of an item
        public string GetItemName()
        {
            return itemname;
        }

        // Codes for getting the value of a price
        public string GetPrice()
        {
            return price;
        }

        // Codes for setting the value of the discount amount and item price
        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amt;
        }

        // Codes for getting the value of a price
        public string GetPriceItem()
        {
            return price;
        }

        // Codes for getting the value of a discount amount
        public string GetDiscountAmount()
        {
            return discount_amount;
        }
    }
}
