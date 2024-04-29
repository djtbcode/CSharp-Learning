using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 23;
            Console.WriteLine(age);
            
            // long bigNumber = 9999999999999999999L;
            var bigNumber = 9999999999999999L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.00001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "David";
            Console.WriteLine(name);

            var ch = 'd';
            Console.WriteLine(ch);

            Console.ReadLine();
        }
    }
}