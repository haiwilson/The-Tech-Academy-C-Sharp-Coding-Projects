using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is package weight?");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if ( packWeight > 50 )
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
                {
                    Console.WriteLine("Please enter package width");
                    int packWidth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter package height");
                    int packHeight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter package length");
                    int packLength = Convert.ToInt32(Console.ReadLine());
                    int packDim = packWidth + packHeight + packLength;
                    if (packDim > 50)
                        {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        }
                    else
                        {
                        int total = (packDim * packWeight) / 100;
                        Console.WriteLine("Your estimated total for shipping this package is:  $" + total);
                        Console.WriteLine("Thank you");
                        }
                }
            Console.ReadLine();
        }
    }
}
