using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class BlackCoffee : Coffee
    {
        //public BlackCoffee(int discount) : base(discount)
        //{
        //}

        public override string Strength()
        {
            return "Strong";
        }
    }
}
