using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Wilson";
            string str = "Hello " + userName + "." + "Hope you have a good day!" + ".";
            Console.WriteLine(str);
            Console.ReadLine();

            string str2 = "Today is a good day";
            string upper2 = str2.ToUpper();
            Console.WriteLine(upper2);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Wilson. ");
            sb.Append("Today is a good day, ");
            sb.Append("Hope you're having fun! ");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
