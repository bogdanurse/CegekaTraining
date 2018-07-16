using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break01
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                
                Console.WriteLine("Insert a number : ");
                var readNumber = int.Parse(Console.ReadLine());
                sum += readNumber;
                if (sum > 100)
                {
                    Console.WriteLine("The sum is over 100");
                    break;
                }

            }
        }
    }
}
