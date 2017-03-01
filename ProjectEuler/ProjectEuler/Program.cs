using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectEulerSolutions solution = new ProjectEulerSolutions();
            //1 : Multiples of 3 and 5
            solution.MultiplesOf3And5();
            //2 : Even Fibinacci Numbers
            solution.EvenFibinacciNumbers();
            //3 : Largest Prime Factor
            solution.LargestPrimeFactor();
            //4 : Largest Palindrome Number
            solution.LargestPalindromeProduct();
            //5 : Smallest Multiple
            solution.SmallestMultiple();
            //To keep the program from stopping before seeing the solution
            Console.ReadKey();
        }
    }
}
