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
            //Project Euler 1 : Multiples of 3 and 5
            ProjectEulerSolutions solution = new ProjectEulerSolutions();
            solution.MultiplesOf3And5();
            //Project Euler 2 : Even Fibinacci numbers
            solution.EvenFibinacciNumbers();
            Console.ReadKey();
        }
    }
}
