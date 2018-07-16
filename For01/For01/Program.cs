using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a positive number: ");
            int number = int.Parse(Console.ReadLine());
            if (number <0)
            {
                Console.WriteLine("You inserted a non positive number!!!!");
            }
            else
            {
                for (int i=0; i<=number;i+=2)
                {
                    if (i%2==0)
                    {
                        Console.WriteLine("The even numbers present on the inveral are :{0}", i);
                    }
                }

            }
        }
    }
}
