/*
 * This Program will generate 10 random real numbers, one at a time, between 0 and 200
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

			//Generate a random number between 0-200
			int s = r.Next(200);
			randomNumber = s;
			
			//Output single random number generated this is to verify I am generating the number correctly
			//Console.WriteLine("Generate a random number between 0 and 200, press a key");
			//Console.ReadKey();
			//Console.WriteLine();
			//Console.WriteLine(randomNumber);
			//Console.WriteLine();
			Console.WriteLine("Generate 10 random numbers between 0 and 200, press a key");
			Console.ReadKey();
			Console.WriteLine();

			//Output 10 random numbers one at a time
			int i = 0;
			while (i < 10)
			{
				int t = r.Next(200);
				randomNumber = t;
				Console.WriteLine(randomNumber);
				i++;
			}
			Console.ReadKey();
		}
	}
}
