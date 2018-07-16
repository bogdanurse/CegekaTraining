using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For02
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<20;i++)
            {
                for(int j=20;j<40;j++)
                {
                    int result = i * j;
                    Console.WriteLine("The results are : {0}", result);
                }
            }
        }
    }
}
