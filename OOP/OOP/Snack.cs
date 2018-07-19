using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Snack : MenuItem
    {

        private double mPrice;
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if (value != mPrice)
                    mPrice = value;
            }
        }

        public Snack(string name,double price) : base(name)
        {
            mPrice = price;
        }

        public override void PrintToScreen()
        {
            Console.WriteLine(this.Name + " -- Price : "+ this.Price);
        }
    }
}
