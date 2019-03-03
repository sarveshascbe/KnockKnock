using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockTest.Helpers
{
    /// <summary>
    /// Returns Shape based on side values
    /// </summary>
    public class ShapeHelper
    {
        private bool IsEquilateral(int a, int b, int c)
        {
            return (a == b && a == c);
        }

        private bool IsIsosceles(int a, int b, int c)
        {
            return (a == b || a == c || b == c);
        }

        private bool IsScalene(int a, int b, int c)
        {
            return (a != b && a != c && b != c);
        }

        private bool IsTriangle(int a, int b, int c)
        {
            bool isTriangle = true;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                isTriangle = false;
            }
            else if ((a + b) <= c)
            {
                isTriangle = false;
            }
            else if ((a + c) <= b)
            {
                isTriangle = false;
            }
            else if ((b + c) <= a)
            {
                isTriangle = false;
            }

            return isTriangle;
        }

        /// <summary>
        /// Determines triangle type
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        /// <returns>Triangle Type</returns>
        public string GetTriangleType(int a, int b, int c)
        {
            if (!IsTriangle(a,b,c))
            {
                return TriangleType.Error.ToString();
            }
            else
            {
                if (IsEquilateral(a, b, c)) return TriangleType.Equilateral.ToString();
                if (IsScalene(a, b, c)) return TriangleType.Scalene.ToString();
                if (IsIsosceles(a, b, c)) return TriangleType.Isosceles.ToString();
            }
            return String.Empty;
        }
    }
}