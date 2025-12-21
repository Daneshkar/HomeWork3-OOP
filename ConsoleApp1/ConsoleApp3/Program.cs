namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineStore store = new OnlineStore();

            Electronic laptop = new Electronic("Laptop", 1200.00, 24);
            Electronic smartphone = new Electronic("Smartphone", 800.00, 12);
            Electronic headphones = new Electronic("Wireless Headphones", 150.00, 6);

            Clothing tshirt = new Clothing("T-Shirt", 25.00, "Cotton", "M");
            Clothing jeans = new Clothing("Jeans", 60.00, "Cotton", "L");
            Clothing jacket = new Clothing("Jacket", 120.00, "Cotton", "XL");

            Console.WriteLine("=== Adding Products to Store ===");
            store.AddProduct(laptop);
            store.AddProduct(smartphone);
            store.AddProduct(headphones);
            store.AddProduct(tshirt);
            store.AddProduct(jeans);
            store.AddProduct(jacket);
            store.DisplayAllProducts();

            Console.WriteLine("\n=== Applying Discount to Specific Product ===");
            store.ApplyDiscountToProduct("Laptop", 15);

            store.ApplyDiscountToAll(10);

            Console.WriteLine("\n=== Products After Discount ===");
            laptop.DisplayInfo();
            Console.WriteLine();
            smartphone.DisplayInfo();
            Console.WriteLine();
            tshirt.DisplayInfo();

            Console.WriteLine($"\n=== Total Price of All Products ===");
            Console.WriteLine($"Total: {store.CalculateTotalPrice():C}");

            Console.WriteLine("\n=== Product Search ===");
            store.SearchProducts("phone");
            store.SearchProducts("shirt");

            Console.WriteLine("\n=== Polymorphism Example ===");
            Product[] productArray = { laptop, tshirt, smartphone, jeans };

            foreach (var product in productArray)
            {
                Console.WriteLine($"Product Type: {product.GetType().Name}");
                Console.WriteLine($"Details: {product.GetProductDetails()}");

                if (product is IDiscountable)
                {
                    Console.WriteLine("This product is discountable.");
                }
                else
                {
                    Console.WriteLine("This product is not discountable.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n=== Direct Interface Usage ===");
            List<IDiscountable> discountItems = new List<IDiscountable> { laptop, smartphone, headphones };

            foreach (var item in discountItems)
            {
                Console.WriteLine($"Original Price: {item.GetDiscountedPrice():C}");
                item.ApplyDiscount(5);
                Console.WriteLine($"New Price: {item.GetDiscountedPrice():C}");
                Console.WriteLine();
            }
        }
    }
}
