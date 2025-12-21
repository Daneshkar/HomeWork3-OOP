using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string GetProductDetails()
        {
            return $"Name: {Name}, Base Price: {Price:C}";
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine(GetProductDetails());
        }

         protected void ApplyPriceDiscount(double percentage)
        {
            if (percentage > 0 && percentage <= 100)
            {
                Price -= Price * (percentage / 100);
            }
        }
    }
}
