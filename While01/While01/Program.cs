using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Please add a number : ");
            int value = int.Parse(Console.ReadLine());
            while(i<=value)
            {
                Console.WriteLine("The value is {0}\n",i);
                i++;
                //if we don't increment the i, we will have an infinite loop showing 0 
            }

        }
    }
}
