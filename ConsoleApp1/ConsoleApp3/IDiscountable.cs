using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        double GetDiscountedPrice();
    }
}
