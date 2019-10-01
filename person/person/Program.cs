using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input First Name :");
            string fname = Console.ReadLine();
            Console.WriteLine("Input Last Name :");
            string lname = Console.ReadLine();

            SayName sayname = new SayName();
            sayname.fname = fname;
            sayname.lname = lname;
            sayname.ListName();

            Console.WriteLine("Input Employee ID :");
            string id = Console.ReadLine();
            Employee Idisplay = new Employee();
        }
    }
}
