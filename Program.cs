using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z = 0;

            for (x = 2; x <= 100; x++)
            {
                for (y = 2; y <= sqrt(x); y++)
                {
                    if (x % y == 0)
                    {
                        z = 0;
                    }
                    if (z == 1 && x != 1)
                    {
                        Console.WriteLine(x + "is prime");
                    }
                    z = 1;
                }

               
            }
            Console.ReadKey();


        }
        static int sqrt(int x) 
        {
            return 0;
        }
    }
}
