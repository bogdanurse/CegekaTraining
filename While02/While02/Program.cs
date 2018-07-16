using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum =0;
            int number = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                sum = sum + number;

            } while (number != 0);

            Console.WriteLine("The sum is : {0}", sum);
        }
    }
}
