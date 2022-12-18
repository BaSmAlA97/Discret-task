using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
    
               
        static void Main(string[] args)
        {
            int i, y, sum = 0;
            int num1=int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            for ( i = num1; i <=num2; i++)
            {
                
                for( y=1; y <= i /2; y++) 
                { 
                    if(i%y==0)
                    {
                      
                            sum = sum + y;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i + "is perfect");
                }
                sum = 0;
            }
           
            Console.ReadKey();
        }
    }
}
