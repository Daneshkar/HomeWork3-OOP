using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Electronic : Product, IDiscountable
    {
        public int WarrantyPeriod { get; set; } 
        private bool discountApplied = false;
        private double originalPrice;

        public Electronic(string name, double price, int warrantyPeriod)
            : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
            originalPrice = price;
        }

        public void ApplyDiscount(double percentage)
        {
            if (!discountApplied)
            {
                originalPrice = Price; 
                ApplyPriceDiscount(percentage);
                discountApplied = true;
                Console.WriteLine($"Discount of {percentage}% applied to {Name}");
            }
            else
            {
                Console.WriteLine($"Discount already applied to {Name}");
            }
        }

        public double GetDiscountedPrice()
        {
            return Price;
        }

        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $", Type: Electronic, Warranty: {WarrantyPeriod} months";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Electronic Product ===");
            Console.WriteLine(GetProductDetails());
            if (Price < originalPrice)
            {
                Console.WriteLine($"Discounted Price: {Price:C} (Original: {originalPrice:C})");
            }
        }
    }
}
