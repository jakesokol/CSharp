/*
 * NestedLoops
 *
 */

namespace NestedLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadKey();
			int row, column;
			for (row= 1; row <7; row++)
            {
				for (column= 0; column < row; column++)
                {
					Console.Write("* ");
                }
				Console.WriteLine();
            }
			Console.ReadKey();
		}
	}
}
