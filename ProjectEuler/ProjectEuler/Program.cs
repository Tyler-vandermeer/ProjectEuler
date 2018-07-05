using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectEulerSolutions1To10 solutions1To10 = new ProjectEulerSolutions1To10();
            //1 : Multiples of 3 and 5
            solutions1To10.MultiplesOf3And5();

            //2 : Even Fibinacci Numbers
            solutions1To10.EvenFibinacciNumbers();

            //3 : Largest Prime Factor
            solutions1To10.LargestPrimeFactor();

            //4 : Largest Palindrome Number
            solutions1To10.LargestPalindromeProduct();

            //5 : Smallest Multiple
            solutions1To10.SmallestMultiple();

            //6 : Sum Square Difference
            solutions1To10.SumSquareDifference();

            //7 : 10001st Prime
            solutions1To10._10001stPrime();

            //8 : Largest Product In A Series
            solutions1To10.LargestProductInASeries();

            //9 : Special Pythagorean Triplet
            solutions1To10.SpecialPythagoreanTriplet();

            //10 : Summation Of Primes
            solutions1To10.SummationOfPrimes();

            //To keep the program from stopping before seeing the solution
            Console.ReadKey();
        }
    }
}
