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
            ProjectEulerOne one = new ProjectEulerOne();
            one.MultiplesOf3And5();
            //Ensure the program doesn't end bedore seeing the result.
            Console.ReadKey();
        }
    }
}
