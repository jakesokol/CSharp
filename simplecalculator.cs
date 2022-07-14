/*
 * This program is a simple calculator that allows the following operators +,-,*,/,^
 *
 */

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit;
            int secondDigit;
            string mathOperator;
            int result;
            result = 0;

            Console.Write("Enter the first digit: ");
            firstDigit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second digit: ");
            secondDigit = Convert.ToInt32(Console.ReadLine());

		   calculator:
                Console.Write("Enter the operator: ");
                mathOperator = Console.ReadLine();

            if (mathOperator == "+")
            {
                result = firstDigit + secondDigit;
            }
            else if (mathOperator == "-")
            {
                result = firstDigit - secondDigit;
            }
            else if (mathOperator == "*")
            {
                result = firstDigit * secondDigit;
            }
            else if (mathOperator == "//")
            {
                result = firstDigit / secondDigit;
            }
            else if (mathOperator == "^")
            {
                result = (int)Math.Pow(firstDigit, secondDigit);
            }
            else
            { 
                Console.WriteLine("Please try again, only accepts the following operators: +,-,*,/,^");
                Console.WriteLine();
                goto calculator;
            }
            Console.WriteLine();
            Console.WriteLine(firstDigit + " " + mathOperator + " " + secondDigit + " = " + result);
            Console.ReadKey();
        }
    }
}
