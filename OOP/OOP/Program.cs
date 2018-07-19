using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu meniu = new Menu();

            foreach(MenuItem m in meniu.listaMeniu)
            {
                m.PrintToScreen();
            }


        }
    }
}
