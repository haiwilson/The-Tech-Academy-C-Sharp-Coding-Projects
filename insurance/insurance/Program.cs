using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance program");
            Console.WriteLine("What is your age?");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had DUI?");
            bool input2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int input3 = Convert.ToInt32(Console.ReadLine());
            bool isQualified = (input1 > 15 && input2 == false && input3 < 4);
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
