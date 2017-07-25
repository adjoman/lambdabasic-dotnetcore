using System;
using System.Linq;

namespace LinqBasicDotNetCore
{
    public class Start
    {
        static void Main(string[] args)
        {
			// Language Integrated Query Example (LINQ)
			Console.WriteLine("Demonstrating Basic Linq");

			int[] listOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// get all even numbers
			var result = from number in listOfNumbers
						 where (number % 2) == 0
						 select number;

			foreach (var r in result)
			{
				Console.WriteLine(r.ToString());
			}

			Console.ReadLine();
        }

    }
}
