using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Beverage : MenuItem
    {
        private string mSize;
        private double mPrice;
        public string Size
        {
            get
            {
                return mSize;
            }
            set
            {
                if (value != mSize)
                    mSize = value;
            }
        }
        
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
        
        public Beverage(string name,string size,double price) : base(name)
        {
            mSize = size;
            mPrice = price;
        }

        public override void PrintToScreen()
        {
          Console.WriteLine(Name + " - " + mSize + ": $" + mPrice);
        }
    }
}
