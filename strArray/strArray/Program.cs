using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input some texts");
            string[] array = { Console.ReadLine() };

            Console.WriteLine("input index to display");
            int i = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < array.Length; i++)

            {
                Console.WriteLine(array[i]);
                Console.ReadLine();
            }

            for (i = 0; i <= array.Length; i++)

            {
                Console.WriteLine(array[i]);
                Console.ReadLine();
            }

            List<string> names = new List<string>();
            names.Add("jesse");
            names.Add("ria");
            names.Add("prave");
            names.Add("wilson");

            Console.WriteLine("input name to check");
            string namecheck = Console.ReadLine();

            List<string> namesrep = new List<string>();

            foreach (string nam in names)
            {
                {
                if (nam == namecheck)
                    Console.WriteLine("name found");
                    Console.ReadLine();

                    namesrep.Add(nam);

                }
                if (nam != namecheck)
                    Console.WriteLine("name not found");
                    Console.ReadLine(); 
            }
            Console.WriteLine("number of repetitions" + namesrep.Count);
            Console.ReadLine();

        }
    }
}
