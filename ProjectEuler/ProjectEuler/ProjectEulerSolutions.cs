﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ProjectEulerSolutions
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public void MultiplesOf3And5()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("1 : Multiples of 3 and 5");
            Console.WriteLine(sum);
        }
        /// <summary>
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        public void EvenFibinacciNumbers()
        {
            int sum = 0;
            int fib1 = 1;
            int fib2 = 2;
            int fibTemp = 0;
            while (fib1 <= 4000000 && fib2 <= 4000000)
            {
                if (fib2 % 2 == 0)
                {
                    sum += fib2;
                }
                fibTemp = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibTemp;
            }
            Console.WriteLine("2 : Even Fibinacci numbers");
            Console.WriteLine(sum);
        }
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public void LargestPrimeFactor()
        {
            long number = 600851475143;
            long numberTemp = number;
            long largestFactor = 0;
            int counter = 3;
            while (counter * counter <= numberTemp)
            {
                if (numberTemp % counter == 0)
                {
                    numberTemp = numberTemp / counter;
                    largestFactor = counter;
                }
                else
                {
                    counter+=2;
                }
            }
            if (numberTemp > largestFactor)
            {
                largestFactor = numberTemp;
            }
            Console.WriteLine("3 : Largest prime factor");
            Console.WriteLine(largestFactor);
        }
    }
}
