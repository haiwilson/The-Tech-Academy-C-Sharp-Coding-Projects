using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Employee : SayName 
    {
        public string id { get; set; }
        public void Idisplay()
        {
            Console.WriteLine("Employee ID is :" + id);
            Console.ReadLine();
        }
    }
}
