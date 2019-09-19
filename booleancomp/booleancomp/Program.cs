using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleancomp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            } while (i < 10);
            Console.ReadLine();

            int j = 0;

            while (j < 10)
            {
                Console.WriteLine("Value of j: {0}", j);

                j++;
            }
            Console.ReadLine();
        }
    }
}
