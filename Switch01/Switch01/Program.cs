using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a name : ");
            var name = Console.ReadLine().ToLower();
      
            switch (name)
            {
                case "alex":
                    Console.WriteLine("Alex likes skiing");
                    break;
                case "bogdan":
                    Console.WriteLine("Bogdan likes football");
                    break;
                case "marcel":
                    Console.WriteLine("Marcel likes handball");
                    break;
                  default:
                    Console.WriteLine("I don't know anything about {0}",name);
                    break;
            }
        }
    }
}
