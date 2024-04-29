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

            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.Write("How many times do you want to repeat?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, Please enter a valie above 0.");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }
            



            /*for (int i = 0;i <= 10; i++) 
            {
                Console.WriteLine(i);
            }
            */


            Console.ReadLine();
        }
    }
}