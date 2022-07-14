/*
 * Generate numbers 1-50 and output Fizz for multiples of 3, Buzz for Multiples of 5, and FizzBuzz for multiples of both 3 and 5. Output numbers for everything else
 *
 */

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadKey();
			for (int i = 1; i <=50;i++)
			{
				//bool buzzWord = false;
				if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
					//buzzWord = true;
				}
				if (i % 5 == 0)
                {
					Console.WriteLine("Buzz");
					//buzzWord= true;
				}
				if	(i % 3 == 0 && i % 5 == 0)
                {
					Console.WriteLine("FizzBuzz");
					//buzzWord=(true);
				}
				//if (buzzWord == false)
				else	
                {
					Console.WriteLine(i);
                }
			}

			Console.ReadKey();
		}
	}
}
