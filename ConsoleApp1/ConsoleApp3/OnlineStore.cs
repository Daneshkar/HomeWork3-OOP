using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class OnlineStore
    {
        private List<Product> products = new List<Product>();
        private List<IDiscountable> discountableProducts = new List<IDiscountable>();

        public void AddProduct(Product product)
        {
            products.Add(product);

            if (product is IDiscountable discountable)
            {
                discountableProducts.Add(discountable);
            }

            Console.WriteLine($"Product '{product.Name}' added to store.");
        }

        public void DisplayAllProducts()
        {
            Console.WriteLine("\n=== All Products in Store ===");
            foreach (var product in products)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
        }

        public void ApplyDiscountToAll(double percentage)
        {
            Console.WriteLine($"\nApplying {percentage}% discount to all discountable products:");
            foreach (var product in discountableProducts)
            {
                product.ApplyDiscount(percentage);
            }
        }

        public void ApplyDiscountToProduct(string productName, double percentage)
        {
            var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null && product is IDiscountable discountable)
            {
                discountable.ApplyDiscount(percentage);
            }
            else if (product != null)
            {
                Console.WriteLine($"Product '{productName}' does not support discounts.");
            }
            else
            {
                Console.WriteLine($"Product '{productName}' not found.");
            }
        }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var product in products)
            {
                if (product is IDiscountable discountable)
                {
                    total += discountable.GetDiscountedPrice();
                }
                else
                {
                    var priceProperty = product.GetType().GetProperty("Price");
                    if (priceProperty != null)
                    {
                        total += (double)priceProperty.GetValue(product);
                    }
                }
            }
            return total;
        }

        public void SearchProducts(string keyword)
        {
            Console.WriteLine($"\n=== Search Results for '{keyword}' ===");
            bool found = false;

            foreach (var product in products)
            {
                if (product.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    product.GetProductDetails().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    product.DisplayInfo();
                    Console.WriteLine();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No products found.");
            }
        }
    }
}
