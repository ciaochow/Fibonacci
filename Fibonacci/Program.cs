using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Fibonacci Numbers -----");
            Console.WriteLine();
            Console.Write("Please enter the nth term that you want me to compute up to: ");
            string input = Console.ReadLine();
            int parsedinput = int.Parse(input);
            Console.WriteLine();
            Console.WriteLine("The {0} Fibonacci terms are: ", parsedinput);
            
            int a = 0;
            int b = 1;
            for (int i = 0; i < parsedinput; i++)
            {
                int tempnumber = a;
                a = b;
                b = tempnumber + b;
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
