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
            //Project Euler 1 : Multiples of 3 and 5
            solution.MultiplesOf3And5();
            //Project Euler 2 : Even Fibinacci numbers
            solution.EvenFibinacciNumbers();
            //Project Euler 3 : Largest prime factor
            solution.LargestPrimeFactor();
            //To keep the program from stopping before seeing the solution
            Console.ReadKey();
        }
    }
}
