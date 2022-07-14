//RetailPriceofShirts
using System;


namespace RetailPriceofShirts
{
	class Program
	{
		static void Main(string[] args)
			
		{
			string shirtname = "Open Collar Running Shirt";
			double wholesaleprice = 41.00;
			double discountrate = 0.15;
			double discountapplied = wholesaleprice * discountrate;
			double netprice = wholesaleprice - discountapplied;

			Console.WriteLine("Item: " + shirtname);
            		Console.WriteLine("Wholesale price of item: {0:C}" , wholesaleprice);
			Console.WriteLine("Discount applied: {0:C}" , discountapplied);
            		Console.WriteLine("Discount Rate:  {0:P}" ,  discountrate);
			Console.WriteLine("Net price of the item: {0:C}" , netprice);
		}
	}
}
