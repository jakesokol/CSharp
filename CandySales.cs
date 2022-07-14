//CandySales
namespace CandySales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int cases;
            int BarsPerCase;
            double price;
            double CostOfCase;
            double StudentGovPercent;
            double PurchaseCost;
            double sales;
            double earnings;
            double StudentGovProceeds;
            double NetProceeds;

            //Define Variable Values
            cases = 37;
            BarsPerCase = 12;
            price = 1.45;
            CostOfCase = 6;
            StudentGovPercent = .1;
            PurchaseCost = cases * CostOfCase;
            sales = cases * BarsPerCase * price;
            earnings = sales - PurchaseCost;
            StudentGovProceeds = earnings * StudentGovPercent;
            NetProceeds = earnings - StudentGovProceeds;

            //Ouput
            Console.WriteLine("Number of cases of candy = " + cases);
            Console.WriteLine("Cost of a case = {0:c}", CostOfCase);
            Console.WriteLine("Number of bars per case = " + BarsPerCase);
            Console.WriteLine("Sale price of a candy bar = {0:c}", price);
            Console.WriteLine("Net proceeds from candy sales = {0:c}", NetProceeds);
            Console.ReadKey();
        }
    }
}
