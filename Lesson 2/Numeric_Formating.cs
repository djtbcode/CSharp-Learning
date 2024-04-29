using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            //reduce decimial places
            Console.WriteLine(string.Format("{0} {1}", value, 1000D));

            //value to two decimal places            
            Console.WriteLine(string.Format("{0:0.00}", value));
            
            //value to one decimal place
            Console.WriteLine(string.Format("{0:0.0}", value));

            // underlying variable value preserved
            Console.WriteLine(value);

            //eliminates trailing 0s
            Console.WriteLine(string.Format("{0:0.#}", value));

            double money = 10D / 3D; //3.33333333
            Console.WriteLine(money);
            
            //Display pounds
            Console.WriteLine(string.Format("£{0:0.00}", money));

            //puts correct currency sign based on location data. avoids issue with negative numbers
            Console.WriteLine(money.ToString("C"));
            //no decimal place
            Console.WriteLine(money.ToString("C0"));
            //one decimal place
            Console.WriteLine(money.ToString("C1"));
            //two decimal places
            Console.WriteLine(money.ToString("C2"));
            
            //set currency
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            
            Console.WriteLine(money.ToString("C", 
                CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", 
                CultureInfo.CreateSpecificCulture("en-US")));     
                                   
            Console.ReadLine();
        }
    }
}
