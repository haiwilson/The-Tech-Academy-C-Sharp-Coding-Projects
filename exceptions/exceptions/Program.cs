using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>();
                intList.Add(10);
                intList.Add(20);
                intList.Add(30);
                intList.Add(40);
                intList.Add(50);

                Console.WriteLine("Input a number to divide the list elements");
                int inp = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < intList.Count; i++)
                {
                    int div = intList[i] / inp;
                    Console.WriteLine("the output is " + div);
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter whole number");
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please enter a non-zero number");
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }
        
    }
}
