/*
 * This Program will calculate the sales commission based on the user input of the price of the product how many units were sold and the employee type (Commission employee, Salaried, or Manager)
 *
 */

namespace SalesCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int productQuantitySold;
            double pricePerUnit;
            string employeeJobCode;
            double salesTotal;
            double commission;

            salesTotal = 0;
            commission = 0;

            //Variable Input from User
            Console.Write("How many products were sold? ");
            productQuantitySold = Convert.ToInt32(Console.ReadLine());
            Console.Write("What was the price per product sold?  ");
            pricePerUnit = Convert.ToDouble(Console.ReadLine());
        employeetype:
            Console.Write("What is the employee job code?  ");
            employeeJobCode = Console.ReadLine();
            salesTotal = productQuantitySold * pricePerUnit;


            //Commission employee if else statement
            if (employeeJobCode == "C" || employeeJobCode == "c")
            {
                if (salesTotal > 1000)
                {
                    commission = 100.0 + 0.03 * (salesTotal - 1000);
                }
                else
                {
                    commission = 50.0 + 0.04 * salesTotal;
                }
            }


            //Salaried employee if else statement
            else if (employeeJobCode == "S" || employeeJobCode == "s")
            {
                commission = 0.03 * salesTotal;
            }


            //Management if else statement
            else if (employeeJobCode == "M" || employeeJobCode == "m")
            {
                if (salesTotal > 1000)
                {
                    commission = 50.0;
                }
                else
                {
                    commission = 0;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The employee type entered is not recognized, please enter a valid employee type: C,S,M");
                goto employeetype;
            }
            Console.WriteLine();
            Console.WriteLine("Sales commission is {0:C} ", commission);
            Console.ReadKey();
        }
    }
}
