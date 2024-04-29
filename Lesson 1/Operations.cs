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
            int age = 23;
            age++;
            //same operations
            age = age + 1;
            age += 1;
            Console.WriteLine(age);
            age--;
            age -= 1;

            Console.WriteLine(age);

            age = 23;
            age /= 10; //2.3 -> 2 truncates decimal
            Console.WriteLine(age);

            double doubleAge = 23; //create double to preserve 
            doubleAge /= 10;
            Console.WriteLine(doubleAge);

            string name = "David";
            name += " is programing";
            // name -= " is programing" does not work.
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);//will produce odd results accented A due to unicode addition
            
            int i = 0;
            i++;
            Console.WriteLine(i);
            Console.WriteLine(++i);//will run before print givng i = 2
            Console.WriteLine(i++);//will run after print console show i = 2 but then i = 3 will apply

            Console.ReadLine();
        }
    }
}