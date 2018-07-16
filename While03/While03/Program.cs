using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.WriteLine("The number is {0}.", number);
            int insertednumber = 0;
            do
            {
                Console.WriteLine("Guess the number that is random generated.");
                insertednumber = int.Parse(Console.ReadLine());
                if (number > insertednumber)
                {
                    Console.WriteLine("It's bigger");
                } else
                if (number < insertednumber)
                {
                    Console.WriteLine("It's smaller");
                }

            } while (number != insertednumber);
            Console.WriteLine("Your guess is correct! Congrats!");
        }
    }
}
