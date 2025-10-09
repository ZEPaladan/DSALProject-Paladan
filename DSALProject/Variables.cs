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
    public class POS2_ItemsAndPrices
    {
        public static Dictionary<int, (string ItemName, double Price, double Discount)> ItemsAndPrices = new Dictionary<int, (string, double, double)>()
        {
            { 11, ("Margherita", 280, 0) },
            { 12, ("Pepperoni", 320, 0) },
            { 13, ("Hawaiian", 350, 0) },
            { 14, ("BBQ Chicken", 380, 0) },
            { 15, ("Meat Lovers", 420, 0) },
            { 16, ("Veggie", 480, 0) },
            { 17, ("Four Cheese", 390, 0) },
            { 18, ("Supreme", 450, 0) },
            { 19, ("Buffalo Chicken", 400, 0) },
            { 20, ("Seafood Pizza", 330, 0) },
            { 21, ("Spinach and Feta", 520, 0) },
            { 22, ("Mushroom Truffle", 300, 0) },
            { 23, ("Breakfast Pizza", 400, 0) },
            { 24, ("Cheeseburger", 450, 0) },
            { 25, ("White Pizza", 360, 0) },
            { 26, ("Sicilian", 340, 0) },
            { 27, ("Detroit Style", 380, 0) },
            { 28, ("Neapolitan", 360, 0) },
            { 29, ("Calzone", 500, 0) },
            { 30, ("Chicago Deep Dish", 370, 0) }
        };
    }
    public class Payroll_Variables
    {
        public static Payroll_Variables Current = new Payroll_Variables();

        public double gross_income;
        public double net_income;

        public double sss_contribution;
        public double philhealth_contribution;
        public double pagibig_contribution;
        public double tax_contribution;

        public double sss_loan;
        public double pagibig_loan;
        public double faculty_savings_deposit;
        public double faculty_savings_loan;
        public double salary_loan;
        public double other_loans;

        public double total_deductions;
    }

}