using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        private int _discount;

        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Det er for meget rabat. Max 5,- ");
                }
                _discount = value;
            }
        }

        



        public virtual int Price() 
        {
            return 20;
        }

        public abstract string Strength();


    }
}
