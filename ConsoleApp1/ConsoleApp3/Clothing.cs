using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Clothing : Product
    {
        public string Material { get; set; }
        public string Size { get; set; }

        public Clothing(string name, double price, string material, string size)
            : base(name, price)
        {
            Material = material;
            Size = size;
        }

        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $", Type: Clothing, Material: {Material}, Size: {Size}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Clothing Product ===");
            Console.WriteLine(GetProductDetails());
        }
    }
}
