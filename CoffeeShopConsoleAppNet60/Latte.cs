﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Latte : Coffee , IMilk
    {
        public Latte(int discount) : base(discount)
        {
        }

        public int MlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
