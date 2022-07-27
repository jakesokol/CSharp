/* This program will determine the tip amount for 15% and 20% from the total meal charges and then display the total amount due for both 15% and 20% tips
 * The program will use three methods to obtain the mealcharge, calculatetip, and display results
 * 
 */

using System;


namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = GetMealCharge();
            double tip = GetTipAmount(15.0, mealCost);
            DisplayMealBill(mealCost, 9.0, tip, 15.0);
            tip = GetTipAmount(20.0, mealCost);
            DisplayMealBill(mealCost, 9.0, tip, 20.0);
            Console.ReadKey();
        }
        // GetMealCharge Method to obtain meal amount
        static double GetMealCharge()
        {
            double charge;
            Console.WriteLine("Enter the charges for the meal");
            charge = double.Parse(Console.ReadLine());
            return charge;
        }

        // GetTipAmount Method to calculate tip
        static double GetTipAmount(double tipRate, double mealCost)
        {
            double amount;
            amount = tipRate * mealCost / 100.0; // Assume tip rate is a percent
            return amount;
        }

        // DislpayMealBill Method to display the bill for each tip amount
        static void DisplayMealBill(double meal, double tax, double tip, double
        tipRate)
        {
            Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐");
            Console.WriteLine("Meal charge = {0:C}", meal);
            double taxAmount = meal * tax / 100.0;
            Console.WriteLine("Tax on meal = {0:C}", taxAmount);
            double total = meal + taxAmount;
            Console.WriteLine("Total before tip = {0:C}", total);
            Console.WriteLine("Tip Amount = {0:C} for {1:P} tip", tip,
            tipRate / 100.0);
            Console.WriteLine("Total = {0:C}", (total + tip));
            Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐");
        }
    }
} 
