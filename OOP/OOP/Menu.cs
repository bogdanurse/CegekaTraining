using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Menu
    {
        private List<MenuItem> mListMeniu;
        public List<MenuItem> listaMeniu
        {
            get
            {
                return mListMeniu;
            }
        }


        public Menu()
        {
            mListMeniu = new List<MenuItem>(new MenuItem[] 
            {   new Beverage("Expresso", "Small", 2),
                new Beverage("Expresso", "Medium", 3),
                new Beverage("Expresso", "Large", 4),
                new Beverage("Capuccino", "Small", 2.99),
                new Beverage("Capuccino", "Medium", 3.99),
                new Beverage("Capuccino", "Large", 4.99),
                new Beverage("House coffee", "Small", 1.25),
                new Beverage("House coffee", "Medium", 2.25),
                new Beverage("House coffee", "Large", 3.25),
                new Snack("Muffin", 1.50),
                new Snack("Bagel", 1.95),
                new Snack("Croissant", 2.95)
        });

        }

    }
}
