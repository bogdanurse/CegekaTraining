using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
	class Program
	{
		static void Main(string[] args)
		{
			int kilometers = 10;
			double time = 1.5;
			bool truth = true;
			string name = "Gigi";
			string name1 = "Mike";

			string result = CreateOutput(kilometers, time, truth, name);
			Console.WriteLine(result);

			string result1 = CreateOutput(kilometers, time, truth, name1);
			Console.WriteLine(result1);


			//Console.WriteLine("{0} has ran {1} in {2} hours. It is {3} that he's a family man." +
			//	"He takes his brother out for a drink at a bar called {4}'s Han. " +
			//	"He and his wife are going to have a son. His name will be {5}, just like his father's. " +
			//	"{6} dreams to get a diploma from his son saying '{7}, father of the year'.", name, kilometers, time, truth, name, name, name, name);

			//Console.WriteLine("{0} has ran {1} in {2} hours. It is {3} that he's a family man." +
			//	"He takes his brother out for a drink at a bar called {4}'s Han. " +
			//	"He and his wife are going to have a son. His name will be {5}, just like his father's. " +
			//	"{6} dreams to get a diploma from his son saying '{7}, father of the year'.", name1, kilometers, time, truth, name1, name1, name1, name1);

		}
		

		public static string CreateOutput(int km, double t, bool trut, string name)
		{
			string output;
			output = name + " has ran " + km + " kilometers in " + t + " hours. It is " + trut + " that he's a family man." +
				" He takes his brother out for a drink at a bar called " + name + "s Han. He and his wife are going to have a son. His name will be " + name + ", just like his father's. " +
				name + " dreams to get a diploma from his son saying '" + name + ", father of the year'.\n";
			return output;
		}
	}
}
