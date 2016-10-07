/*
 * By https://github.com/GabrielLeme
 */

using System;

namespace ProjectEuler_EvenFIbonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exceededFourMillion = false;

            int firstTerm = 1;
            int secondTerm = 2;
            int thirdTerm = 0;

            int sumOfEvenNumbers = 2;

            while (!exceededFourMillion)
            {
                thirdTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = thirdTerm;

                if (thirdTerm < 4000000 && thirdTerm % 2 == 0)
                    sumOfEvenNumbers += thirdTerm;
                else if (thirdTerm > 4000000)
                    exceededFourMillion = true;
            }

            Console.WriteLine("Sum of even numbers = " + sumOfEvenNumbers);
            Console.ReadKey();

        }
    }
}
