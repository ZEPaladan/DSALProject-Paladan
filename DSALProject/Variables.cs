using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALProject
{
    public class Variables
    {
        public static Variables Current = new Variables();

        public string item_name;
        public double price;
        public int quantity;
        public int total_quantity;
        public double discount;
        public double discounted_amount;
        public double total_discount_given;
        public double total_discounted_amount;
        public double cash_rendered;
        public double change;
    }
    public class POS1_ItemsAndPrices
    {
        public static Dictionary<int, (string ItemName, double Price)> ItemsAndPrices = new Dictionary<int, (string, double)>()
        {
            { 1, ("1-entree Lauriat", 200.00) },
            { 2, ("2-entree Lauriat", 200.00) },
            { 3, ("Beef Broccoli Lauriat", 220.00) },
            { 4, ("Beef Broccoli", 170.00) },
            { 5, ("Beef Wonton", 170.00) },
            { 6, ("Halo-halo Supreme", 120.00) },
            { 7, ("Chicken Mami", 150.00) },
            { 8, ("Bundle Feast 2", 570.00) },
            { 9, ("Bundle Feast 1", 570.00) },
            { 10, ("Buchi Dim Sum", 180.00) },
            { 11, ("Salt and Pepper Pork", 170.00) },
            { 12, ("Pancit Canton", 220.00) },
            { 13, ("Lumpiang Shanghai", 200.00) },
            { 14, ("Longanisa Breakfast", 150.00) },
            { 15, ("Honey Walnut Shrimp", 150.00) },
            { 16, ("Wonton Noodle Soup", 230.00) },
            { 17, ("Tocino Breakfast", 150.00) },
            { 18, ("Popcorn Chicken", 220.00) },
            { 19, ("Taho", 50.00) },
            { 20, ("Siomai Chao Fan", 150.00) }
         };
    
    }
    public class Variables2
    {
       
    }

}