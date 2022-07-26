/ Creates three array.  Calculating the product of the two arrays in the third array the lists the three arrays

using System;

namespace ArrayProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ArrayOne = { 2, 3, 7, 5, 6, 9 };
            double[] ArrayTwo = { 10, 14, 11, 12, 17, 21 };
            double[] ArrayThree = new double[6];
            for (int i = 0; i < ArrayOne.Length; i++)
            {
                ArrayThree[i] = ArrayOne[i] * ArrayTwo[i];
            }
            
            Console.WriteLine("Array 1");
            foreach (double d in ArrayOne)
            {
                Console.Write(d + "  ");
            }
            Console.WriteLine("\n\nArray 2");
            foreach (double d in ArrayTwo)
            {
                Console.Write(d + "  ");
            }
            Console.WriteLine("\n\nProduct of Array 1 and Array 2");
            for (int i = 0; i < ArrayThree.Length; i++)
            {
                Console.Write(ArrayThree[i] + "  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
