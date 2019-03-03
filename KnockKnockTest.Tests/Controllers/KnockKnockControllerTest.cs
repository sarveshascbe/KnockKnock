using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnockTest;
using KnockKnockTest.Controllers;
using KnockKnockTest.Helpers;

namespace KnockKnockTest.Tests.Controllers
{
    [TestClass]
    public class KnockKnockControllerTest
    {
        [TestMethod]
        public void CalculateFibonacciTest()
        {
            //Arrange
            FibonacciHelper helper = new FibonacciHelper();

            //Act
            var test1 = helper.GetNthFibonacci(0);
            var test2 = helper.GetNthFibonacci(1);
            var test3 = helper.GetNthFibonacci(13);

            long? test4 = null;
            try
            {
                test4 = helper.GetNthFibonacci(93);
            }
            catch (Exception)
            {
            }

            long? test5 = null;
            try
            {
                test5 = helper.GetNthFibonacci(-93);
            }
            catch (Exception)
            {
            }

            // Assert
            Assert.IsTrue(test1 == 0);
            Assert.IsTrue(test2 == 1);
            Assert.IsTrue(test3 == 233);
            Assert.IsTrue(test4 == null);
            Assert.IsTrue(test5 == null);
        }

        [TestMethod]
        public void ShapeTypeTest()
        {
            //Arrange
            ShapeHelper helper = new ShapeHelper();

            //Act
            var test1 = helper.GetTriangleType(-1, 1, 1);

            var test2 = helper.GetTriangleType(5, 5, 5);

            var test3 = helper.GetTriangleType(4, 4, 2);

            var test4 = helper.GetTriangleType(5, 6, 7);

            //Assert
            Assert.IsTrue(test1 == TriangleType.Error.ToString());
            Assert.IsTrue(test2 == TriangleType.Equilateral.ToString());
            Assert.IsTrue(test3 == TriangleType.Isosceles.ToString());
            Assert.IsTrue(test4 == TriangleType.Scalene.ToString());
        }

        [TestMethod]
        public void StringReverseTest()
        {
            //Arrange
            StringHelper helper = new StringHelper();

            //Act
            var test1 = helper.ReverseWords("Testing!!!!");
            var test2 = helper.ReverseWords(String.Empty);
            var test3 = helper.ReverseWords("Sarvesh Ramamoorthy");
            
            //Assert
            Assert.IsTrue(test1 == "!!!!gnitseT");
            Assert.IsTrue(test2 == String.Empty);
            Assert.IsTrue(test3 == "hsevraS yhtroomamaR");
        }
    }
}
