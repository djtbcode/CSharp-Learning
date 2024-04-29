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
            string name = "David";
            //int number = 0154635658; This would lose the 0 from the start 
            string number = "0154635658";
            int age = 22;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}