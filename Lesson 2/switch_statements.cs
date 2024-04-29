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

            Console.Write("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.Write("Mon");

            }
            else if (day == 2)
            {
                Console.Write("Tues")
            }
            else 
            {
                Console.WriteLine("Invalid Please enter a value between 1 & 7");
            }

            switch (day)
            {
                case 1: Console.Write("Mon");
                    break;
                case 2: Console.Write("Tue");
                    break;
                case 3: Console.Write("Wed");
                    break;
                default: Console.WriteLine("Invalid Please enter a value between 1 & 7");
                    break ;
            }


            Console.ReadLine();
        }
    }
}