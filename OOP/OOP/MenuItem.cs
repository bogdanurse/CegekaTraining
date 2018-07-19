using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class MenuItem
    {
        public string Name { get; set; }
        public virtual void PrintToScreen()
        {
            Console.WriteLine("The Item on menu is : " + Name);
        }

        public MenuItem(string name)
        {
            this.Name = name;
        }
        public MenuItem()
        {

        }
    }
}
