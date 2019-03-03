using KnockKnockTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnockTest.Controllers
{
    public class KnockKnockController : ApiController
    {
        /// <summary>
        /// Returns the nth number in the fibonacci sequence.
        /// </summary>
        /// <param name="number">The index (n) of the fibonacci sequence</param>
        /// <returns>Returns the nth number in the fibonacci sequence.</returns>
        [Route("api/Fibonacci")]
        public long GetNthFibonacci(long number)
        {
            return new FibonacciHelper().GetNthFibonacci(number); 
        }

        /// <summary>
        /// Returns the type of triangle given the lengths of its sides
        /// </summary>
        /// <param name="a">The length of side a</param>
        /// <param name="b">The length of side b</param>
        /// <param name="c">The length of side c</param>
        /// <returns>Returns the type of triangle given the lengths of its sides</returns>
        [Route("api/TriangleType")]
        public string GetTriangleType(int a,int b, int c)
        {
            return new ShapeHelper().GetTriangleType(a, b, c);
        }

        /// <summary>
        /// Reverses the letters of each word in a sentence.
        /// </summary>
        /// <param name="sentence">A sentence</param>
        /// <returns>Reverses the letters of each word in a sentence.</returns>
        [Route("api/ReverseWords")]
        public string GetReversedWords(string sentence)
        {
            return new StringHelper().ReverseWords(sentence);
        }

        /// <summary>
        /// Your token.
        /// </summary>
        /// <returns>GUID</returns>
        [Route("api/Token")]
        public Guid GetToken()
        {
            return new Guid("e70431a2-39ca-44b0-98e3-6ffb7bdb47cc");
        }
    }
}
