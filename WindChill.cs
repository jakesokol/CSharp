//WindChill
using System;
using static System.Math;

namespace WindChill
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            double windSpeed;
            double twc;

            temperature://I hated that the program crashed so I looked up how to loop it until the desired data is received... I don't know if this is the best way to do it.
                Console.WriteLine();
                Console.WriteLine("Enter a temperature between -58 and 41 Farenheit degrees");
                temp = Convert.ToDouble(Console.ReadLine());
          
                if (temp < -58.0) {
                    Console.WriteLine("The temperature entered is less than -58 degrees Farenheit, it is too low");
                    Console.WriteLine();
                goto temperature;
            }

                if (temp > 41) {
                    Console.WriteLine("The temperature entered is above 41 degrees Farenheit, it is too high");
                    Console.WriteLine();
                goto temperature;
            }


            windspeed://Gather windspeed input 
                Console.WriteLine();
                Console.WriteLine("Enter wind velocity above 2 mph");
                windSpeed = Convert.ToDouble(Console.ReadLine());
            
                if (windSpeed < 2.0) {
                    Console.WriteLine("The wind velocity entered is below 2 mph, that is too low");
                    Console.WriteLine();
                goto windspeed;
            }

            twc = 35.74 + 0.6215 * temp - 35.75 * Pow(windSpeed, 0.16) + 0.4275 * temp * Pow(windSpeed, 0.16);

            Console.WriteLine();
            Console.WriteLine("The Wind Chill is =  {0:f5}", twc);
            Console.ReadKey();
        }
    }
}
