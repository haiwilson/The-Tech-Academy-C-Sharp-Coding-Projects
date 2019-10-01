using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class SayName
    {
        public string fname { get; set; }
        public string lname { get; set; }
        
        public void ListName()
        {
          
            {
                Console.WriteLine("full name is :" + fname +" " + lname);
                Console.ReadLine();
            }
        }
    }
}
