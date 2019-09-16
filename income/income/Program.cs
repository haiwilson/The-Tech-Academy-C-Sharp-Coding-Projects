using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace income
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Anonymous Income Comparison Program");
			Console.WriteLine("Person 1");
			Console.WriteLine("What is the hourly rate?");
			int personSal1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Hours worked per week?");
			int personHrs1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Person 2");
			Console.WriteLine("What is the hourly rate?");
			int personSal2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Hours worked per week?");
			int personHrs2 = Convert.ToInt32(Console.ReadLine());

			int weeklySal1 = personSal1 * personHrs1;
			Console.WriteLine("Weekly salary of Person 1:" + weeklySal1.ToString());
			Console.ReadLine();

			int weeklySal2 = personSal2 * personHrs2;
			Console.WriteLine("Weekly salary of Person 2:" + weeklySal2.ToString());
			Console.ReadLine();
		}
	}
}
