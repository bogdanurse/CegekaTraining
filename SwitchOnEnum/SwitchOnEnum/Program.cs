using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOnEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;
            Console.WriteLine("Today's date is {0}", date);
            float value = date.Month;

            switch(value)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("It's Winter");
                    break;            
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It's Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It's Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It's Autumn");
                    break;
               
            }
        }
    }
}
