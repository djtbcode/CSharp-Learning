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

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }*/

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            Console.WriteLine();
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            nt actualAnswer = 0;

            Console.Write("What's the Value of " + numberA + " x " + numberB + ":");
            Console.WriteLine();
            //example of while loop
            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (actualAnswer != answer)
                {            
                    Console.WriteLine("Close but wrong!");
                    Console.WriteLine();
                }
            }
            
            // same result with do while loop
            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (actualAnswer != answer)
                {
                    Console.WriteLine("Close but wrong!");
                    Console.WriteLine();
                }

            } while (answer != actualAnswer);


            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}