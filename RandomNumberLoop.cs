/*
 * This Program will generate 10 random real numbers, one at a time, between 0 and 200 and then will display only the numbers that are greater than 100 and divisible by 2
 *
 */

namespace RandomNumberLoop
{
	class Program
	{
		static void Main(string[] args)
		{

			//Random number variable and object
			double randomNumber;
			Random r = new Random();

			//Generate a random number between 0-200 and display the numbers greater than 100 and divisible by 2
			Console.WriteLine("This program will generate 10 random numbers between 0-200 and display all even numbers that are greater than 100");
			Console.ReadKey();
			Console.WriteLine();
			int i = 0;
			while (i < 10)
			{
				int s = r.Next(200);
				randomNumber = s;
				if (randomNumber > 100 && randomNumber % 2 == 0)
				{
					Console.WriteLine(randomNumber);
				}
				i++;
			}
			Console.ReadKey();
		}
	}
}
