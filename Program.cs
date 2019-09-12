using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcs
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The Tech Academy");
			Console.WriteLine("Student Daily Report");
			Console.WriteLine("What Course are you on?");
			int courseNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("What Page Number?");
			float pageNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Do you need help with anything? Please say Yes/No");
			string helpAnswer = Console.ReadLine();
			Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
			string posExperience = Console.ReadLine();
			Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
			string proFeedback = Console.ReadLine();
			Console.WriteLine("How many hours did you study today?");
			decimal studyHours = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
			Console.ReadLine();
			Console.WriteLine("You are on Course Number " + courseNumber + "  and one Page Number " + pageNumber + "  and you studied for " + studyHours + " hours");
			Console.ReadLine();
		}
	}
}
