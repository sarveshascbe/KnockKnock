using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockTest.Helpers
{
    /// <summary>
    /// Fibonaaci Helper
    /// </summary>
    public class FibonacciHelper
    {
        //Threshold to handle negative overflow when calculating fibonacci value
        private readonly long threshold = 92;

        /// <summary>
        /// Fibonacci value for Nth place in fibonacci series
        /// </summary>
        /// <param name="number">Nth number in fibonacci series</param>
        /// <returns>Fibonacci value for Nth place in fibonacci series</returns>
        public long GetNthFibonacci(long number)
        {
            if (number > threshold) throw new ArgumentOutOfRangeException($"Value cannot be greater than {threshold}");
            if (number < -threshold) throw new ArgumentOutOfRangeException($"Value cannot be greater than {-threshold}");

            //Calculate using binet formula
            var numerator = Math.Pow((1.0 + Math.Sqrt(5.0)), number) - Math.Pow((1.0 - Math.Sqrt(5.0)), number);
            var denominator = Math.Pow(2.0, number) * Math.Sqrt(5.0);
            var result = numerator / denominator;

            var roundedResult = Math.Round(result);

            return (long)roundedResult;
        }
    }
}