using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class IntroGatesTests
    {
        [TestCase(16,11,5,3, ExpectedResult = 96, Description = "Gates4.1")]
        [TestCase(1, 1, 1, 1, ExpectedResult = 0, Description = "Gates4.2")]
        [TestCase(13,6,8,3, ExpectedResult = 18, Description = "Gates4.3")]
        [TestCase(60,100,60,1, ExpectedResult = 99, Description = "Gates4.4")]
        [TestCase(1000, 1000, 1000, 1000, ExpectedResult = 0, Description = "Gates4.4")]
        public int TestseatsInTheater(int nCols, int nRows, int col, int row)
        {
            return IntroGates.seatsInTheater(nCols, nRows, col, row);
        }

        [TestCase(3, 10, ExpectedResult = 9, Description = "Gates3.1")]
        [TestCase(1, 2, ExpectedResult = 2, Description = "Gates3.2")]
        [TestCase(10, 5, ExpectedResult = 0, Description = "Gates3.3")]
        [TestCase(4, 4, ExpectedResult = 4, Description = "Gates3.4")]
        public int Testcandies(int n, int m)
        {
            return IntroGates.candies(n, m);
        }


        [TestCase(2, ExpectedResult = 99, Description = "Gates2.1")]
        [TestCase(1, ExpectedResult = 9, Description = "Gates2.2")]
        public int TestlargestNumber(int n)
        {
            return IntroGates.largestNumber(n);
        }

        [TestCase(29, ExpectedResult = 11, Description = "Gates1.1")]
        [TestCase(48, ExpectedResult = 12, Description = "Gates1.2")]
        [TestCase(10, ExpectedResult = 1, Description = "Gates1.3")]
        [TestCase(25, ExpectedResult = 7, Description = "Gates1.4")]
        public int TestaddTwoDigits(int n)
        {
            return IntroGates.addTwoDigits(n);
        }
    }
}
