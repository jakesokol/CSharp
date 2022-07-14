///MoneyChanger
using System;

namespace MoneyChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountincents;
            int dollars;
            int quarters;
            int dimes;
            int nickels;
            int pennies;

            amountincents = 1156;
            dollars = amountincents / 100;
            pennies = amountincents % 100;
            quarters = pennies / 25;
            pennies = pennies % 25;
            dimes = pennies / 10;
            pennies = pennies % 10;
            nickels = pennies / 5;
            pennies = pennies % 5;

            Console.WriteLine("Amount of money to be changed:  " + amountincents + " pennies");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Number of dollars: " + dollars);
            Console.WriteLine("Number of quarters:  " + quarters);
            Console.WriteLine("Number of dimes:  " + dimes);
            Console.WriteLine("Number of nickels: " + nickels);
            Console.WriteLine("Number of pennies: " + pennies);
            Console.ReadKey();
        }
    }
}
