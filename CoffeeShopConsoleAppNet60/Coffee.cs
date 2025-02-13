using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal abstract class Coffee
    {
        protected Coffee(int discount)
        {
            Discount = discount;
        }

        public int Discount { get; set; }



        public virtual int Price() 
        {
            return 20;
        }

        public abstract string Strength();


    }
}
