using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If02
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Name of a fruit : ");
            var fruitname =Console.ReadLine().ToLower();
        
            if (fruitname == "apple")
            {
                Console.WriteLine("The color of the Apple is : ");
                var fruitcolor = Console.ReadLine().ToLower();
                if (fruitcolor == "green")
                {
                    Console.WriteLine("Green apples are my favourite.");
                }
                else
                if (fruitcolor == "red")
                {
                    Console.WriteLine("Snow White likes red apples");
                }
                else
                {
                    Console.WriteLine("I do not know such kinds of apples");
                }
            }
            else
            if (fruitname == "orange")
            {
                Console.WriteLine("The orange is swwet or sour ?");
                var fruitcondition = Console.ReadLine().ToLower();
                if (fruitcondition == "sweet")
                {
                    Console.WriteLine("Sweet oranges are the best.");
                }
                else
                if (fruitcondition == "sour")
                {
                    Console.WriteLine("The orange is big or small ?");
                    var fruitsize = Console.ReadLine().ToLower();
                    if (fruitsize == "big")
                    {
                        Console.WriteLine("Congrats! You have a big sour orange!");
                    }
                    else
                       if (fruitsize == "small")
                    {
                        Console.WriteLine("Maybe you have a lime instead of an Orange.");
                    }
                }
            } else
            {
                Console.WriteLine("{0} is not on our list. I like apples and oranges.", fruitname);
            }

            Console.ReadKey();
        }
    }
}

