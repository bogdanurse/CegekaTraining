using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Your age is : ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your sex is : male/female ");
            var sex = Console.ReadLine();

            if ((sex == "male") && (age == 24))
            {
                Console.WriteLine("Valid person");
            }
            else if ((sex == "female") && (age >20) && (age <32))
            {
                Console.WriteLine("Valid person");
            }
            else
            {
                Console.WriteLine("Invalid person");
            }
        }
    }
}
