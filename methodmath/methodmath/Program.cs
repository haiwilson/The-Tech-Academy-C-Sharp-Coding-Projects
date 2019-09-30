using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodmath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input value of Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Div a = new Div();
            double x = a.DivByTwo(y);
           
            Console.WriteLine("Value of input Y divided by 2 is =  " + x);
            Console.ReadLine();

        }
    }
}
