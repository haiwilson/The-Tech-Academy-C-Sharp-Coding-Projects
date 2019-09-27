using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value of y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Math a = new Math();
            int add = a.AddTwoValues(x, y);
            int sub = a.SubTwoValues(x, y);
            int mul = a.MulTwoValues(x, y);

            Console.WriteLine("X + Y = " + add);
            Console.WriteLine("X - Y = " + sub);
            Console.WriteLine("X * Y = " + mul);
            Console.ReadLine();
        }
    }
}
